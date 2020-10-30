namespace BG3SimpleModder
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
            this.lblLarianToolsPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTools = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnBrowseTools = new System.Windows.Forms.Button();
            this.btnBrowseData = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblLarianToolsPath
            // 
            this.lblLarianToolsPath.AutoSize = true;
            this.lblLarianToolsPath.Location = new System.Drawing.Point(71, 24);
            this.lblLarianToolsPath.Name = "lblLarianToolsPath";
            this.lblLarianToolsPath.Size = new System.Drawing.Size(129, 21);
            this.lblLarianToolsPath.TabIndex = 0;
            this.lblLarianToolsPath.Text = "Larian Tools Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baldur\'s Gate 3 Data Path:";
            // 
            // txtTools
            // 
            this.txtTools.Location = new System.Drawing.Point(206, 21);
            this.txtTools.Name = "txtTools";
            this.txtTools.Size = new System.Drawing.Size(430, 29);
            this.txtTools.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(206, 92);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(430, 29);
            this.txtData.TabIndex = 1;
            // 
            // btnBrowseTools
            // 
            this.btnBrowseTools.Location = new System.Drawing.Point(642, 19);
            this.btnBrowseTools.Name = "btnBrowseTools";
            this.btnBrowseTools.Size = new System.Drawing.Size(95, 31);
            this.btnBrowseTools.TabIndex = 2;
            this.btnBrowseTools.Tag = "tools";
            this.btnBrowseTools.Text = "Browse";
            this.btnBrowseTools.UseVisualStyleBackColor = true;
            this.btnBrowseTools.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnBrowseData
            // 
            this.btnBrowseData.Location = new System.Drawing.Point(642, 90);
            this.btnBrowseData.Name = "btnBrowseData";
            this.btnBrowseData.Size = new System.Drawing.Size(95, 31);
            this.btnBrowseData.TabIndex = 2;
            this.btnBrowseData.Tag = "data";
            this.btnBrowseData.Text = "Browse";
            this.btnBrowseData.UseVisualStyleBackColor = true;
            this.btnBrowseData.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 334);
            this.Controls.Add(this.btnBrowseData);
            this.Controls.Add(this.btnBrowseTools);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtTools);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLarianToolsPath);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLarianToolsPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTools;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnBrowseTools;
        private System.Windows.Forms.Button btnBrowseData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}