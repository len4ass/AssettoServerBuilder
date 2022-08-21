using System.IO.Compression;
using AssettoServerBuilder.Presets;
using AssettoServerBuilder.Serializer;
using AssettoServerBuilder.Types;
using AssettoServerBuilder.Workers;
using IniParser;
using IniParser.Model;

namespace AssettoServerBuilder
{
    public partial class Form1 : Form
    {
        public static List<Entry> Entries = new ();
        public static int SortEntries { get; set; }
        public static string? s_AppBasePath { get; set; }
        private ApplicationPreset _preset = new();

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
            boolModifyEntryList.Checked = Settings1.Default.ModifyEntryList;
            pathOutputFolder.Text = Settings1.Default.pathOutputFolder ?? string.Empty;
            serverName.Text = Settings1.Default.serverName ?? string.Empty;
            tcpPort.Text = Settings1.Default.tcpPort.ToString();
            udpPort.Text = Settings1.Default.udpPort.ToString();
            httpPort.Text = Settings1.Default.httpPort.ToString();
            SetSettings();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Settings1.Default.pathServerBase = pathServerBase.Text ?? string.Empty;
                Settings1.Default.pathPackedServer = pathPackedServer.Text ?? string.Empty;
                Settings1.Default.pathAiFolder = pathAiFolder.Text ?? string.Empty;
                Settings1.Default.pathExtraConfig = pathExtraConfig.Text ?? string.Empty;
                Settings1.Default.pathOutputFolder = pathOutputFolder.Text ?? string.Empty;
                Settings1.Default.serverName = serverName.Text ?? string.Empty;
                Settings1.Default.ModifyEntryList = boolModifyEntryList.Checked;
                
                int.TryParse(tcpPort.Text, out int tcp);
                int.TryParse(udpPort.Text, out int udp);
                int.TryParse(httpPort.Text, out int http);
                
                Settings1.Default.tcpPort = tcp;
                Settings1.Default.udpPort = udp;
                Settings1.Default.httpPort = http;
                Settings1.Default.Save();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Failed to update application settings.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OnPresetLoad(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = s_AppBasePath;
            dialog.Filter = @"JSON (*.json)|*.json";

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var preset = Json.Deserialize<ApplicationPreset>(FStream.Read(dialog.FileName));
            if (preset is null)
            {
                MessageBox.Show(@"Incorrect preset.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _preset = preset;
            UpdateSettings();
        }

        private void OnPresetSave(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = s_AppBasePath;
            dialog.FileName = serverName.Text is null || serverName.Text.Length == 0
                ? "*.json"
                : $"{serverName.Text}.json";
            dialog.Filter = @"JSON (*.json)|*.json";

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            SetSettings();
            FStream.Write(dialog.FileName, Json.Serialize(_preset));
        }

        private void OnBrowseServerBase(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (pathServerBase.Text is not null && pathServerBase.Text.Length != 0)
            {
                dialog.InitialDirectory = pathServerBase.Text;
            }
            
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
            if (pathPackedServer.Text is not null && pathPackedServer.Text.Length != 0)
            {
                dialog.InitialDirectory = Path.GetFullPath(Path.Combine(pathPackedServer.Text, "../"));
            }

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
            if (pathAiFolder.Text is not null && pathAiFolder.Text.Length != 0)
            {
                dialog.InitialDirectory = pathAiFolder.Text;
            }

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
            if (pathExtraConfig.Text is not null && pathExtraConfig.Text.Length != 0)
            {
                dialog.InitialDirectory = Path.GetFullPath(Path.Combine(pathOutputFolder.Text, "../"));
            }

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
            if (pathOutputFolder.Text is not null && pathOutputFolder.Text.Length != 0)
            {
                dialog.InitialDirectory = pathOutputFolder.Text;
            }

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
                Entries.Clear();
                MessageBox.Show(@"Packing failed. See output.log for more information.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Logger.Log($"{exception.Message}\n{exception}");
            }
        }

        #endregion

        #region Utility methods

        private void SetSettings()
        {
            _preset.ServerName = serverName.Text ?? string.Empty;
            _preset.PathServerBase = pathServerBase.Text ?? string.Empty;
            _preset.PathServerPacked = pathPackedServer.Text ?? string.Empty;
            _preset.PathAiFolder = pathAiFolder.Text ?? string.Empty;
            _preset.PathExtraConfig = pathExtraConfig.Text ?? string.Empty;
            _preset.PathOutputFolder = pathOutputFolder.Text ?? string.Empty;
            _preset.ModifyEntryList = boolModifyEntryList.Checked;
            
            int.TryParse(tcpPort.Text, out int tcp);
            int.TryParse(udpPort.Text, out int udp);
            int.TryParse(httpPort.Text, out int http);
            _preset.TcpPort = tcp;
            _preset.UdpPort = udp;
            _preset.HttpPort = http;
        }

        private void UpdateSettings()
        {
            serverName.Text = _preset.ServerName;
            pathServerBase.Text = _preset.PathServerBase;
            pathPackedServer.Text = _preset.PathServerPacked;
            pathAiFolder.Text = _preset.PathAiFolder;
            pathExtraConfig.Text = _preset.PathExtraConfig;
            boolModifyEntryList.Checked = _preset.ModifyEntryList;
            tcpPort.Text = _preset.TcpPort.ToString();
            udpPort.Text = _preset.UdpPort.ToString();
            httpPort.Text = _preset.HttpPort.ToString();
            pathOutputFolder.Text = _preset.PathOutputFolder;
        }
        
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

            Folder.CleanFolder(new DirectoryInfo(pathOutputFolder.Text));
            return true;
        }

        private void CopyServerBase()
        {
            Folder.CopyFolderContents(new DirectoryInfo(pathServerBase.Text), new DirectoryInfo(pathOutputFolder.Text));
        }

        private void CopyPackedServer()
        {
            Archive.Extract(pathPackedServer.Text, pathOutputFolder.Text);
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
            var targetFolder = new DirectoryInfo(tracksPath);
            var dirs = targetFolder.GetDirectories();
            foreach (var dir in dirs)
            {
                if (dir.Name == "csp")
                {
                    var newTargetFolder = new DirectoryInfo(dir.FullName).GetDirectories()[0];
                    Directory.CreateDirectory(Path.Combine(dir.FullName, newTargetFolder.Name, "ai\\"));
                    Folder.CopyFolderContents(new DirectoryInfo(pathAiFolder.Text),
                        new DirectoryInfo(Path.Combine(dir.FullName, newTargetFolder.Name, "ai\\")));
                }
                else
                {
                    Directory.CreateDirectory(Path.Combine(dir.FullName, "ai\\"));
                    Folder.CopyFolderContents(new DirectoryInfo(pathAiFolder.Text),
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

            var cfgPath = Path.Combine(pathOutputFolder.Text, "cfg\\");
            File.Copy(pathExtraConfig.Text, Path.Combine(cfgPath, Path.GetFileName(pathExtraConfig.Text)));
        }

        private void PatchEntryList()
        {
            if (!boolModifyEntryList.Checked)
            {
                return;
            }
            
            var cfgPath = Path.Combine(pathOutputFolder.Text, "cfg\\");
            var entryListPath = Path.Combine(cfgPath, "entry_list.ini");

            var parser = new FileIniDataParser();
            var iniParsed = parser.ReadFile(entryListPath);
            Entries = Entry.IniToEntryList(iniParsed);
            
            var entryListForm = new Form2();
            entryListForm.ShowDialog();
            
            if (SortEntries == 1)
            {
                Entries = Entry.SortEntriesByAiNone(Entries);
            } else if (SortEntries == 2)
            {
                Entries = Entry.SortEntriesByAiFixed(Entries);
            }

            var ini = Entry.EntryListToIni(Entries);
            FStream.Write(entryListPath, ini.ToString());
        }

        private void ModifyServerConfig(IniData iniServerConfig)
        {
            iniServerConfig["SERVER"]["NAME"] = serverName.Text;
            iniServerConfig["SERVER"]["UDP_PORT"] = udpPort.Text;
            iniServerConfig["SERVER"]["TCP_PORT"] = tcpPort.Text;
            iniServerConfig["SERVER"]["HTTP_PORT"] = httpPort.Text;
        }
        
        private void PatchSettings()
        {
            var cfgPath = Path.Combine(pathOutputFolder.Text, "cfg\\");
            var serverCfgPath = Path.Combine(cfgPath, "server_cfg.ini");

            var parser = new FileIniDataParser();
            var iniServerConfig = parser.ReadFile(serverCfgPath);
            ModifyServerConfig(iniServerConfig);
            
            FStream.Write(serverCfgPath, iniServerConfig.ToString());
        }

        private void Zip()
        {
            var outputFolderName = Path.GetFileName(pathOutputFolder.Text);
            var packOutput = Path.Combine(Path.GetFullPath(Path.Combine(pathOutputFolder.Text, "../")), 
                $"{outputFolderName} {DateTime.Now:yyyy-MM-dd HH-mm-ss}.zip");
            ZipFile.CreateFromDirectory(pathOutputFolder.Text, packOutput);
        }
        
        private void Build()
        {
            if (!PrepareOutputFolder())
            {
                return;
            }

            SetSettings();
            CopyServerBase();
            CopyPackedServer();
            CopyAiFolder();
            CopyExtraConfig();
            PatchEntryList();
            PatchSettings();
            Zip();
            Entries.Clear();

            MessageBox.Show($@"Packing completed.",
                @"Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Folder.OpenFolder(pathOutputFolder.Text);
        }

        #endregion
    }
}