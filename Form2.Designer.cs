namespace AssettoServerBuilder
{
    public partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entryList = new System.Windows.Forms.CheckedListBox();
            this.okEntryList = new System.Windows.Forms.Button();
            this.checkAllEntryList = new System.Windows.Forms.Button();
            this.uncheckAllEntryList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkTypeEntryList = new System.Windows.Forms.ComboBox();
            this.entriesAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.applyChecks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sortTypeEntryList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // entryList
            // 
            this.entryList.FormattingEnabled = true;
            this.entryList.Location = new System.Drawing.Point(7, 22);
            this.entryList.Margin = new System.Windows.Forms.Padding(2);
            this.entryList.Name = "entryList";
            this.entryList.Size = new System.Drawing.Size(238, 166);
            this.entryList.TabIndex = 0;
            // 
            // okEntryList
            // 
            this.okEntryList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.okEntryList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okEntryList.Location = new System.Drawing.Point(254, 164);
            this.okEntryList.Margin = new System.Windows.Forms.Padding(2);
            this.okEntryList.Name = "okEntryList";
            this.okEntryList.Size = new System.Drawing.Size(195, 24);
            this.okEntryList.TabIndex = 1;
            this.okEntryList.Text = "OK";
            this.okEntryList.UseVisualStyleBackColor = false;
            this.okEntryList.Click += new System.EventHandler(this.OnOkClick);
            // 
            // checkAllEntryList
            // 
            this.checkAllEntryList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAllEntryList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkAllEntryList.Location = new System.Drawing.Point(255, 117);
            this.checkAllEntryList.Margin = new System.Windows.Forms.Padding(2);
            this.checkAllEntryList.Name = "checkAllEntryList";
            this.checkAllEntryList.Size = new System.Drawing.Size(96, 24);
            this.checkAllEntryList.TabIndex = 2;
            this.checkAllEntryList.Text = "Check all";
            this.checkAllEntryList.UseVisualStyleBackColor = false;
            this.checkAllEntryList.Click += new System.EventHandler(this.OnCheckAllClick);
            // 
            // uncheckAllEntryList
            // 
            this.uncheckAllEntryList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uncheckAllEntryList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uncheckAllEntryList.Location = new System.Drawing.Point(354, 117);
            this.uncheckAllEntryList.Margin = new System.Windows.Forms.Padding(2);
            this.uncheckAllEntryList.Name = "uncheckAllEntryList";
            this.uncheckAllEntryList.Size = new System.Drawing.Size(95, 24);
            this.uncheckAllEntryList.TabIndex = 3;
            this.uncheckAllEntryList.Text = "Uncheck all";
            this.uncheckAllEntryList.UseVisualStyleBackColor = false;
            this.uncheckAllEntryList.Click += new System.EventHandler(this.OnUncheckAllClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(255, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Check for";
            // 
            // checkTypeEntryList
            // 
            this.checkTypeEntryList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkTypeEntryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkTypeEntryList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkTypeEntryList.FormattingEnabled = true;
            this.checkTypeEntryList.Items.AddRange(new object[] {
            "first",
            "last"});
            this.checkTypeEntryList.Location = new System.Drawing.Point(317, 62);
            this.checkTypeEntryList.Margin = new System.Windows.Forms.Padding(2);
            this.checkTypeEntryList.Name = "checkTypeEntryList";
            this.checkTypeEntryList.Size = new System.Drawing.Size(48, 23);
            this.checkTypeEntryList.TabIndex = 5;
            // 
            // entriesAmount
            // 
            this.entriesAmount.Location = new System.Drawing.Point(366, 62);
            this.entriesAmount.Margin = new System.Windows.Forms.Padding(2);
            this.entriesAmount.Name = "entriesAmount";
            this.entriesAmount.Size = new System.Drawing.Size(41, 23);
            this.entriesAmount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(411, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "cars";
            // 
            // applyChecks
            // 
            this.applyChecks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.applyChecks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applyChecks.Location = new System.Drawing.Point(254, 89);
            this.applyChecks.Margin = new System.Windows.Forms.Padding(2);
            this.applyChecks.Name = "applyChecks";
            this.applyChecks.Size = new System.Drawing.Size(195, 24);
            this.applyChecks.TabIndex = 8;
            this.applyChecks.Text = "Apply";
            this.applyChecks.UseVisualStyleBackColor = false;
            this.applyChecks.Click += new System.EventHandler(this.OnApplyCheckClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tick checkbox to set AI=fixed for a car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(254, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sort entry_list";
            // 
            // sortTypeEntryList
            // 
            this.sortTypeEntryList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sortTypeEntryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortTypeEntryList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortTypeEntryList.FormattingEnabled = true;
            this.sortTypeEntryList.Items.AddRange(new object[] {
            "entries with AI=none go first",
            "entries with AI=fixed go first"});
            this.sortTypeEntryList.Location = new System.Drawing.Point(254, 36);
            this.sortTypeEntryList.Margin = new System.Windows.Forms.Padding(2);
            this.sortTypeEntryList.Name = "sortTypeEntryList";
            this.sortTypeEntryList.Size = new System.Drawing.Size(196, 23);
            this.sortTypeEntryList.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 197);
            this.Controls.Add(this.sortTypeEntryList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.applyChecks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entriesAmount);
            this.Controls.Add(this.checkTypeEntryList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uncheckAllEntryList);
            this.Controls.Add(this.checkAllEntryList);
            this.Controls.Add(this.okEntryList);
            this.Controls.Add(this.entryList);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Entry list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnCloseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox entryList;
        private Button okEntryList;
        private Button checkAllEntryList;
        private Button uncheckAllEntryList;
        private Label label1;
        private ComboBox checkTypeEntryList;
        private TextBox entriesAmount;
        private Label label2;
        private Button applyChecks;
        private Label label3;
        private Label label4;
        private ComboBox sortTypeEntryList;
    }
}