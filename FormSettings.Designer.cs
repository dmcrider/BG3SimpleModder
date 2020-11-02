namespace BS3SimpleModder
{
    partial class FormSettings
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
            this.lblTools = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtTools = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnBrowseTools = new System.Windows.Forms.Button();
            this.btnBrowseData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBackup = new System.Windows.Forms.Label();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.Location = new System.Drawing.Point(10, 22);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(232, 20);
            this.lblTools.TabIndex = 0;
            this.lblTools.Text = "Larian Export Tools Install Path:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(43, 73);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(199, 20);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Baldur\'s Gate 3 Data Path:";
            // 
            // txtTools
            // 
            this.txtTools.Location = new System.Drawing.Point(248, 19);
            this.txtTools.Name = "txtTools";
            this.txtTools.Size = new System.Drawing.Size(385, 26);
            this.txtTools.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(248, 70);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(385, 26);
            this.txtData.TabIndex = 3;
            // 
            // btnBrowseTools
            // 
            this.btnBrowseTools.Location = new System.Drawing.Point(639, 15);
            this.btnBrowseTools.Name = "btnBrowseTools";
            this.btnBrowseTools.Size = new System.Drawing.Size(92, 34);
            this.btnBrowseTools.TabIndex = 4;
            this.btnBrowseTools.Tag = "tools";
            this.btnBrowseTools.Text = "Browse";
            this.btnBrowseTools.UseVisualStyleBackColor = true;
            this.btnBrowseTools.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnBrowseData
            // 
            this.btnBrowseData.Location = new System.Drawing.Point(639, 66);
            this.btnBrowseData.Name = "btnBrowseData";
            this.btnBrowseData.Size = new System.Drawing.Size(92, 34);
            this.btnBrowseData.TabIndex = 5;
            this.btnBrowseData.Tag = "data";
            this.btnBrowseData.Text = "Browse";
            this.btnBrowseData.UseVisualStyleBackColor = true;
            this.btnBrowseData.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(759, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(10, 308);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(132, 20);
            this.lblBackup.TabIndex = 7;
            this.lblBackup.Text = "Backup Location:";
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(148, 305);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.ReadOnly = true;
            this.txtBackup.Size = new System.Drawing.Size(583, 26);
            this.txtBackup.TabIndex = 8;
            this.txtBackup.TextChanged += new System.EventHandler(this.TxtBackup_TextChanged);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(737, 299);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(114, 32);
            this.btnBackup.TabIndex = 9;
            this.btnBackup.Text = "Open";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 340);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseData);
            this.Controls.Add(this.btnBrowseTools);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtTools);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTools);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtTools;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnBrowseTools;
        private System.Windows.Forms.Button btnBrowseData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Button btnBackup;
    }
}