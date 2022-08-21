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
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.tcpPort = new System.Windows.Forms.TextBox();
            this.udpPort = new System.Windows.Forms.TextBox();
            this.httpPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boolModifyEntryList = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverBase
            // 
            this.serverBase.AutoSize = true;
            this.serverBase.BackColor = System.Drawing.Color.Transparent;
            this.serverBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serverBase.Location = new System.Drawing.Point(11, 57);
            this.serverBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverBase.Name = "serverBase";
            this.serverBase.Size = new System.Drawing.Size(105, 15);
            this.serverBase.TabIndex = 0;
            this.serverBase.Text = "AssettoServer base";
            // 
            // pathServerBase
            // 
            this.pathServerBase.Location = new System.Drawing.Point(126, 54);
            this.pathServerBase.Margin = new System.Windows.Forms.Padding(2);
            this.pathServerBase.Name = "pathServerBase";
            this.pathServerBase.Size = new System.Drawing.Size(388, 23);
            this.pathServerBase.TabIndex = 1;
            // 
            // browseBase
            // 
            this.browseBase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseBase.Location = new System.Drawing.Point(517, 54);
            this.browseBase.Margin = new System.Windows.Forms.Padding(2);
            this.browseBase.Name = "browseBase";
            this.browseBase.Size = new System.Drawing.Size(68, 24);
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
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Packed server";
            // 
            // pathPackedServer
            // 
            this.pathPackedServer.Location = new System.Drawing.Point(126, 81);
            this.pathPackedServer.Margin = new System.Windows.Forms.Padding(2);
            this.pathPackedServer.Name = "pathPackedServer";
            this.pathPackedServer.Size = new System.Drawing.Size(388, 23);
            this.pathPackedServer.TabIndex = 4;
            // 
            // browsePackedServer
            // 
            this.browsePackedServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browsePackedServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browsePackedServer.Location = new System.Drawing.Point(517, 81);
            this.browsePackedServer.Margin = new System.Windows.Forms.Padding(2);
            this.browsePackedServer.Name = "browsePackedServer";
            this.browsePackedServer.Size = new System.Drawing.Size(68, 24);
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
            this.aiFolder.Location = new System.Drawing.Point(11, 111);
            this.aiFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aiFolder.Name = "aiFolder";
            this.aiFolder.Size = new System.Drawing.Size(52, 15);
            this.aiFolder.TabIndex = 6;
            this.aiFolder.Text = "AI folder";
            // 
            // pathAiFolder
            // 
            this.pathAiFolder.Location = new System.Drawing.Point(126, 108);
            this.pathAiFolder.Margin = new System.Windows.Forms.Padding(2);
            this.pathAiFolder.Name = "pathAiFolder";
            this.pathAiFolder.Size = new System.Drawing.Size(388, 23);
            this.pathAiFolder.TabIndex = 7;
            // 
            // browseAiFolder
            // 
            this.browseAiFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseAiFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseAiFolder.Location = new System.Drawing.Point(517, 108);
            this.browseAiFolder.Margin = new System.Windows.Forms.Padding(2);
            this.browseAiFolder.Name = "browseAiFolder";
            this.browseAiFolder.Size = new System.Drawing.Size(68, 24);
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
            this.label2.Location = new System.Drawing.Point(11, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Extra config";
            // 
            // pathExtraConfig
            // 
            this.pathExtraConfig.Location = new System.Drawing.Point(126, 135);
            this.pathExtraConfig.Margin = new System.Windows.Forms.Padding(2);
            this.pathExtraConfig.Name = "pathExtraConfig";
            this.pathExtraConfig.Size = new System.Drawing.Size(388, 23);
            this.pathExtraConfig.TabIndex = 10;
            // 
            // browseExtraConfig
            // 
            this.browseExtraConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseExtraConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseExtraConfig.Location = new System.Drawing.Point(517, 135);
            this.browseExtraConfig.Margin = new System.Windows.Forms.Padding(2);
            this.browseExtraConfig.Name = "browseExtraConfig";
            this.browseExtraConfig.Size = new System.Drawing.Size(68, 24);
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
            this.label5.Location = new System.Drawing.Point(11, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Output folder";
            // 
            // pathOutputFolder
            // 
            this.pathOutputFolder.Location = new System.Drawing.Point(126, 243);
            this.pathOutputFolder.Margin = new System.Windows.Forms.Padding(2);
            this.pathOutputFolder.Name = "pathOutputFolder";
            this.pathOutputFolder.Size = new System.Drawing.Size(388, 23);
            this.pathOutputFolder.TabIndex = 16;
            // 
            // browseOutputFolder
            // 
            this.browseOutputFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseOutputFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseOutputFolder.Location = new System.Drawing.Point(517, 243);
            this.browseOutputFolder.Margin = new System.Windows.Forms.Padding(2);
            this.browseOutputFolder.Name = "browseOutputFolder";
            this.browseOutputFolder.Size = new System.Drawing.Size(68, 24);
            this.browseOutputFolder.TabIndex = 17;
            this.browseOutputFolder.Text = "Browse";
            this.browseOutputFolder.UseVisualStyleBackColor = false;
            this.browseOutputFolder.Click += new System.EventHandler(this.OnBrowseOutputFolder);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(11, 270);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(574, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Build and pack";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OnPack);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
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
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.presetsToolStripMenuItem.Text = "Presets";
            // 
            // loadPresetToolStripMenuItem
            // 
            this.loadPresetToolStripMenuItem.Name = "loadPresetToolStripMenuItem";
            this.loadPresetToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadPresetToolStripMenuItem.Text = "Load preset";
            this.loadPresetToolStripMenuItem.Click += new System.EventHandler(this.OnPresetLoad);
            // 
            // savePresetToolStripMenuItem
            // 
            this.savePresetToolStripMenuItem.Name = "savePresetToolStripMenuItem";
            this.savePresetToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.savePresetToolStripMenuItem.Text = "Save preset";
            this.savePresetToolStripMenuItem.Click += new System.EventHandler(this.OnPresetSave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Server name";
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(126, 27);
            this.serverName.Margin = new System.Windows.Forms.Padding(2);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(459, 23);
            this.serverName.TabIndex = 21;
            // 
            // tcpPort
            // 
            this.tcpPort.Location = new System.Drawing.Point(126, 162);
            this.tcpPort.Margin = new System.Windows.Forms.Padding(2);
            this.tcpPort.Name = "tcpPort";
            this.tcpPort.Size = new System.Drawing.Size(70, 23);
            this.tcpPort.TabIndex = 22;
            // 
            // udpPort
            // 
            this.udpPort.Location = new System.Drawing.Point(126, 189);
            this.udpPort.Margin = new System.Windows.Forms.Padding(2);
            this.udpPort.Name = "udpPort";
            this.udpPort.Size = new System.Drawing.Size(70, 23);
            this.udpPort.TabIndex = 23;
            // 
            // httpPort
            // 
            this.httpPort.Location = new System.Drawing.Point(126, 216);
            this.httpPort.Margin = new System.Windows.Forms.Padding(2);
            this.httpPort.Name = "httpPort";
            this.httpPort.Size = new System.Drawing.Size(70, 23);
            this.httpPort.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(11, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "TCP port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "UDP port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(11, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "HTTP port";
            // 
            // boolModifyEntryList
            // 
            this.boolModifyEntryList.AutoSize = true;
            this.boolModifyEntryList.BackColor = System.Drawing.Color.Transparent;
            this.boolModifyEntryList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boolModifyEntryList.Location = new System.Drawing.Point(2, 2);
            this.boolModifyEntryList.Margin = new System.Windows.Forms.Padding(2);
            this.boolModifyEntryList.Name = "boolModifyEntryList";
            this.boolModifyEntryList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boolModifyEntryList.Size = new System.Drawing.Size(114, 19);
            this.boolModifyEntryList.TabIndex = 28;
            this.boolModifyEntryList.Text = "Modify entry_list";
            this.boolModifyEntryList.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.boolModifyEntryList);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(201, 163);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 76);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 303);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.httpPort);
            this.Controls.Add(this.udpPort);
            this.Controls.Add(this.tcpPort);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Assetto Server Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem presetsToolStripMenuItem;
        private ToolStripMenuItem loadPresetToolStripMenuItem;
        private ToolStripMenuItem savePresetToolStripMenuItem;
        private Label label6;
        private TextBox serverName;
        private TextBox tcpPort;
        private TextBox udpPort;
        private TextBox httpPort;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox boolModifyEntryList;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}