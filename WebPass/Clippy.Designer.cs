namespace WebPass
{
    partial class Clippy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clippy));
            this.btnCDKey = new System.Windows.Forms.Button();
            this.btnSQL = new System.Windows.Forms.Button();
            this.btnRBS = new System.Windows.Forms.Button();
            this.btnCCleaner = new System.Windows.Forms.Button();
            this.btnRegAdd = new System.Windows.Forms.Button();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.btnOther = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCDKey
            // 
            this.btnCDKey.Location = new System.Drawing.Point(13, 13);
            this.btnCDKey.Name = "btnCDKey";
            this.btnCDKey.Size = new System.Drawing.Size(75, 21);
            this.btnCDKey.TabIndex = 0;
            this.btnCDKey.Text = "CD Key";
            this.btnCDKey.UseVisualStyleBackColor = true;
            this.btnCDKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(94, 13);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(75, 21);
            this.btnSQL.TabIndex = 1;
            this.btnSQL.Text = "SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // btnRBS
            // 
            this.btnRBS.Location = new System.Drawing.Point(175, 13);
            this.btnRBS.Name = "btnRBS";
            this.btnRBS.Size = new System.Drawing.Size(75, 21);
            this.btnRBS.TabIndex = 2;
            this.btnRBS.Text = "RBS";
            this.btnRBS.UseVisualStyleBackColor = true;
            this.btnRBS.Click += new System.EventHandler(this.btnRBS_Click);
            // 
            // btnCCleaner
            // 
            this.btnCCleaner.Location = new System.Drawing.Point(256, 13);
            this.btnCCleaner.Name = "btnCCleaner";
            this.btnCCleaner.Size = new System.Drawing.Size(75, 21);
            this.btnCCleaner.TabIndex = 3;
            this.btnCCleaner.Text = "CCleaner";
            this.btnCCleaner.UseVisualStyleBackColor = true;
            this.btnCCleaner.Click += new System.EventHandler(this.btnCCleaner_Click);
            // 
            // btnRegAdd
            // 
            this.btnRegAdd.Location = new System.Drawing.Point(337, 13);
            this.btnRegAdd.Name = "btnRegAdd";
            this.btnRegAdd.Size = new System.Drawing.Size(75, 21);
            this.btnRegAdd.TabIndex = 4;
            this.btnRegAdd.Text = "RegAdd";
            this.btnRegAdd.UseVisualStyleBackColor = true;
            this.btnRegAdd.Click += new System.EventHandler(this.btnRegAdd_Click);
            // 
            // cmbVersion
            // 
            this.cmbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Items.AddRange(new object[] {
            "Community",
            "Pro",
            "Pro Plus"});
            this.cmbVersion.Location = new System.Drawing.Point(418, 13);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(144, 21);
            this.cmbVersion.TabIndex = 5;
            this.cmbVersion.SelectedIndexChanged += new System.EventHandler(this.cmbVersion_SelectedIndexChanged);
            // 
            // btnOther
            // 
            this.btnOther.Location = new System.Drawing.Point(568, 13);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(75, 21);
            this.btnOther.TabIndex = 6;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // Clippy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(664, 49);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.cmbVersion);
            this.Controls.Add(this.btnRegAdd);
            this.Controls.Add(this.btnCCleaner);
            this.Controls.Add(this.btnRBS);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.btnCDKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clippy";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clippy";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Clippy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCDKey;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Button btnRBS;
        private System.Windows.Forms.Button btnCCleaner;
        private System.Windows.Forms.Button btnRegAdd;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.Button btnOther;
    }
}

