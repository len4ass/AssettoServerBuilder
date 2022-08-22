namespace AssettoServerBuilder
{
    public partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverBase = new System.Windows.Forms.Label();
            this.pathServerBase = new System.Windows.Forms.TextBox();
            this.browseBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathPackedServer = new System.Windows.Forms.TextBox();
            this.browsePackedServer = new System.Windows.Forms.Button();
            this.aiFolder = new System.Windows.Forms.Label();
            this.pathAiFolder = new System.Windows.Forms.TextBox();
            this.browseAiFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pathExtraConfig = new System.Windows.Forms.TextBox();
            this.browseExtraConfig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pathOutputFolder = new System.Windows.Forms.TextBox();
            this.browseOutputFolder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplePresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.pathServerConfig = new System.Windows.Forms.TextBox();
            this.pathCspExtraConfig = new System.Windows.Forms.TextBox();
            this.pathWelcomeMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boolModifyEntryList = new System.Windows.Forms.CheckBox();
            this.browseServerConfig = new System.Windows.Forms.Button();
            this.browseCspExtraConfig = new System.Windows.Forms.Button();
            this.browseWelcomeMessage = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverBase
            // 
            this.serverBase.AutoSize = true;
            this.serverBase.BackColor = System.Drawing.Color.Transparent;
            this.serverBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serverBase.Location = new System.Drawing.Point(19, 114);
            this.serverBase.Name = "serverBase";
            this.serverBase.Size = new System.Drawing.Size(188, 30);
            this.serverBase.TabIndex = 0;
            this.serverBase.Text = "AssettoServer base";
            // 
            // pathServerBase
            // 
            this.pathServerBase.Location = new System.Drawing.Point(216, 108);
            this.pathServerBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathServerBase.Name = "pathServerBase";
            this.pathServerBase.Size = new System.Drawing.Size(662, 35);
            this.pathServerBase.TabIndex = 1;
            // 
            // browseBase
            // 
            this.browseBase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseBase.Location = new System.Drawing.Point(886, 108);
            this.browseBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseBase.Name = "browseBase";
            this.browseBase.Size = new System.Drawing.Size(117, 48);
            this.browseBase.TabIndex = 2;
            this.browseBase.Text = "Browse";
            this.browseBase.UseVisualStyleBackColor = false;
            this.browseBase.Click += new System.EventHandler(this.OnBrowseServerBase);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Packed server";
            // 
            // pathPackedServer
            // 
            this.pathPackedServer.Location = new System.Drawing.Point(216, 162);
            this.pathPackedServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathPackedServer.Name = "pathPackedServer";
            this.pathPackedServer.Size = new System.Drawing.Size(662, 35);
            this.pathPackedServer.TabIndex = 4;
            // 
            // browsePackedServer
            // 
            this.browsePackedServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browsePackedServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browsePackedServer.Location = new System.Drawing.Point(886, 162);
            this.browsePackedServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browsePackedServer.Name = "browsePackedServer";
            this.browsePackedServer.Size = new System.Drawing.Size(117, 48);
            this.browsePackedServer.TabIndex = 5;
            this.browsePackedServer.Text = "Browse";
            this.browsePackedServer.UseVisualStyleBackColor = false;
            this.browsePackedServer.Click += new System.EventHandler(this.OnBrowsePackedServer);
            // 
            // aiFolder
            // 
            this.aiFolder.AutoSize = true;
            this.aiFolder.BackColor = System.Drawing.Color.Transparent;
            this.aiFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aiFolder.Location = new System.Drawing.Point(19, 222);
            this.aiFolder.Name = "aiFolder";
            this.aiFolder.Size = new System.Drawing.Size(93, 30);
            this.aiFolder.TabIndex = 6;
            this.aiFolder.Text = "AI folder";
            // 
            // pathAiFolder
            // 
            this.pathAiFolder.Location = new System.Drawing.Point(216, 216);
            this.pathAiFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathAiFolder.Name = "pathAiFolder";
            this.pathAiFolder.Size = new System.Drawing.Size(662, 35);
            this.pathAiFolder.TabIndex = 7;
            // 
            // browseAiFolder
            // 
            this.browseAiFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseAiFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseAiFolder.Location = new System.Drawing.Point(886, 216);
            this.browseAiFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseAiFolder.Name = "browseAiFolder";
            this.browseAiFolder.Size = new System.Drawing.Size(117, 48);
            this.browseAiFolder.TabIndex = 8;
            this.browseAiFolder.Text = "Browse";
            this.browseAiFolder.UseVisualStyleBackColor = false;
            this.browseAiFolder.Click += new System.EventHandler(this.OnBrowseAiFolder);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Extra config";
            // 
            // pathExtraConfig
            // 
            this.pathExtraConfig.Location = new System.Drawing.Point(216, 270);
            this.pathExtraConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathExtraConfig.Name = "pathExtraConfig";
            this.pathExtraConfig.Size = new System.Drawing.Size(662, 35);
            this.pathExtraConfig.TabIndex = 10;
            // 
            // browseExtraConfig
            // 
            this.browseExtraConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseExtraConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseExtraConfig.Location = new System.Drawing.Point(886, 270);
            this.browseExtraConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseExtraConfig.Name = "browseExtraConfig";
            this.browseExtraConfig.Size = new System.Drawing.Size(117, 48);
            this.browseExtraConfig.TabIndex = 11;
            this.browseExtraConfig.Text = "Browse";
            this.browseExtraConfig.UseVisualStyleBackColor = false;
            this.browseExtraConfig.Click += new System.EventHandler(this.OnBrowseExtraConfig);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Output folder";
            // 
            // pathOutputFolder
            // 
            this.pathOutputFolder.Location = new System.Drawing.Point(216, 486);
            this.pathOutputFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathOutputFolder.Name = "pathOutputFolder";
            this.pathOutputFolder.Size = new System.Drawing.Size(662, 35);
            this.pathOutputFolder.TabIndex = 16;
            // 
            // browseOutputFolder
            // 
            this.browseOutputFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseOutputFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseOutputFolder.Location = new System.Drawing.Point(886, 486);
            this.browseOutputFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseOutputFolder.Name = "browseOutputFolder";
            this.browseOutputFolder.Size = new System.Drawing.Size(117, 48);
            this.browseOutputFolder.TabIndex = 17;
            this.browseOutputFolder.Text = "Browse";
            this.browseOutputFolder.UseVisualStyleBackColor = false;
            this.browseOutputFolder.Click += new System.EventHandler(this.OnBrowseOutputFolder);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetsToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1022, 38);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.presetsToolStripMenuItem.Checked = true;
            this.presetsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPresetToolStripMenuItem,
            this.savePresetToolStripMenuItem});
            this.presetsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(97, 34);
            this.presetsToolStripMenuItem.Text = "Presets";
            // 
            // loadPresetToolStripMenuItem
            // 
            this.loadPresetToolStripMenuItem.Name = "loadPresetToolStripMenuItem";
            this.loadPresetToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.loadPresetToolStripMenuItem.Text = "Load preset";
            this.loadPresetToolStripMenuItem.Click += new System.EventHandler(this.OnPresetLoad);
            // 
            // savePresetToolStripMenuItem
            // 
            this.savePresetToolStripMenuItem.Name = "savePresetToolStripMenuItem";
            this.savePresetToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.savePresetToolStripMenuItem.Text = "Save preset";
            this.savePresetToolStripMenuItem.Click += new System.EventHandler(this.OnPresetSave);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPresetToolStripMenuItem,
            this.multiplePresetsToolStripMenuItem});
            this.buildToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // currentPresetToolStripMenuItem
            // 
            this.currentPresetToolStripMenuItem.Name = "currentPresetToolStripMenuItem";
            this.currentPresetToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.currentPresetToolStripMenuItem.Text = "Current preset";
            this.currentPresetToolStripMenuItem.Click += new System.EventHandler(this.OnBuildCurrentPreset);
            // 
            // multiplePresetsToolStripMenuItem
            // 
            this.multiplePresetsToolStripMenuItem.Name = "multiplePresetsToolStripMenuItem";
            this.multiplePresetsToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.multiplePresetsToolStripMenuItem.Text = "Multiple presets";
            this.multiplePresetsToolStripMenuItem.Click += new System.EventHandler(this.OnBuildMultiplePresets);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Server name";
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(216, 54);
            this.serverName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(784, 35);
            this.serverName.TabIndex = 21;
            // 
            // pathServerConfig
            // 
            this.pathServerConfig.Location = new System.Drawing.Point(216, 324);
            this.pathServerConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathServerConfig.Name = "pathServerConfig";
            this.pathServerConfig.Size = new System.Drawing.Size(662, 35);
            this.pathServerConfig.TabIndex = 22;
            // 
            // pathCspExtraConfig
            // 
            this.pathCspExtraConfig.Location = new System.Drawing.Point(216, 378);
            this.pathCspExtraConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathCspExtraConfig.Name = "pathCspExtraConfig";
            this.pathCspExtraConfig.Size = new System.Drawing.Size(662, 35);
            this.pathCspExtraConfig.TabIndex = 23;
            // 
            // pathWelcomeMessage
            // 
            this.pathWelcomeMessage.Location = new System.Drawing.Point(216, 432);
            this.pathWelcomeMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pathWelcomeMessage.Name = "pathWelcomeMessage";
            this.pathWelcomeMessage.Size = new System.Drawing.Size(662, 35);
            this.pathWelcomeMessage.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 30);
            this.label7.TabIndex = 25;
            this.label7.Text = "Server config";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(19, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 30);
            this.label8.TabIndex = 26;
            this.label8.Text = "CSP extra config";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(19, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 30);
            this.label9.TabIndex = 27;
            this.label9.Text = "Welcome message";
            // 
            // boolModifyEntryList
            // 
            this.boolModifyEntryList.AutoSize = true;
            this.boolModifyEntryList.BackColor = System.Drawing.Color.Transparent;
            this.boolModifyEntryList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boolModifyEntryList.Location = new System.Drawing.Point(19, 540);
            this.boolModifyEntryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boolModifyEntryList.Name = "boolModifyEntryList";
            this.boolModifyEntryList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boolModifyEntryList.Size = new System.Drawing.Size(192, 34);
            this.boolModifyEntryList.TabIndex = 28;
            this.boolModifyEntryList.Text = "Modify entry_list";
            this.boolModifyEntryList.UseVisualStyleBackColor = false;
            // 
            // browseServerConfig
            // 
            this.browseServerConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseServerConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseServerConfig.Location = new System.Drawing.Point(886, 324);
            this.browseServerConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseServerConfig.Name = "browseServerConfig";
            this.browseServerConfig.Size = new System.Drawing.Size(117, 48);
            this.browseServerConfig.TabIndex = 29;
            this.browseServerConfig.Text = "Browse";
            this.browseServerConfig.UseVisualStyleBackColor = false;
            this.browseServerConfig.Click += new System.EventHandler(this.OnBrowseServerConfig);
            // 
            // browseCspExtraConfig
            // 
            this.browseCspExtraConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseCspExtraConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseCspExtraConfig.Location = new System.Drawing.Point(886, 378);
            this.browseCspExtraConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseCspExtraConfig.Name = "browseCspExtraConfig";
            this.browseCspExtraConfig.Size = new System.Drawing.Size(117, 48);
            this.browseCspExtraConfig.TabIndex = 30;
            this.browseCspExtraConfig.Text = "Browse";
            this.browseCspExtraConfig.UseVisualStyleBackColor = false;
            this.browseCspExtraConfig.Click += new System.EventHandler(this.OnBrowseCspExtraConfig);
            // 
            // browseWelcomeMessage
            // 
            this.browseWelcomeMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseWelcomeMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseWelcomeMessage.Location = new System.Drawing.Point(886, 432);
            this.browseWelcomeMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseWelcomeMessage.Name = "browseWelcomeMessage";
            this.browseWelcomeMessage.Size = new System.Drawing.Size(117, 48);
            this.browseWelcomeMessage.TabIndex = 31;
            this.browseWelcomeMessage.Text = "Browse";
            this.browseWelcomeMessage.UseVisualStyleBackColor = false;
            this.browseWelcomeMessage.Click += new System.EventHandler(this.OnBrowseWelcomeMessage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 600);
            this.Controls.Add(this.browseWelcomeMessage);
            this.Controls.Add(this.browseCspExtraConfig);
            this.Controls.Add(this.browseServerConfig);
            this.Controls.Add(this.boolModifyEntryList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pathWelcomeMessage);
            this.Controls.Add(this.pathCspExtraConfig);
            this.Controls.Add(this.pathServerConfig);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.browseOutputFolder);
            this.Controls.Add(this.pathOutputFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.browseExtraConfig);
            this.Controls.Add(this.pathExtraConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseAiFolder);
            this.Controls.Add(this.pathAiFolder);
            this.Controls.Add(this.aiFolder);
            this.Controls.Add(this.browsePackedServer);
            this.Controls.Add(this.pathPackedServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseBase);
            this.Controls.Add(this.pathServerBase);
            this.Controls.Add(this.serverBase);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Assetto Server Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label serverBase;
        private TextBox pathServerBase;
        private Button browseBase;
        private Label label1;
        private TextBox pathPackedServer;
        private Button browsePackedServer;
        private Label aiFolder;
        private TextBox pathAiFolder;
        private Button browseAiFolder;
        private Label label2;
        private TextBox pathExtraConfig;
        private Button browseExtraConfig;
        private Label label5;
        private TextBox pathOutputFolder;
        private Button browseOutputFolder;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem presetsToolStripMenuItem;
        private ToolStripMenuItem loadPresetToolStripMenuItem;
        private ToolStripMenuItem savePresetToolStripMenuItem;
        private Label label6;
        private TextBox serverName;
        private TextBox pathServerConfig;
        private TextBox pathCspExtraConfig;
        private TextBox pathWelcomeMessage;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox boolModifyEntryList;
        private ToolStripMenuItem buildToolStripMenuItem;
        private ToolStripMenuItem currentPresetToolStripMenuItem;
        private ToolStripMenuItem multiplePresetsToolStripMenuItem;
        private Button browseServerConfig;
        private Button browseCspExtraConfig;
        private Button browseWelcomeMessage;
    }
}