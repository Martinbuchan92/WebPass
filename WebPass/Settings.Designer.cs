namespace WebPass
{
    partial class Settings
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProgramPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOpenSoftware = new System.Windows.Forms.RadioButton();
            this.rbOpenFile = new System.Windows.Forms.RadioButton();
            this.rbClipboard = new System.Windows.Forms.RadioButton();
            this.txtClipboard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbItemSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 20);
            this.button2.TabIndex = 21;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "File";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(76, 143);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(163, 20);
            this.txtFilePath.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 20);
            this.button1.TabIndex = 18;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Program";
            // 
            // txtProgramPath
            // 
            this.txtProgramPath.Location = new System.Drawing.Point(76, 169);
            this.txtProgramPath.Name = "txtProgramPath";
            this.txtProgramPath.Size = new System.Drawing.Size(163, 20);
            this.txtProgramPath.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOpenSoftware);
            this.groupBox1.Controls.Add(this.rbOpenFile);
            this.groupBox1.Controls.Add(this.rbClipboard);
            this.groupBox1.Location = new System.Drawing.Point(9, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 46);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Type...";
            // 
            // rbOpenSoftware
            // 
            this.rbOpenSoftware.AutoSize = true;
            this.rbOpenSoftware.Location = new System.Drawing.Point(188, 19);
            this.rbOpenSoftware.Name = "rbOpenSoftware";
            this.rbOpenSoftware.Size = new System.Drawing.Size(93, 17);
            this.rbOpenSoftware.TabIndex = 2;
            this.rbOpenSoftware.TabStop = true;
            this.rbOpenSoftware.Text = "Open Program";
            this.rbOpenSoftware.UseVisualStyleBackColor = true;
            this.rbOpenSoftware.CheckedChanged += new System.EventHandler(this.rbOpenSoftware_CheckedChanged);
            // 
            // rbOpenFile
            // 
            this.rbOpenFile.AutoSize = true;
            this.rbOpenFile.Location = new System.Drawing.Point(97, 19);
            this.rbOpenFile.Name = "rbOpenFile";
            this.rbOpenFile.Size = new System.Drawing.Size(70, 17);
            this.rbOpenFile.TabIndex = 1;
            this.rbOpenFile.TabStop = true;
            this.rbOpenFile.Text = "Open File";
            this.rbOpenFile.UseVisualStyleBackColor = true;
            this.rbOpenFile.CheckedChanged += new System.EventHandler(this.rbOpenFile_CheckedChanged);
            // 
            // rbClipboard
            // 
            this.rbClipboard.AutoSize = true;
            this.rbClipboard.Location = new System.Drawing.Point(6, 19);
            this.rbClipboard.Name = "rbClipboard";
            this.rbClipboard.Size = new System.Drawing.Size(69, 17);
            this.rbClipboard.TabIndex = 0;
            this.rbClipboard.TabStop = true;
            this.rbClipboard.Text = "Clipboard";
            this.rbClipboard.UseVisualStyleBackColor = true;
            this.rbClipboard.CheckedChanged += new System.EventHandler(this.rbClipboard_CheckedChanged);
            // 
            // txtClipboard
            // 
            this.txtClipboard.Location = new System.Drawing.Point(76, 117);
            this.txtClipboard.Name = "txtClipboard";
            this.txtClipboard.Size = new System.Drawing.Size(100, 20);
            this.txtClipboard.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clipboard";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // CmbItemSelect
            // 
            this.CmbItemSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbItemSelect.FormattingEnabled = true;
            this.CmbItemSelect.Items.AddRange(new object[] {
            "Button 1",
            "Button 2",
            "Button 3",
            "Button 4",
            "Button 5",
            "Button 6",
            "Button 7",
            "Button 8",
            "Button 9",
            "Button 10",
            "Dropdown 1",
            "Dropdown 2"});
            this.CmbItemSelect.Location = new System.Drawing.Point(76, 12);
            this.CmbItemSelect.Name = "CmbItemSelect";
            this.CmbItemSelect.Size = new System.Drawing.Size(204, 21);
            this.CmbItemSelect.TabIndex = 22;
            this.CmbItemSelect.SelectedIndexChanged += new System.EventHandler(this.CmbItemSelect_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Item";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 219);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbItemSelect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProgramPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtClipboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProgramPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOpenSoftware;
        private System.Windows.Forms.RadioButton rbOpenFile;
        private System.Windows.Forms.RadioButton rbClipboard;
        private System.Windows.Forms.TextBox txtClipboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbItemSelect;
        private System.Windows.Forms.Label label5;
    }
}