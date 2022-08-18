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
            this.label3 = new System.Windows.Forms.Label();
            this.aiCarsAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pathOutputFolder = new System.Windows.Forms.TextBox();
            this.browseOutputFolder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverBase
            // 
            this.serverBase.AutoSize = true;
            this.serverBase.BackColor = System.Drawing.Color.Transparent;
            this.serverBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serverBase.Location = new System.Drawing.Point(12, 8);
            this.serverBase.Name = "serverBase";
            this.serverBase.Size = new System.Drawing.Size(130, 30);
            this.serverBase.TabIndex = 0;
            this.serverBase.Text = "Server base: ";
            // 
            // pathServerBase
            // 
            this.pathServerBase.Location = new System.Drawing.Point(209, 8);
            this.pathServerBase.Name = "pathServerBase";
            this.pathServerBase.Size = new System.Drawing.Size(531, 35);
            this.pathServerBase.TabIndex = 1;
            // 
            // browseBase
            // 
            this.browseBase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseBase.Location = new System.Drawing.Point(746, 9);
            this.browseBase.Name = "browseBase";
            this.browseBase.Size = new System.Drawing.Size(116, 35);
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
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Packed server: ";
            // 
            // pathPackedServer
            // 
            this.pathPackedServer.Location = new System.Drawing.Point(209, 48);
            this.pathPackedServer.Name = "pathPackedServer";
            this.pathPackedServer.Size = new System.Drawing.Size(531, 35);
            this.pathPackedServer.TabIndex = 4;
            // 
            // browsePackedServer
            // 
            this.browsePackedServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browsePackedServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browsePackedServer.Location = new System.Drawing.Point(746, 49);
            this.browsePackedServer.Name = "browsePackedServer";
            this.browsePackedServer.Size = new System.Drawing.Size(116, 35);
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
            this.aiFolder.Location = new System.Drawing.Point(12, 89);
            this.aiFolder.Name = "aiFolder";
            this.aiFolder.Size = new System.Drawing.Size(98, 30);
            this.aiFolder.TabIndex = 6;
            this.aiFolder.Text = "AI folder:";
            // 
            // pathAiFolder
            // 
            this.pathAiFolder.Location = new System.Drawing.Point(209, 89);
            this.pathAiFolder.Name = "pathAiFolder";
            this.pathAiFolder.Size = new System.Drawing.Size(531, 35);
            this.pathAiFolder.TabIndex = 7;
            // 
            // browseAiFolder
            // 
            this.browseAiFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseAiFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseAiFolder.Location = new System.Drawing.Point(746, 90);
            this.browseAiFolder.Name = "browseAiFolder";
            this.browseAiFolder.Size = new System.Drawing.Size(116, 35);
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
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Extra config:";
            // 
            // pathExtraConfig
            // 
            this.pathExtraConfig.Location = new System.Drawing.Point(209, 130);
            this.pathExtraConfig.Name = "pathExtraConfig";
            this.pathExtraConfig.Size = new System.Drawing.Size(531, 35);
            this.pathExtraConfig.TabIndex = 10;
            // 
            // browseExtraConfig
            // 
            this.browseExtraConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseExtraConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseExtraConfig.Location = new System.Drawing.Point(746, 131);
            this.browseExtraConfig.Name = "browseExtraConfig";
            this.browseExtraConfig.Size = new System.Drawing.Size(116, 35);
            this.browseExtraConfig.TabIndex = 11;
            this.browseExtraConfig.Text = "Browse";
            this.browseExtraConfig.UseVisualStyleBackColor = false;
            this.browseExtraConfig.Click += new System.EventHandler(this.OnBrowseExtraConfig);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "AI=fixed for first ";
            // 
            // aiCarsAmount
            // 
            this.aiCarsAmount.Location = new System.Drawing.Point(209, 171);
            this.aiCarsAmount.Name = "aiCarsAmount";
            this.aiCarsAmount.Size = new System.Drawing.Size(61, 35);
            this.aiCarsAmount.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(286, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "cars";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Output folder:";
            // 
            // pathOutputFolder
            // 
            this.pathOutputFolder.Location = new System.Drawing.Point(209, 212);
            this.pathOutputFolder.Name = "pathOutputFolder";
            this.pathOutputFolder.Size = new System.Drawing.Size(531, 35);
            this.pathOutputFolder.TabIndex = 16;
            // 
            // browseOutputFolder
            // 
            this.browseOutputFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.browseOutputFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.browseOutputFolder.Location = new System.Drawing.Point(746, 212);
            this.browseOutputFolder.Name = "browseOutputFolder";
            this.browseOutputFolder.Size = new System.Drawing.Size(116, 35);
            this.browseOutputFolder.TabIndex = 17;
            this.browseOutputFolder.Text = "Browse";
            this.browseOutputFolder.UseVisualStyleBackColor = false;
            this.browseOutputFolder.Click += new System.EventHandler(this.OnBrowseOutputFolder);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(12, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(850, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Build and pack";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OnPack);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.browseOutputFolder);
            this.Controls.Add(this.pathOutputFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aiCarsAmount);
            this.Controls.Add(this.label3);
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
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Assetto Server Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Shown += new System.EventHandler(this.OnFormShown);
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
        private Label label3;
        private TextBox aiCarsAmount;
        private Label label4;
        private Label label5;
        private TextBox pathOutputFolder;
        private Button browseOutputFolder;
        private Button button2;
    }
}