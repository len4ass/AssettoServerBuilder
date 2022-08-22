using System.IO.Compression;
using AssettoServerBuilder.Presets;
using AssettoServerBuilder.Types;
using IniParser;

namespace AssettoServerBuilder.Workers
{
    public static class Builder
    {
        public static int SortBy { get; set; }
        
        private static bool PrepareOutputFolder(string output)
        {
            var files = Directory.GetFiles(output);
            var directories = Directory.GetDirectories(output);

            if (files.Length == 0 && directories.Length == 0)
            {
                return true;
            }

            var result = MessageBox.Show("Files or directories have been found in the output folder. \n" +
                                         "Do you want to clean the output folder and pack?\n" +
                                         "'Yes' will clean the output folder and start packing, 'No' will abort.",
                @"Information",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return false;
            }

            Folder.CleanFolder(new DirectoryInfo(output));
            return true;
        }
        
        private static void CopyServerBase(string source, string target)
        {
            Folder.CopyFolderContents(new DirectoryInfo(source), new DirectoryInfo(target));
        }

        private static void CopyPackedServer(string source, string target)
        {
            Archive.Extract(source, target);
        }

        private static void CopyAiFolder(string source, string target)
        {
            if (source.Length == 0)
            {
                return;
            }

            if (!Directory.Exists(source))
            {
                MessageBox.Show($@"AI folder path does not exist. Continuing packing...",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var tracksPath = Path.Combine(target, "content\\tracks\\");
            var targetFolder = new DirectoryInfo(tracksPath);
            var dirs = targetFolder.GetDirectories();
            foreach (var dir in dirs)
            {
                if (dir.Name == "csp")
                {
                    var newTargetFolder = new DirectoryInfo(dir.FullName).GetDirectories()[0];
                    Directory.CreateDirectory(Path.Combine(dir.FullName, newTargetFolder.Name, "ai\\"));
                    Folder.CopyFolderContents(new DirectoryInfo(source),
                        new DirectoryInfo(Path.Combine(dir.FullName, newTargetFolder.Name, "ai\\")));
                }
                else
                {
                    Directory.CreateDirectory(Path.Combine(dir.FullName, "ai\\"));
                    Folder.CopyFolderContents(new DirectoryInfo(source),
                        new DirectoryInfo(Path.Combine(dir.FullName, "ai\\")));
                }
            }
        }
        
        private static void CopyExtraConfig(string source, string target)
        {
            if (source.Length == 0)
            {
                return;
            }

            var cfgPath = Path.Combine(target, "cfg\\");
            File.Copy(source, Path.Combine(cfgPath, "extra_cfg.yml"), true);
        }

        private static void CopyServerConfig(string source, string target)
        {
            if (source.Length == 0)
            {
                return;
            }

            var cfgPath = Path.Combine(target, "cfg\\");
            File.Copy(source, Path.Combine(cfgPath, "server_cfg.ini"), true);
        }

        private static void CopyCspExtra(string source, string target)
        {
            if (source.Length == 0)
            {
                return;
            }

            var cfgPath = Path.Combine(target, "cfg\\");
            File.Copy(source, Path.Combine(cfgPath, "csp_extra_options.ini"), true);
        }

        private static void CopyWelcomeMessage(string source, string target)
        {
            if (source.Length == 0)
            {
                return;
            }
            
            var cfgPath = Path.Combine(target, "cfg\\");
            File.Copy(source, Path.Combine(cfgPath, "welcome.txt"), true);
        }
        
        private static void PatchEntryList(string target, string serverName)
        {
            var cfgPath = Path.Combine(target, "cfg\\");
            var entryListPath = Path.Combine(cfgPath, "entry_list.ini");

            var parser = new FileIniDataParser();
            var iniParsed = parser.ReadFile(entryListPath);
            var entries = Entry.IniToEntryList(iniParsed);
            
            var entryListForm = new Form2(entries);
            entryListForm.Text = $@"{serverName} entry list";
            entryListForm.ShowDialog();
            
            if (SortBy == 1)
            {
                entries = Entry.SortEntriesByAiNone(entries);
            } else if (SortBy == 2)
            {
                entries = Entry.SortEntriesByAiFixed(entries);
            }

            var ini = Entry.EntryListToIni(entries);
            FStream.Write(entryListPath, ini.ToString());
        }
        
        private static void Zip(string target)
        {
            var outputFolderName = Path.GetFileName(target);
            var packOutput = Path.Combine(Path.GetFullPath(Path.Combine(target, "../")), 
                $"{outputFolderName} {DateTime.Now:yyyy-MM-dd HH-mm-ss}.zip");
            ZipFile.CreateFromDirectory(target, packOutput);
        }

        public static void Run(ApplicationPreset preset)
        {
            if (!PrepareOutputFolder(preset.PathOutputFolder))
            {
                return;
            }
            
            CopyServerBase(preset.PathServerBase, preset.PathOutputFolder);
            CopyPackedServer(preset.PathServerPacked, preset.PathOutputFolder);
            CopyAiFolder(preset.PathAiFolder, preset.PathOutputFolder);
            CopyExtraConfig(preset.PathExtraConfig, preset.PathOutputFolder);
            CopyServerConfig(preset.PathServerConfig, preset.PathOutputFolder);
            CopyCspExtra(preset.PathCspExtra, preset.PathOutputFolder);
            CopyWelcomeMessage(preset.PathWelcomeMessage, preset.PathOutputFolder);
            PatchEntryList(preset.PathOutputFolder, preset.ServerName);
            Zip(preset.PathOutputFolder);
   
            var result = MessageBox.Show($@"Packed {preset.ServerName} successfully.",
                @"Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (result != DialogResult.None)
            {
                Folder.OpenFolder(preset.PathOutputFolder);
            }
        }
    }
}