namespace BG3SimpleModder
{
    partial class FormMain
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
            this.txtLarianToolsPath = new System.Windows.Forms.TextBox();
            this.lblLarianToolsPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowseLarianTools = new System.Windows.Forms.Button();
            this.btnDataPath = new System.Windows.Forms.Button();
            this.txtDataPath = new System.Windows.Forms.TextBox();
            this.lblDataPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLarianToolsPath
            // 
            this.txtLarianToolsPath.Location = new System.Drawing.Point(205, 34);
            this.txtLarianToolsPath.Name = "txtLarianToolsPath";
            this.txtLarianToolsPath.Size = new System.Drawing.Size(492, 29);
            this.txtLarianToolsPath.TabIndex = 0;
            // 
            // lblLarianToolsPath
            // 
            this.lblLarianToolsPath.AutoSize = true;
            this.lblLarianToolsPath.Location = new System.Drawing.Point(25, 37);
            this.lblLarianToolsPath.Name = "lblLarianToolsPath";
            this.lblLarianToolsPath.Size = new System.Drawing.Size(174, 21);
            this.lblLarianToolsPath.TabIndex = 1;
            this.lblLarianToolsPath.Text = "Larian Tools Install Path:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // btnBrowseLarianTools
            // 
            this.btnBrowseLarianTools.Location = new System.Drawing.Point(700, 31);
            this.btnBrowseLarianTools.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowseLarianTools.Name = "btnBrowseLarianTools";
            this.btnBrowseLarianTools.Size = new System.Drawing.Size(91, 33);
            this.btnBrowseLarianTools.TabIndex = 2;
            this.btnBrowseLarianTools.Text = "Browse";
            this.btnBrowseLarianTools.UseVisualStyleBackColor = true;
            this.btnBrowseLarianTools.Click += new System.EventHandler(this.BtnBrowserLarianTools_Click);
            // 
            // btnDataPath
            // 
            this.btnDataPath.Location = new System.Drawing.Point(700, 81);
            this.btnDataPath.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataPath.Name = "btnDataPath";
            this.btnDataPath.Size = new System.Drawing.Size(91, 33);
            this.btnDataPath.TabIndex = 2;
            this.btnDataPath.Text = "Browse";
            this.btnDataPath.UseVisualStyleBackColor = true;
            this.btnDataPath.Click += new System.EventHandler(this.BtnDataPath_Click);
            // 
            // txtDataPath
            // 
            this.txtDataPath.Location = new System.Drawing.Point(205, 84);
            this.txtDataPath.Name = "txtDataPath";
            this.txtDataPath.Size = new System.Drawing.Size(492, 29);
            this.txtDataPath.TabIndex = 0;
            // 
            // lblDataPath
            // 
            this.lblDataPath.AutoSize = true;
            this.lblDataPath.Location = new System.Drawing.Point(11, 87);
            this.lblDataPath.Name = "lblDataPath";
            this.lblDataPath.Size = new System.Drawing.Size(188, 21);
            this.lblDataPath.TabIndex = 1;
            this.lblDataPath.Text = "Baldur\'s Gate 3 Data Path:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 728);
            this.Controls.Add(this.lblDataPath);
            this.Controls.Add(this.txtDataPath);
            this.Controls.Add(this.btnDataPath);
            this.Controls.Add(this.btnBrowseLarianTools);
            this.Controls.Add(this.lblLarianToolsPath);
            this.Controls.Add(this.txtLarianToolsPath);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Baldur\'s Gate 3 - Simple Modder";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLarianToolsPath;
        private System.Windows.Forms.Label lblLarianToolsPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnBrowseLarianTools;
        private System.Windows.Forms.Button btnDataPath;
        private System.Windows.Forms.TextBox txtDataPath;
        private System.Windows.Forms.Label lblDataPath;
    }
}

