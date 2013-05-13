namespace uc
{
    partial class ucFileSave
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtbFilename = new System.Windows.Forms.TextBox();
            this.txtbPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.fbdlgChoose = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(413, 9);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(72, 16);
            this.lblFilename.TabIndex = 5;
            this.lblFilename.Text = "文件名称";
            // 
            // txtbFilename
            // 
            this.txtbFilename.Location = new System.Drawing.Point(495, 5);
            this.txtbFilename.Margin = new System.Windows.Forms.Padding(5);
            this.txtbFilename.Name = "txtbFilename";
            this.txtbFilename.Size = new System.Drawing.Size(98, 26);
            this.txtbFilename.TabIndex = 4;
            this.txtbFilename.TabStop = false;
            this.txtbFilename.Text = "dict.txt";
            // 
            // txtbPath
            // 
            this.txtbPath.Location = new System.Drawing.Point(116, 5);
            this.txtbPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtbPath.Name = "txtbPath";
            this.txtbPath.ReadOnly = true;
            this.txtbPath.Size = new System.Drawing.Size(287, 26);
            this.txtbPath.TabIndex = 2;
            this.txtbPath.TabStop = false;
            this.txtbPath.Text = "C:\\";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(7, 0);
            this.btnPath.Margin = new System.Windows.Forms.Padding(5);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(99, 35);
            this.btnPath.TabIndex = 3;
            this.btnPath.TabStop = false;
            this.btnPath.Text = "选择文件夹";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // ucFileSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtbFilename);
            this.Controls.Add(this.txtbPath);
            this.Controls.Add(this.btnPath);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucFileSave";
            this.Size = new System.Drawing.Size(598, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtbFilename;
        private System.Windows.Forms.TextBox txtbPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.FolderBrowserDialog fbdlgChoose;
    }
}
