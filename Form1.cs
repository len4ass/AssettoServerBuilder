using System.IO.Compression;

namespace AssettoServerBuilder
{
    public partial class Form1 : Form
    {
        public static string s_AppBasePath { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        #region Methods attached to events

        private void OnFormShown(object sender, EventArgs e)
        {
            s_AppBasePath = Directory.GetCurrentDirectory();
            pathServerBase.Text = Settings1.Default.pathServerBase ?? string.Empty;
            pathPackedServer.Text = Settings1.Default.pathPackedServer ?? string.Empty;
            pathAiFolder.Text = Settings1.Default.pathAiFolder ?? string.Empty;
            pathExtraConfig.Text = Settings1.Default.pathExtraConfig ?? string.Empty;
            aiCarsAmount.Text = Settings1.Default.aiCarsAmount.ToString();
            pathOutputFolder.Text = Settings1.Default.pathOutputFolder ?? string.Empty;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Settings1.Default.pathServerBase = pathServerBase.Text ?? string.Empty;
                Settings1.Default.pathPackedServer = pathPackedServer.Text ?? string.Empty;
                Settings1.Default.pathAiFolder = pathAiFolder.Text ?? string.Empty;
                Settings1.Default.pathExtraConfig = pathExtraConfig.Text ?? string.Empty;
                int.TryParse(aiCarsAmount.Text, out int cars);
                Settings1.Default.aiCarsAmount = cars;
                Settings1.Default.pathOutputFolder = pathOutputFolder.Text ?? string.Empty;
                Settings1.Default.Save();
            } catch (Exception)
            {
                MessageBox.Show(@"Failed to update application settings.",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void OnBrowseServerBase(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.SelectedPath;
            pathServerBase.Text = path;
        }

        private void OnBrowsePackedServer(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = @"ZIP archives (*.zip)|*.zip";

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.FileName;
            pathPackedServer.Text = path;
        }

        private void OnBrowseAiFolder(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.SelectedPath;
            pathAiFolder.Text = path;
        }

        private void OnBrowseExtraConfig(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = @"YML config (*.yml)|*.yml";

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.FileName;
            pathExtraConfig.Text = path;
        }

        private void OnBrowseOutputFolder(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.SelectedPath;
            pathOutputFolder.Text = path;
        }

        private void OnPack(object sender, EventArgs e)
        {
            if (pathOutputFolder.Text is null || !Directory.Exists(pathOutputFolder.Text))
            {
                MessageBox.Show(@"Output folder was not specified or does not exist. Terminated packing.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                Build();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Packing failed. See output.log for more information.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.Log($"{exception.Message}\n{exception}");
            }
        }

        #endregion

        #region Utility methods
        
        private bool PrepareOutputFolder()
        {
            var files = Directory.GetFiles(pathOutputFolder.Text);
            var directories = Directory.GetDirectories(pathOutputFolder.Text);

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
            
            FileExtras.CleanFolder(new DirectoryInfo(pathOutputFolder.Text));
            return true;
        }

        private void CopyServerBase()
        {
            if (pathServerBase.Text is null || !Directory.Exists(pathServerBase.Text))
            {
                MessageBox.Show(@"Base server folder was not specified or does not exist.",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                throw new ArgumentException(@"Base server folder was not specified or does not exist.");
            }

            FileExtras.CopyFolderContents(new DirectoryInfo(pathServerBase.Text), new DirectoryInfo(pathOutputFolder.Text));
        }

        private void CopyPackedServer()
        {
            if (pathPackedServer.Text is null || !File.Exists(pathPackedServer.Text))
            {
                MessageBox.Show(@"Packed server was not specified or does not exist.",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                throw new ArgumentException(@"Packed server was not specified or does not exist.");
            }

            FileExtras.CopyFromArchive(pathPackedServer.Text, pathOutputFolder.Text);
        }

        private void CopyAiFolder()
        {
            if (pathAiFolder.Text is null || pathAiFolder.Text.Length == 0)
            {
                return;
            }

            if (!Directory.Exists(pathAiFolder.Text))
            {
                MessageBox.Show($@"AI folder path does not exist. Continuing packing...",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
            }

            var tracksPath = Path.Combine(pathOutputFolder.Text, "content\\tracks\\");
            if (!Directory.Exists(tracksPath))
            {
                MessageBox.Show(@"Subdirectory \content\tracks was not found in output folder.",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                throw new ArgumentException(@"Subdirectory \content\tracks was not found in output folder.");
            }

            var targetFolder = new DirectoryInfo(tracksPath);
            var dirs = targetFolder.GetDirectories();
            foreach (var dir in dirs)
            {
                // Not safe as these folders are not guaranteed to be there
                if (dir.Name == "csp")
                {
                    var newTargetFolder = new DirectoryInfo(dir.FullName).GetDirectories()[0];
                    Directory.CreateDirectory(Path.Combine(dir.FullName, newTargetFolder.Name, "ai\\"));
                    FileExtras.CopyFolderContents(new DirectoryInfo(pathAiFolder.Text), 
                        new DirectoryInfo(Path.Combine(dir.FullName, newTargetFolder.Name, "ai\\")));
                } else
                {
                    Directory.CreateDirectory(Path.Combine(dir.FullName, "ai\\"));
                    FileExtras.CopyFolderContents(new DirectoryInfo(pathAiFolder.Text), 
                        new DirectoryInfo(Path.Combine(dir.FullName, "ai\\")));
                }
            }
        }

        private void CopyExtraConfig()
        {
            if (pathExtraConfig.Text is null || pathExtraConfig.Text.Length == 0)
            {
                return;
            }

            if (!File.Exists(pathExtraConfig.Text))
            {
                MessageBox.Show(@"Extra config on given path does not exist.",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                throw new ArgumentException(@"Extra config on given path does not exist.");
            }

            var cfgPath = Path.Combine(pathOutputFolder.Text, "cfg\\");
            if (!Directory.Exists(cfgPath))
            {
                MessageBox.Show(@"Subdirectory \cfg was not found in output folder.",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                throw new ArgumentException(@"Subdirectory \cfg was not found in output folder.");
            }

            try
            {
                File.Copy(pathExtraConfig.Text, Path.Combine(cfgPath, Path.GetFileName(pathExtraConfig.Text)));
            } catch (Exception)
            {
                MessageBox.Show($@"Failed to copy {Path.GetFileName(pathExtraConfig.Text)}. See output.log for more information.",
                   @"Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                throw;
            }
        }

        private void PatchAiFixed()
        {
            if (!int.TryParse(aiCarsAmount.Text, out int cars) || cars == 0)
            {
                return;
            }

            var cfgPath = Path.Combine(pathOutputFolder.Text, "cfg\\");
            if (!Directory.Exists(cfgPath))
            {
                MessageBox.Show(@"Subdirectory \cfg was not found in output folder.",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                throw new ArgumentException(@"Subdirectory \cfg was not found in output folder.");
            }

            if (!File.Exists(Path.Combine(cfgPath, "entry_list.ini")))
            {
                MessageBox.Show(@"entry_list.ini was not found in \cfg subdirectory in output folder.",
                 @"Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                throw new ArgumentException(@"entry_list.ini was not found in \cfg subdirectory in output folder.");
            }

            var entries = FileExtras.ReadFileContent(Path.Combine(cfgPath, "entry_list.ini")).Split("\n");
            for (int i = 0; i < cars * 10 && i < entries.Length - 1; i++)
            {
                // Replacing "empty" lines in between cars, still better than .ini serialization
                if (!entries[i].Any(Char.IsLetter))
                {
                    entries[i] = "AI=fixed";
                }
            }

            FileExtras.WriteFileContent(Path.Combine(cfgPath, "entry_list.ini"), string.Join('\n', entries));
        }

        private void Zip()
        {
            try
            {
                var outputFolderName = Path.GetFileName(pathOutputFolder.Text);
                var packOutput = Path.Combine(Path.GetFullPath(Path.Combine(pathOutputFolder.Text, "../")), 
                    $"{outputFolderName} {DateTime.Now:yyyy-MM-dd HH-mm-ss}.zip");
                ZipFile.CreateFromDirectory(pathOutputFolder.Text, packOutput);
            } catch (Exception)
            {
                MessageBox.Show($@"Couldn't zip {Path.GetDirectoryName(pathOutputFolder.Text)}. See output.log for more information.",
                @"Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                throw;
            }
        }
        
        private void Build()
        {
            if (!PrepareOutputFolder())
            {
                return;
            }

            var startTime = DateTime.Now;
            CopyServerBase();
            CopyPackedServer();
            CopyAiFolder();
            CopyExtraConfig();
            PatchAiFixed();
            Zip();
            var endTime = DateTime.Now;

            MessageBox.Show($@"Packing completed in {(endTime - startTime).TotalSeconds:F2} seconds.",
                @"Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            FileExtras.OpenFolder(pathOutputFolder.Text);
        }
        
        #endregion
    }
}