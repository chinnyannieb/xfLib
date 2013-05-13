namespace uc
{
    partial class ucDirectoryOpen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbDirPath = new System.Windows.Forms.TextBox();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtbDirPath
            // 
            this.txtbDirPath.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbDirPath.Location = new System.Drawing.Point(94, 6);
            this.txtbDirPath.Name = "txtbDirPath";
            this.txtbDirPath.ReadOnly = true;
            this.txtbDirPath.Size = new System.Drawing.Size(323, 26);
            this.txtbDirPath.TabIndex = 4;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOpenDir.Location = new System.Drawing.Point(424, 4);
            this.btnOpenDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(100, 31);
            this.btnOpenDir.TabIndex = 3;
            this.btnOpenDir.Text = "查看目录";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.Font = new System.Drawing.Font("宋体", 12F);
            this.btnChooseDir.Location = new System.Drawing.Point(4, 4);
            this.btnChooseDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(83, 31);
            this.btnChooseDir.TabIndex = 2;
            this.btnChooseDir.Text = "选择目录";
            this.btnChooseDir.UseVisualStyleBackColor = true;
            this.btnChooseDir.Click += new System.EventHandler(this.btnChooseDir_Click);
            // 
            // ucDirectoryOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbDirPath);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.btnChooseDir);
            this.Name = "ucDirectoryOpen";
            this.Size = new System.Drawing.Size(529, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbDirPath;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
    }
}
