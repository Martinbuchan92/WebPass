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
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProgramPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOpenSoftware = new System.Windows.Forms.RadioButton();
            this.rbOpenFile = new System.Windows.Forms.RadioButton();
            this.rbClipboard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbItemSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClipboard = new System.Windows.Forms.TextBox();
            this.CmbItemSelect2 = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.Black;
            this.txtFilePath.ForeColor = System.Drawing.Color.White;
            this.txtFilePath.Location = new System.Drawing.Point(87, 146);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(227, 20);
            this.txtFilePath.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Program Path";
            // 
            // txtProgramPath
            // 
            this.txtProgramPath.BackColor = System.Drawing.Color.Black;
            this.txtProgramPath.ForeColor = System.Drawing.Color.White;
            this.txtProgramPath.Location = new System.Drawing.Point(87, 172);
            this.txtProgramPath.Name = "txtProgramPath";
            this.txtProgramPath.Size = new System.Drawing.Size(227, 20);
            this.txtProgramPath.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.rbOpenSoftware);
            this.groupBox1.Controls.Add(this.rbOpenFile);
            this.groupBox1.Controls.Add(this.rbClipboard);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 46);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Type...";
            // 
            // rbOpenSoftware
            // 
            this.rbOpenSoftware.AutoSize = true;
            this.rbOpenSoftware.BackColor = System.Drawing.Color.Black;
            this.rbOpenSoftware.ForeColor = System.Drawing.Color.White;
            this.rbOpenSoftware.Location = new System.Drawing.Point(188, 19);
            this.rbOpenSoftware.Name = "rbOpenSoftware";
            this.rbOpenSoftware.Size = new System.Drawing.Size(93, 17);
            this.rbOpenSoftware.TabIndex = 2;
            this.rbOpenSoftware.TabStop = true;
            this.rbOpenSoftware.Text = "Open Program";
            this.rbOpenSoftware.UseVisualStyleBackColor = false;
            this.rbOpenSoftware.CheckedChanged += new System.EventHandler(this.rbOpenSoftware_CheckedChanged);
            // 
            // rbOpenFile
            // 
            this.rbOpenFile.AutoSize = true;
            this.rbOpenFile.BackColor = System.Drawing.Color.Black;
            this.rbOpenFile.ForeColor = System.Drawing.Color.White;
            this.rbOpenFile.Location = new System.Drawing.Point(97, 19);
            this.rbOpenFile.Name = "rbOpenFile";
            this.rbOpenFile.Size = new System.Drawing.Size(70, 17);
            this.rbOpenFile.TabIndex = 1;
            this.rbOpenFile.TabStop = true;
            this.rbOpenFile.Text = "Open File";
            this.rbOpenFile.UseVisualStyleBackColor = false;
            this.rbOpenFile.CheckedChanged += new System.EventHandler(this.rbOpenFile_CheckedChanged);
            // 
            // rbClipboard
            // 
            this.rbClipboard.AutoSize = true;
            this.rbClipboard.BackColor = System.Drawing.Color.Black;
            this.rbClipboard.ForeColor = System.Drawing.Color.White;
            this.rbClipboard.Location = new System.Drawing.Point(6, 19);
            this.rbClipboard.Name = "rbClipboard";
            this.rbClipboard.Size = new System.Drawing.Size(69, 17);
            this.rbClipboard.TabIndex = 0;
            this.rbClipboard.TabStop = true;
            this.rbClipboard.Text = "Clipboard";
            this.rbClipboard.UseVisualStyleBackColor = false;
            this.rbClipboard.CheckedChanged += new System.EventHandler(this.rbClipboard_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clipboard";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(87, 120);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // CmbItemSelect
            // 
            this.CmbItemSelect.BackColor = System.Drawing.Color.Black;
            this.CmbItemSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbItemSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbItemSelect.ForeColor = System.Drawing.Color.White;
            this.CmbItemSelect.FormattingEnabled = true;
            this.CmbItemSelect.Location = new System.Drawing.Point(87, 12);
            this.CmbItemSelect.Name = "CmbItemSelect";
            this.CmbItemSelect.Size = new System.Drawing.Size(227, 21);
            this.CmbItemSelect.TabIndex = 22;
            this.CmbItemSelect.SelectedIndexChanged += new System.EventHandler(this.CmbItemSelect_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Item";
            // 
            // txtClipboard
            // 
            this.txtClipboard.BackColor = System.Drawing.Color.Black;
            this.txtClipboard.ForeColor = System.Drawing.Color.White;
            this.txtClipboard.Location = new System.Drawing.Point(87, 201);
            this.txtClipboard.Multiline = true;
            this.txtClipboard.Name = "txtClipboard";
            this.txtClipboard.Size = new System.Drawing.Size(227, 109);
            this.txtClipboard.TabIndex = 24;
            // 
            // CmbItemSelect2
            // 
            this.CmbItemSelect2.BackColor = System.Drawing.Color.Black;
            this.CmbItemSelect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbItemSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbItemSelect2.ForeColor = System.Drawing.Color.White;
            this.CmbItemSelect2.FormattingEnabled = true;
            this.CmbItemSelect2.Location = new System.Drawing.Point(87, 39);
            this.CmbItemSelect2.Name = "CmbItemSelect2";
            this.CmbItemSelect2.Size = new System.Drawing.Size(227, 21);
            this.CmbItemSelect2.TabIndex = 25;
            this.CmbItemSelect2.SelectedIndexChanged += new System.EventHandler(this.CmbItemSelect2_SelectedIndexChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(158, 333);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 26;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(239, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(326, 368);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CmbItemSelect2);
            this.Controls.Add(this.txtClipboard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbItemSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProgramPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProgramPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOpenSoftware;
        private System.Windows.Forms.RadioButton rbOpenFile;
        private System.Windows.Forms.RadioButton rbClipboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbItemSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClipboard;
        private System.Windows.Forms.ComboBox CmbItemSelect2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnClose;
    }
}