namespace uc
{
    partial class ucFileOpen
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtbFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(412, 4);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(54, 31);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "选择";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtbFilePath
            // 
            this.txtbFilePath.Location = new System.Drawing.Point(3, 8);
            this.txtbFilePath.Name = "txtbFilePath";
            this.txtbFilePath.ReadOnly = true;
            this.txtbFilePath.Size = new System.Drawing.Size(402, 26);
            this.txtbFilePath.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(474, 4);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(51, 31);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "打开";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // ucFileOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbFilePath);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnChooseFile);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucFileOpen";
            this.Size = new System.Drawing.Size(534, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtbFilePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog ofDialog;
    }
}
