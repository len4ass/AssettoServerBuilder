using AssettoServerBuilder.Presets;
using AssettoServerBuilder.Serializer;
using AssettoServerBuilder.Workers;

namespace AssettoServerBuilder
{
    public partial class Form1 : Form
    {
        private ApplicationPreset _preset = new();
        private readonly string _pathDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Form1()
        {
            InitializeComponent();
        }

        #region Event methods
        
        private void OnFormShown(object sender, EventArgs e)
        {
            try
            {
                var documents = new DirectoryInfo(_pathDocuments);
                bool directoryExists = documents.GetDirectories().Any(dir => dir.Name == "Assetto Server Builder");

                if (!directoryExists)
                {
                    documents.CreateSubdirectory("Assetto Server Builder\\");
                    File.Create(Path.Combine(_pathDocuments, "Assetto Server Builder\\", "output.log"));
                }
            }
            catch (Exception exception)
            {
                Logger.Log($"{exception.Message}\n{exception}");
            }

            Location = Settings1.Default.Location;
            _preset.ServerName = Settings1.Default.serverName ?? string.Empty;
            _preset.PathServerBase = Settings1.Default.pathServerBase ?? string.Empty;
            _preset.PathServerPacked = Settings1.Default.pathPackedServer ?? string.Empty;
            _preset.PathAiFolder = Settings1.Default.pathAiFolder ?? string.Empty;
            _preset.PathExtraConfig = Settings1.Default.pathExtraConfig ?? string.Empty;
            _preset.PathServerConfig = Settings1.Default.pathServerConfig ?? string.Empty;
            _preset.PathCspExtra = Settings1.Default.pathCspExtraConfig ?? string.Empty;
            _preset.PathWelcomeMessage = Settings1.Default.pathWelcomeMessage ?? string.Empty;
            _preset.PathOutputFolder = Settings1.Default.pathOutputFolder ?? string.Empty;
            _preset.ModifyEntryList = Settings1.Default.ModifyEntryList;

            UpdateSettings();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                UpdatePreset();
                Settings1.Default.Location = Location;
                Settings1.Default.serverName = _preset.ServerName;
                Settings1.Default.pathServerBase = _preset.PathServerBase;
                Settings1.Default.pathPackedServer = _preset.PathServerPacked;
                Settings1.Default.pathAiFolder = _preset.PathAiFolder;
                Settings1.Default.pathExtraConfig = _preset.PathExtraConfig;
                Settings1.Default.pathServerConfig = _preset.PathServerConfig;
                Settings1.Default.pathCspExtraConfig = _preset.PathCspExtra;
                Settings1.Default.pathWelcomeMessage = _preset.PathWelcomeMessage;
                Settings1.Default.pathOutputFolder = _preset.PathOutputFolder;
                Settings1.Default.ModifyEntryList = _preset.ModifyEntryList; 
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

        /*private void OnDataChange(object sender, EventArgs e)
        {
            UpdatePreset();
        }*/

        private void OnPresetLoad(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Path.Combine(_pathDocuments, "Assetto Server Builder");
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
            dialog.InitialDirectory = Path.Combine(_pathDocuments, "Assetto Server Builder");
            dialog.FileName = serverName.Text is null || serverName.Text.Length == 0
                ? "*.json"
                : $"{serverName.Text}.json";
            dialog.Filter = @"JSON (*.json)|*.json";

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            UpdatePreset();
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
                dialog.InitialDirectory = Path.GetFullPath(Path.Combine(pathExtraConfig.Text, "../"));
            }

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.FileName;
            pathExtraConfig.Text = path;
        }

        private void OnBrowseServerConfig(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = @".ini config (*.ini)|*.ini";
            if (pathServerConfig.Text is not null && pathServerConfig.Text.Length != 0)
            {
                dialog.InitialDirectory = Path.GetFullPath(Path.Combine(pathServerConfig.Text, "../"));
            }

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.FileName;
            pathServerConfig.Text = path;
        }
        
        private void OnBrowseCspExtraConfig(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = @".ini config (*.ini)|*.ini";
            if (pathCspExtraConfig.Text is not null && pathCspExtraConfig.Text.Length != 0)
            {
                dialog.InitialDirectory = Path.GetFullPath(Path.Combine(pathCspExtraConfig.Text, "../"));
            }

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.FileName;
            pathCspExtraConfig.Text = path;
        }
        
        private void OnBrowseWelcomeMessage(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = @"Text file (*.txt)|*.txt";
            if (pathWelcomeMessage.Text is not null && pathWelcomeMessage.Text.Length != 0)
            {
                dialog.InitialDirectory = Path.GetFullPath(Path.Combine(pathWelcomeMessage.Text, "../"));
            }

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = dialog.FileName;
            pathWelcomeMessage.Text = path;
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

        private void OnBuildCurrentPreset(object sender, EventArgs e)
        {
            if (pathOutputFolder.Text is null || !Directory.Exists(pathOutputFolder.Text))
            {
                MessageBox.Show(@"Output folder was not specified or does not exist. Terminated packing.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            UpdatePreset();
            
            try
            {
                Builder.Run(_preset);
            }
            catch (Exception exception)
            {
                Logger.Log($"{exception.Message}\n{exception}");
                var result = MessageBox.Show($@"Packing {_preset.ServerName} failed. See output.log for more information.",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                if (result != DialogResult.None)
                {
                    Folder.OpenFolder(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Assetto Server Builder\\"));
                }
            }
        }

        private void OnBuildMultiplePresets(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Path.Combine(_pathDocuments, "Assetto Server Builder");
            dialog.Filter = @"JSON (*.json)|*.json";
            dialog.Multiselect = true;
            dialog.Title = @"Choose multiple presets...";

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            foreach (string file in dialog.FileNames)
            {
                var preset = Json.Deserialize<ApplicationPreset>(FStream.Read(file));

                try
                {
                    if (preset is not null)
                    {
                        Builder.Run(preset);
                    }
                }
                catch (Exception exception)
                {
                    Logger.Log($"{exception.Message}\n{exception}");
                    var result = MessageBox.Show($@"Packing {preset!.ServerName} failed. See output.log for more information.",
                        @"Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    if (result != DialogResult.None)
                    {
                        Folder.OpenFolder(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Assetto Server Builder\\"));
                    }
                }
            }
        }
        
        #endregion
        
        #region Utility methods

        private void UpdatePreset()
        {
            _preset.ServerName = serverName.Text ?? string.Empty;
            _preset.PathServerBase = pathServerBase.Text ?? string.Empty;
            _preset.PathServerPacked = pathPackedServer.Text ?? string.Empty;
            _preset.PathAiFolder = pathAiFolder.Text ?? string.Empty;
            _preset.PathExtraConfig = pathExtraConfig.Text ?? string.Empty;
            _preset.PathServerConfig = pathServerConfig.Text ?? string.Empty;
            _preset.PathCspExtra = pathCspExtraConfig.Text ?? string.Empty;
            _preset.PathWelcomeMessage = pathWelcomeMessage.Text ?? string.Empty;
            _preset.PathOutputFolder = pathOutputFolder.Text ?? string.Empty;
            _preset.ModifyEntryList = boolModifyEntryList.Checked;
        }

        private void UpdateSettings()
        {
            serverName.Text = _preset.ServerName;
            pathServerBase.Text = _preset.PathServerBase;
            pathPackedServer.Text = _preset.PathServerPacked;
            pathAiFolder.Text = _preset.PathAiFolder;
            pathExtraConfig.Text = _preset.PathExtraConfig;
            pathServerConfig.Text = _preset.PathServerConfig;
            pathCspExtraConfig.Text = _preset.PathCspExtra;
            pathWelcomeMessage.Text = _preset.PathWelcomeMessage;
            pathOutputFolder.Text = _preset.PathOutputFolder;
            boolModifyEntryList.Checked = _preset.ModifyEntryList;
        }

        #endregion
    }
}