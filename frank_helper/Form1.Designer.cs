namespace assistant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.llblMe = new System.Windows.Forms.LinkLabel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.llblNotepad = new System.Windows.Forms.LinkLabel();
            this.llblMod = new System.Windows.Forms.LinkLabel();
            this.gpb1 = new System.Windows.Forms.GroupBox();
            this.gpb2 = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtbStore = new System.Windows.Forms.TextBox();
            this.txtbDoc = new System.Windows.Forms.TextBox();
            this.txtbDesktop = new System.Windows.Forms.TextBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.lblStore = new System.Windows.Forms.Label();
            this.btnDoc = new System.Windows.Forms.Button();
            this.lblDoc = new System.Windows.Forms.Label();
            this.btnDesktop = new System.Windows.Forms.Button();
            this.lblDesktop = new System.Windows.Forms.Label();
            this.fbdlg1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblState = new System.Windows.Forms.Label();
            this.gpb1.SuspendLayout();
            this.gpb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(17, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 34);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "安装notepad 2 Mod";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRollback
            // 
            this.btnRollback.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRollback.Location = new System.Drawing.Point(216, 20);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(147, 34);
            this.btnRollback.TabIndex = 0;
            this.btnRollback.Text = "恢复为Notepad";
            this.btnRollback.UseVisualStyleBackColor = true;
            this.btnRollback.Click += new System.EventHandler(this.btnRollback_Click);
            // 
            // llblMe
            // 
            this.llblMe.AutoSize = true;
            this.llblMe.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llblMe.Location = new System.Drawing.Point(329, 410);
            this.llblMe.Name = "llblMe";
            this.llblMe.Size = new System.Drawing.Size(56, 16);
            this.llblMe.TabIndex = 1;
            this.llblMe.TabStop = true;
            this.llblMe.Text = "网安石";
            this.llblMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMe_LinkClicked);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("宋体", 12F);
            this.lblInfo.Location = new System.Drawing.Point(14, 74);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(344, 48);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "    因需要替换系统文件，请务必关闭杀毒软件\r\n再操作,当出现“windows文件保护”对话框时，\r\n请先点击“取消”，再点击\"是\"。";
            // 
            // llblNotepad
            // 
            this.llblNotepad.AutoSize = true;
            this.llblNotepad.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llblNotepad.Location = new System.Drawing.Point(46, 134);
            this.llblNotepad.Name = "llblNotepad";
            this.llblNotepad.Size = new System.Drawing.Size(120, 16);
            this.llblNotepad.TabIndex = 1;
            this.llblNotepad.TabStop = true;
            this.llblNotepad.Text = "Notepad 2 官网";
            this.llblNotepad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNotepad_LinkClicked);
            // 
            // llblMod
            // 
            this.llblMod.AutoSize = true;
            this.llblMod.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llblMod.Location = new System.Drawing.Point(226, 134);
            this.llblMod.Name = "llblMod";
            this.llblMod.Size = new System.Drawing.Size(152, 16);
            this.llblMod.TabIndex = 1;
            this.llblMod.TabStop = true;
            this.llblMod.Text = "Notepad 2 Mod 官网";
            this.llblMod.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMod_LinkClicked);
            // 
            // gpb1
            // 
            this.gpb1.Controls.Add(this.lblInfo);
            this.gpb1.Controls.Add(this.btnUpdate);
            this.gpb1.Controls.Add(this.llblMod);
            this.gpb1.Controls.Add(this.btnRollback);
            this.gpb1.Controls.Add(this.llblNotepad);
            this.gpb1.Location = new System.Drawing.Point(12, 12);
            this.gpb1.Name = "gpb1";
            this.gpb1.Size = new System.Drawing.Size(384, 168);
            this.gpb1.TabIndex = 3;
            this.gpb1.TabStop = false;
            this.gpb1.Text = "升级记事本";
            // 
            // gpb2
            // 
            this.gpb2.Controls.Add(this.btnSet);
            this.gpb2.Controls.Add(this.btnMove);
            this.gpb2.Controls.Add(this.txtbStore);
            this.gpb2.Controls.Add(this.txtbDoc);
            this.gpb2.Controls.Add(this.txtbDesktop);
            this.gpb2.Controls.Add(this.btnStore);
            this.gpb2.Controls.Add(this.lblStore);
            this.gpb2.Controls.Add(this.btnDoc);
            this.gpb2.Controls.Add(this.lblDoc);
            this.gpb2.Controls.Add(this.btnDesktop);
            this.gpb2.Controls.Add(this.lblDesktop);
            this.gpb2.Location = new System.Drawing.Point(12, 203);
            this.gpb2.Name = "gpb2";
            this.gpb2.Size = new System.Drawing.Size(384, 191);
            this.gpb2.TabIndex = 4;
            this.gpb2.TabStop = false;
            this.gpb2.Text = "文件夹迁移";
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(50, 146);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(82, 39);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "设置生效";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMove.Location = new System.Drawing.Point(185, 146);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(155, 39);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "生效并迁移文件";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtbStore
            // 
            this.txtbStore.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbStore.Location = new System.Drawing.Point(60, 109);
            this.txtbStore.Name = "txtbStore";
            this.txtbStore.Size = new System.Drawing.Size(214, 26);
            this.txtbStore.TabIndex = 2;
            // 
            // txtbDoc
            // 
            this.txtbDoc.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbDoc.Location = new System.Drawing.Point(60, 66);
            this.txtbDoc.Name = "txtbDoc";
            this.txtbDoc.Size = new System.Drawing.Size(214, 26);
            this.txtbDoc.TabIndex = 2;
            // 
            // txtbDesktop
            // 
            this.txtbDesktop.Font = new System.Drawing.Font("宋体", 12F);
            this.txtbDesktop.Location = new System.Drawing.Point(60, 24);
            this.txtbDesktop.Name = "txtbDesktop";
            this.txtbDesktop.Size = new System.Drawing.Size(214, 26);
            this.txtbDesktop.TabIndex = 2;
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("宋体", 12F);
            this.btnStore.Location = new System.Drawing.Point(281, 109);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(97, 26);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "浏览";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("宋体", 12F);
            this.lblStore.Location = new System.Drawing.Point(4, 114);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(56, 16);
            this.lblStore.TabIndex = 0;
            this.lblStore.Text = "收藏夹";
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDoc.Location = new System.Drawing.Point(281, 66);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(97, 26);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "浏览";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("宋体", 12F);
            this.lblDoc.Location = new System.Drawing.Point(4, 71);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(40, 16);
            this.lblDoc.TabIndex = 0;
            this.lblDoc.Text = "文档";
            // 
            // btnDesktop
            // 
            this.btnDesktop.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDesktop.Location = new System.Drawing.Point(281, 24);
            this.btnDesktop.Name = "btnDesktop";
            this.btnDesktop.Size = new System.Drawing.Size(97, 26);
            this.btnDesktop.TabIndex = 1;
            this.btnDesktop.Text = "浏览";
            this.btnDesktop.UseVisualStyleBackColor = true;
            this.btnDesktop.Click += new System.EventHandler(this.btnDesktop_Click);
            // 
            // lblDesktop
            // 
            this.lblDesktop.AutoSize = true;
            this.lblDesktop.Font = new System.Drawing.Font("宋体", 12F);
            this.lblDesktop.Location = new System.Drawing.Point(4, 29);
            this.lblDesktop.Name = "lblDesktop";
            this.lblDesktop.Size = new System.Drawing.Size(40, 16);
            this.lblDesktop.TabIndex = 0;
            this.lblDesktop.Text = "桌面";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("宋体", 12F);
            this.lblState.Location = new System.Drawing.Point(72, 410);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(24, 16);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 435);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.gpb2);
            this.Controls.Add(this.gpb1);
            this.Controls.Add(this.llblMe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "稀饭小助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb1.ResumeLayout(false);
            this.gpb1.PerformLayout();
            this.gpb2.ResumeLayout(false);
            this.gpb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.LinkLabel llblMe;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.LinkLabel llblNotepad;
        private System.Windows.Forms.LinkLabel llblMod;
        private System.Windows.Forms.GroupBox gpb1;
        private System.Windows.Forms.GroupBox gpb2;
        private System.Windows.Forms.TextBox txtbStore;
        private System.Windows.Forms.TextBox txtbDoc;
        private System.Windows.Forms.TextBox txtbDesktop;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Button btnDesktop;
        private System.Windows.Forms.Label lblDesktop;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.FolderBrowserDialog fbdlg1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblState;
    }
}

