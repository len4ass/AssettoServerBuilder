using System.IO.Compression;
using AssettoServerBuilder.Presets;
using AssettoServerBuilder.Serializer;
using AssettoServerBuilder.Workers;

namespace AssettoServerBuilder
{
    public partial class Form1 : Form
    {
        public static string s_AppBasePath { get; set; }
        public ApplicationPreset Preset = new();

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
                
                int.TryParse(aiCarsAmount.Text, out int cars);
                int.TryParse(tcpPort.Text, out int tcp);
                int.TryParse(udpPort.Text, out int udp);
                int.TryParse(httpPort.Text, out int http);
                Settings1.Default.aiCarsAmount = cars;
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

            Preset = preset;
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
            FStream.Write(dialog.FileName, Json.Serialize(Preset));
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
            Preset.ServerName = serverName.Text ?? string.Empty;
            Preset.PathServerBase = pathServerBase.Text ?? string.Empty;
            Preset.PathServerPacked = pathPackedServer.Text ?? string.Empty;
            Preset.PathAiFolder = pathAiFolder.Text ?? string.Empty;
            Preset.PathExtraConfig = pathExtraConfig.Text ?? string.Empty;
            Preset.PathOutputFolder = pathOutputFolder.Text ?? string.Empty;

            int.TryParse(aiCarsAmount.Text, out int cars);
            int.TryParse(tcpPort.Text, out int tcp);
            int.TryParse(udpPort.Text, out int udp);
            int.TryParse(httpPort.Text, out int http);
            Preset.AiCarsAmount = cars;
            Preset.TcpPort = tcp;
            Preset.UdpPort = udp;
            Preset.HttpPort = http;
        }

        private void UpdateSettings()
        {
            serverName.Text = Preset.ServerName;
            pathServerBase.Text = Preset.PathServerBase;
            pathPackedServer.Text = Preset.PathServerPacked;
            pathAiFolder.Text = Preset.PathAiFolder;
            pathExtraConfig.Text = Preset.PathExtraConfig;
            aiCarsAmount.Text = Preset.AiCarsAmount.ToString();
            tcpPort.Text = Preset.TcpPort.ToString();
            udpPort.Text = Preset.UdpPort.ToString();
            httpPort.Text = Preset.HttpPort.ToString();
            pathOutputFolder.Text = Preset.PathOutputFolder;
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
            if (pathServerBase.Text is null || !Directory.Exists(pathServerBase.Text))
            {
                MessageBox.Show(@"Base server folder was not specified or does not exist.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw new ArgumentException(@"Base server folder was not specified or does not exist.");
            }

            Folder.CopyFolderContents(new DirectoryInfo(pathServerBase.Text), new DirectoryInfo(pathOutputFolder.Text));
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
            }
            catch (Exception)
            {
                MessageBox.Show(
                    $@"Failed to copy {Path.GetFileName(pathExtraConfig.Text)}. See output.log for more information.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }

        private void ReplaceAiFixed(string[] entries)
        {
            for (int i = 0; i < Preset.AiCarsAmount * 10 && i < entries.Length - 1; i++)
            {
                // Replacing "empty" lines in between cars, still better than .ini serialization
                if (!entries[i].Any(Char.IsLetter))
                {
                    entries[i] = "AI=fixed";
                }
            }
        }
        
        private void PatchAiFixed()
        {
            SetSettings();
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

            var entries = FStream.Read(Path.Combine(cfgPath, "entry_list.ini")).Split("\n");
            ReplaceAiFixed(entries);
            FStream.Write(Path.Combine(cfgPath, "entry_list.ini"), string.Join('\n', entries));
        }

        private void ReplaceServerConfig(string[] entries)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i].StartsWith("NAME=") && Preset.ServerName.Length != 0)
                {
                    entries[i] = $"NAME={Preset.ServerName}";
                    continue;
                }

                if (entries[i].StartsWith("UDP_PORT=") && Preset.UdpPort != 0)
                {
                    entries[i] = $"UDP_PORT={Preset.UdpPort}";
                    continue;
                }

                if (entries[i].StartsWith("TCP_PORT=") && Preset.TcpPort != 0)
                {
                    entries[i] = $"TCP_PORT={Preset.TcpPort}";
                    continue;
                }

                if (entries[i].StartsWith("HTTP_PORT=") && Preset.HttpPort != 0)
                {
                    entries[i] = $"HTTP_PORT={Preset.HttpPort}";
                }
            }
        }
        
        private void PatchSettings()
        {
            SetSettings();
            var cfgPath = Path.Combine(pathOutputFolder.Text, "cfg\\");
            if (!Directory.Exists(cfgPath))
            {
                MessageBox.Show(@"Subdirectory \cfg was not found in output folder.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw new ArgumentException(@"Subdirectory \cfg was not found in output folder.");
            }

            if (!File.Exists(Path.Combine(cfgPath, "server_cfg.ini")))
            {
                MessageBox.Show(@"server_cfg.ini was not found in \cfg subdirectory in output folder.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw new ArgumentException(@"server_cfg.ini was not found in \cfg subdirectory in output folder.");
            }
            
            var entries = FStream.Read(Path.Combine(cfgPath, "server_cfg.ini")).Split("\n");
            ReplaceServerConfig(entries);
            FStream.Write(Path.Combine(cfgPath, "server_cfg.ini"), string.Join('\n', entries));
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
            PatchSettings();
            Zip();
            var endTime = DateTime.Now;

            MessageBox.Show($@"Packing completed in {(endTime - startTime).TotalSeconds:F2} seconds.",
                @"Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Folder.OpenFolder(pathOutputFolder.Text);
        }
        
        #endregion
    }
}