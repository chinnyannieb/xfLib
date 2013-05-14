using System;
using uc;

namespace crazyDict
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.chkbHyphen = new System.Windows.Forms.CheckBox();
            this.chkbNumber = new System.Windows.Forms.CheckBox();
            this.chkbLsmall = new System.Windows.Forms.CheckBox();
            this.chkbLbig = new System.Windows.Forms.CheckBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.gpbSave = new System.Windows.Forms.GroupBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.gpbPreview = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtbFileSize = new System.Windows.Forms.TextBox();
            this.txtbStrNum = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblLinesNum = new System.Windows.Forms.Label();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tpCharsMode = new System.Windows.Forms.TabPage();
            this.lblCharsModeError = new System.Windows.Forms.Label();
            this.gpbCharsMode = new System.Windows.Forms.GroupBox();
            this.lblSelf = new System.Windows.Forms.Label();
            this.txtbSelf = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.cbbEnd = new System.Windows.Forms.ComboBox();
            this.cbbStart = new System.Windows.Forms.ComboBox();
            this.tpStrMode = new System.Windows.Forms.TabPage();
            this.btnCoreStrClean = new System.Windows.Forms.Button();
            this.gpbCoreStrCombine = new System.Windows.Forms.GroupBox();
            this.rbtnCoreStrX = new System.Windows.Forms.RadioButton();
            this.rbtnCoreStrEasy = new System.Windows.Forms.RadioButton();
            this.rbtnCoreStrSelf = new System.Windows.Forms.RadioButton();
            this.gpCoreStrExt = new System.Windows.Forms.GroupBox();
            this.chkbReverse = new System.Windows.Forms.CheckBox();
            this.chkbToLower = new System.Windows.Forms.CheckBox();
            this.chkbToUpper = new System.Windows.Forms.CheckBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblCore = new System.Windows.Forms.Label();
            this.rtbCore = new System.Windows.Forms.RichTextBox();
            this.tpBitrhMode = new System.Windows.Forms.TabPage();
            this.lblBirthMsg = new System.Windows.Forms.Label();
            this.lstbDate = new System.Windows.Forms.ListBox();
            this.lblDateStyle = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tpDictEdit = new System.Windows.Forms.TabPage();
            this.tabControlEdit = new System.Windows.Forms.TabControl();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.lblTPInsert = new System.Windows.Forms.Label();
            this.txtbInsertNum = new System.Windows.Forms.TextBox();
            this.txtbInsertStr = new System.Windows.Forms.TextBox();
            this.txtbInsertTail = new System.Windows.Forms.TextBox();
            this.txtbInsertHead = new System.Windows.Forms.TextBox();
            this.lblInsertMid2 = new System.Windows.Forms.Label();
            this.lblInsertMid1 = new System.Windows.Forms.Label();
            this.lblInsertEnd = new System.Windows.Forms.Label();
            this.lblInsertHead = new System.Windows.Forms.Label();
            this.tpDel = new System.Windows.Forms.TabPage();
            this.rbtnDelMid = new System.Windows.Forms.RadioButton();
            this.rbtnDelTail = new System.Windows.Forms.RadioButton();
            this.rbtnDelHead = new System.Windows.Forms.RadioButton();
            this.txtbEditDelMidStartPoint = new System.Windows.Forms.TextBox();
            this.txtbEditDelMidLength = new System.Windows.Forms.TextBox();
            this.txtbEditDelTailCount = new System.Windows.Forms.TextBox();
            this.txtbEditDelHeadCount = new System.Windows.Forms.TextBox();
            this.lblEditDelMidB = new System.Windows.Forms.Label();
            this.lblEditDelMidA = new System.Windows.Forms.Label();
            this.tpReplace = new System.Windows.Forms.TabPage();
            this.rbtnFirstToUpper = new System.Windows.Forms.RadioButton();
            this.rbtnReverse = new System.Windows.Forms.RadioButton();
            this.rbtnToLower = new System.Windows.Forms.RadioButton();
            this.rbtnToUpper = new System.Windows.Forms.RadioButton();
            this.tpSort = new System.Windows.Forms.TabPage();
            this.rbtnSortCBA = new System.Windows.Forms.RadioButton();
            this.rbtnSortABC = new System.Windows.Forms.RadioButton();
            this.tpDictCom = new System.Windows.Forms.TabPage();
            this.lblFileA = new System.Windows.Forms.Label();
            this.lblFileB = new System.Windows.Forms.Label();
            this.rbtnBsubA = new System.Windows.Forms.RadioButton();
            this.rbtnAsubB = new System.Windows.Forms.RadioButton();
            this.rbtnCombineDiff = new System.Windows.Forms.RadioButton();
            this.rbtnCombineBoth = new System.Windows.Forms.RadioButton();
            this.rbtnDescartes = new System.Windows.Forms.RadioButton();
            this.rbtnCombineTotal = new System.Windows.Forms.RadioButton();
            this.ofDlg = new System.Windows.Forms.OpenFileDialog();
            this.sfDlg = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbPreview.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tpCharsMode.SuspendLayout();
            this.gpbCharsMode.SuspendLayout();
            this.tpStrMode.SuspendLayout();
            this.gpbCoreStrCombine.SuspendLayout();
            this.gpCoreStrExt.SuspendLayout();
            this.tpBitrhMode.SuspendLayout();
            this.tpDictEdit.SuspendLayout();
            this.tabControlEdit.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.tpDel.SuspendLayout();
            this.tpReplace.SuspendLayout();
            this.tpSort.SuspendLayout();
            this.tpDictCom.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbHyphen
            // 
            this.chkbHyphen.AutoSize = true;
            this.chkbHyphen.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkbHyphen.Location = new System.Drawing.Point(111, 63);
            this.chkbHyphen.Margin = new System.Windows.Forms.Padding(4);
            this.chkbHyphen.Name = "chkbHyphen";
            this.chkbHyphen.Size = new System.Drawing.Size(75, 18);
            this.chkbHyphen.TabIndex = 4;
            this.chkbHyphen.Text = "连字符-";
            this.chkbHyphen.UseVisualStyleBackColor = true;
            // 
            // chkbNumber
            // 
            this.chkbNumber.AutoSize = true;
            this.chkbNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkbNumber.Location = new System.Drawing.Point(17, 62);
            this.chkbNumber.Margin = new System.Windows.Forms.Padding(4);
            this.chkbNumber.Name = "chkbNumber";
            this.chkbNumber.Size = new System.Drawing.Size(54, 18);
            this.chkbNumber.TabIndex = 3;
            this.chkbNumber.Text = "0到9";
            this.chkbNumber.UseVisualStyleBackColor = true;
            // 
            // chkbLsmall
            // 
            this.chkbLsmall.AutoSize = true;
            this.chkbLsmall.Checked = true;
            this.chkbLsmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbLsmall.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkbLsmall.Location = new System.Drawing.Point(17, 27);
            this.chkbLsmall.Margin = new System.Windows.Forms.Padding(4);
            this.chkbLsmall.Name = "chkbLsmall";
            this.chkbLsmall.Size = new System.Drawing.Size(54, 18);
            this.chkbLsmall.TabIndex = 1;
            this.chkbLsmall.Text = "a到z";
            this.chkbLsmall.UseVisualStyleBackColor = true;
            // 
            // chkbLbig
            // 
            this.chkbLbig.AutoSize = true;
            this.chkbLbig.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkbLbig.Location = new System.Drawing.Point(111, 27);
            this.chkbLbig.Margin = new System.Windows.Forms.Padding(4);
            this.chkbLbig.Name = "chkbLbig";
            this.chkbLbig.Size = new System.Drawing.Size(54, 18);
            this.chkbLbig.TabIndex = 2;
            this.chkbLbig.Text = "A到Z";
            this.chkbLbig.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLength.Location = new System.Drawing.Point(431, 20);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(72, 16);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "字符位数";
            // 
            // gpbSave
            // 
            this.gpbSave.Font = new System.Drawing.Font("宋体", 12F);
            this.gpbSave.Location = new System.Drawing.Point(17, 409);
            this.gpbSave.Margin = new System.Windows.Forms.Padding(4);
            this.gpbSave.Name = "gpbSave";
            this.gpbSave.Padding = new System.Windows.Forms.Padding(4);
            this.gpbSave.Size = new System.Drawing.Size(662, 68);
            this.gpbSave.TabIndex = 5;
            this.gpbSave.TabStop = false;
            this.gpbSave.Text = "文件存储设定";
            // 
            // btnMake
            // 
            this.btnMake.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMake.Location = new System.Drawing.Point(39, 482);
            this.btnMake.Margin = new System.Windows.Forms.Padding(4);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(100, 35);
            this.btnMake.TabIndex = 5;
            this.btnMake.Text = "生成";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Enabled = false;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMsg.Location = new System.Drawing.Point(272, 491);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(144, 28);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "文件生成成功！";
            this.lblMsg.UseCompatibleTextRendering = true;
            this.lblMsg.Visible = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(522, 482);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 35);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "打开文件夹";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // gpbPreview
            // 
            this.gpbPreview.Controls.Add(this.btnPreview);
            this.gpbPreview.Controls.Add(this.txtbFileSize);
            this.gpbPreview.Controls.Add(this.txtbStrNum);
            this.gpbPreview.Controls.Add(this.lblFileSize);
            this.gpbPreview.Controls.Add(this.lblLinesNum);
            this.gpbPreview.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpbPreview.Location = new System.Drawing.Point(16, 331);
            this.gpbPreview.Margin = new System.Windows.Forms.Padding(4);
            this.gpbPreview.Name = "gpbPreview";
            this.gpbPreview.Padding = new System.Windows.Forms.Padding(4);
            this.gpbPreview.Size = new System.Drawing.Size(663, 70);
            this.gpbPreview.TabIndex = 7;
            this.gpbPreview.TabStop = false;
            this.gpbPreview.Text = "生成文件体积预览";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPreview.Location = new System.Drawing.Point(14, 25);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 35);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "预 览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtbFileSize
            // 
            this.txtbFileSize.Location = new System.Drawing.Point(477, 29);
            this.txtbFileSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtbFileSize.Name = "txtbFileSize";
            this.txtbFileSize.ReadOnly = true;
            this.txtbFileSize.Size = new System.Drawing.Size(152, 26);
            this.txtbFileSize.TabIndex = 7;
            // 
            // txtbStrNum
            // 
            this.txtbStrNum.Location = new System.Drawing.Point(229, 29);
            this.txtbStrNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtbStrNum.Name = "txtbStrNum";
            this.txtbStrNum.ReadOnly = true;
            this.txtbStrNum.Size = new System.Drawing.Size(150, 26);
            this.txtbStrNum.TabIndex = 7;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(393, 34);
            this.lblFileSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(80, 16);
            this.lblFileSize.TabIndex = 6;
            this.lblFileSize.Text = "文件体积:";
            // 
            // lblLinesNum
            // 
            this.lblLinesNum.AutoSize = true;
            this.lblLinesNum.Location = new System.Drawing.Point(132, 35);
            this.lblLinesNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinesNum.Name = "lblLinesNum";
            this.lblLinesNum.Size = new System.Drawing.Size(80, 16);
            this.lblLinesNum.TabIndex = 6;
            this.lblLinesNum.Text = "文件行数:";
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tpCharsMode);
            this.tabCtrl.Controls.Add(this.tpStrMode);
            this.tabCtrl.Controls.Add(this.tpBitrhMode);
            this.tabCtrl.Controls.Add(this.tpDictEdit);
            this.tabCtrl.Controls.Add(this.tpDictCom);
            this.tabCtrl.Font = new System.Drawing.Font("宋体", 12F);
            this.tabCtrl.HotTrack = true;
            this.tabCtrl.Location = new System.Drawing.Point(20, 6);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.tabCtrl.Multiline = true;
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(644, 314);
            this.tabCtrl.TabIndex = 1;
            // 
            // tpCharsMode
            // 
            this.tpCharsMode.Controls.Add(this.lblCharsModeError);
            this.tpCharsMode.Controls.Add(this.gpbCharsMode);
            this.tpCharsMode.Controls.Add(this.lblEnd);
            this.tpCharsMode.Controls.Add(this.lblStart);
            this.tpCharsMode.Controls.Add(this.lblLength);
            this.tpCharsMode.Controls.Add(this.cbbEnd);
            this.tpCharsMode.Controls.Add(this.cbbStart);
            this.tpCharsMode.Location = new System.Drawing.Point(4, 26);
            this.tpCharsMode.Margin = new System.Windows.Forms.Padding(4);
            this.tpCharsMode.Name = "tpCharsMode";
            this.tpCharsMode.Padding = new System.Windows.Forms.Padding(4);
            this.tpCharsMode.Size = new System.Drawing.Size(636, 284);
            this.tpCharsMode.TabIndex = 1;
            this.tpCharsMode.Text = "字符穷举";
            this.tpCharsMode.UseVisualStyleBackColor = true;
            // 
            // lblCharsModeError
            // 
            this.lblCharsModeError.AutoSize = true;
            this.lblCharsModeError.Location = new System.Drawing.Point(371, 97);
            this.lblCharsModeError.Name = "lblCharsModeError";
            this.lblCharsModeError.Size = new System.Drawing.Size(56, 16);
            this.lblCharsModeError.TabIndex = 7;
            this.lblCharsModeError.Text = "error!";
            this.lblCharsModeError.Visible = false;
            // 
            // gpbCharsMode
            // 
            this.gpbCharsMode.Controls.Add(this.lblSelf);
            this.gpbCharsMode.Controls.Add(this.chkbLsmall);
            this.gpbCharsMode.Controls.Add(this.txtbSelf);
            this.gpbCharsMode.Controls.Add(this.chkbLbig);
            this.gpbCharsMode.Controls.Add(this.chkbNumber);
            this.gpbCharsMode.Controls.Add(this.chkbHyphen);
            this.gpbCharsMode.Location = new System.Drawing.Point(15, 20);
            this.gpbCharsMode.Margin = new System.Windows.Forms.Padding(4);
            this.gpbCharsMode.Name = "gpbCharsMode";
            this.gpbCharsMode.Padding = new System.Windows.Forms.Padding(4);
            this.gpbCharsMode.Size = new System.Drawing.Size(278, 237);
            this.gpbCharsMode.TabIndex = 6;
            this.gpbCharsMode.TabStop = false;
            this.gpbCharsMode.Text = "字符集选择";
            // 
            // lblSelf
            // 
            this.lblSelf.AutoSize = true;
            this.lblSelf.Font = new System.Drawing.Font("宋体", 12F);
            this.lblSelf.Location = new System.Drawing.Point(37, 94);
            this.lblSelf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelf.Name = "lblSelf";
            this.lblSelf.Size = new System.Drawing.Size(200, 32);
            this.lblSelf.TabIndex = 6;
            this.lblSelf.Text = "在这里输入任意自定义字符\r\n连续输入即可，无需分隔符";
            // 
            // txtbSelf
            // 
            this.txtbSelf.Location = new System.Drawing.Point(6, 130);
            this.txtbSelf.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSelf.Multiline = true;
            this.txtbSelf.Name = "txtbSelf";
            this.txtbSelf.Size = new System.Drawing.Size(266, 99);
            this.txtbSelf.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEnd.Location = new System.Drawing.Point(479, 56);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(24, 16);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "到";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStart.Location = new System.Drawing.Point(357, 56);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(24, 16);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "从";
            // 
            // cbbEnd
            // 
            this.cbbEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbEnd.FormattingEnabled = true;
            this.cbbEnd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbEnd.Location = new System.Drawing.Point(514, 52);
            this.cbbEnd.Margin = new System.Windows.Forms.Padding(4);
            this.cbbEnd.Name = "cbbEnd";
            this.cbbEnd.Size = new System.Drawing.Size(59, 24);
            this.cbbEnd.TabIndex = 0;
            this.cbbEnd.SelectedValueChanged += new System.EventHandler(this.cbbEnd_SelectedValueChanged);
            // 
            // cbbStart
            // 
            this.cbbStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbStart.FormattingEnabled = true;
            this.cbbStart.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbStart.Location = new System.Drawing.Point(398, 52);
            this.cbbStart.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStart.Name = "cbbStart";
            this.cbbStart.Size = new System.Drawing.Size(59, 24);
            this.cbbStart.TabIndex = 0;
            this.cbbStart.SelectedValueChanged += new System.EventHandler(this.cbbStart_SelectedValueChanged);
            // 
            // tpStrMode
            // 
            this.tpStrMode.Controls.Add(this.btnCoreStrClean);
            this.tpStrMode.Controls.Add(this.gpbCoreStrCombine);
            this.tpStrMode.Controls.Add(this.gpCoreStrExt);
            this.tpStrMode.Controls.Add(this.btnOutput);
            this.tpStrMode.Controls.Add(this.btnInput);
            this.tpStrMode.Controls.Add(this.lblCore);
            this.tpStrMode.Controls.Add(this.rtbCore);
            this.tpStrMode.Location = new System.Drawing.Point(4, 26);
            this.tpStrMode.Margin = new System.Windows.Forms.Padding(4);
            this.tpStrMode.Name = "tpStrMode";
            this.tpStrMode.Padding = new System.Windows.Forms.Padding(4);
            this.tpStrMode.Size = new System.Drawing.Size(636, 284);
            this.tpStrMode.TabIndex = 2;
            this.tpStrMode.Text = "核心字符串";
            this.tpStrMode.UseVisualStyleBackColor = true;
            // 
            // btnCoreStrClean
            // 
            this.btnCoreStrClean.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCoreStrClean.Location = new System.Drawing.Point(131, 245);
            this.btnCoreStrClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoreStrClean.Name = "btnCoreStrClean";
            this.btnCoreStrClean.Size = new System.Drawing.Size(58, 32);
            this.btnCoreStrClean.TabIndex = 5;
            this.btnCoreStrClean.Text = "清空";
            this.btnCoreStrClean.UseVisualStyleBackColor = true;
            this.btnCoreStrClean.Click += new System.EventHandler(this.btnCoreStrClean_Click);
            // 
            // gpbCoreStrCombine
            // 
            this.gpbCoreStrCombine.Controls.Add(this.rbtnCoreStrX);
            this.gpbCoreStrCombine.Controls.Add(this.rbtnCoreStrEasy);
            this.gpbCoreStrCombine.Controls.Add(this.rbtnCoreStrSelf);
            this.gpbCoreStrCombine.Font = new System.Drawing.Font("宋体", 9F);
            this.gpbCoreStrCombine.Location = new System.Drawing.Point(329, 85);
            this.gpbCoreStrCombine.Name = "gpbCoreStrCombine";
            this.gpbCoreStrCombine.Size = new System.Drawing.Size(288, 85);
            this.gpbCoreStrCombine.TabIndex = 4;
            this.gpbCoreStrCombine.TabStop = false;
            this.gpbCoreStrCombine.Text = "核心字符串集和常见弱口令组合方式";
            // 
            // rbtnCoreStrX
            // 
            this.rbtnCoreStrX.AutoSize = true;
            this.rbtnCoreStrX.Location = new System.Drawing.Point(17, 62);
            this.rbtnCoreStrX.Name = "rbtnCoreStrX";
            this.rbtnCoreStrX.Size = new System.Drawing.Size(83, 16);
            this.rbtnCoreStrX.TabIndex = 0;
            this.rbtnCoreStrX.Text = "A和B的合集";
            this.rbtnCoreStrX.UseVisualStyleBackColor = true;
            // 
            // rbtnCoreStrEasy
            // 
            this.rbtnCoreStrEasy.AutoSize = true;
            this.rbtnCoreStrEasy.Location = new System.Drawing.Point(17, 41);
            this.rbtnCoreStrEasy.Name = "rbtnCoreStrEasy";
            this.rbtnCoreStrEasy.Size = new System.Drawing.Size(203, 16);
            this.rbtnCoreStrEasy.TabIndex = 0;
            this.rbtnCoreStrEasy.Text = "B 核心字符串集与常见弱口令组合";
            this.rbtnCoreStrEasy.UseVisualStyleBackColor = true;
            // 
            // rbtnCoreStrSelf
            // 
            this.rbtnCoreStrSelf.AutoSize = true;
            this.rbtnCoreStrSelf.Checked = true;
            this.rbtnCoreStrSelf.Location = new System.Drawing.Point(17, 20);
            this.rbtnCoreStrSelf.Name = "rbtnCoreStrSelf";
            this.rbtnCoreStrSelf.Size = new System.Drawing.Size(155, 16);
            this.rbtnCoreStrSelf.TabIndex = 0;
            this.rbtnCoreStrSelf.TabStop = true;
            this.rbtnCoreStrSelf.Text = "A 核心字符串集自身组合";
            this.rbtnCoreStrSelf.UseVisualStyleBackColor = true;
            // 
            // gpCoreStrExt
            // 
            this.gpCoreStrExt.Controls.Add(this.chkbReverse);
            this.gpCoreStrExt.Controls.Add(this.chkbToLower);
            this.gpCoreStrExt.Controls.Add(this.chkbToUpper);
            this.gpCoreStrExt.Font = new System.Drawing.Font("宋体", 9F);
            this.gpCoreStrExt.Location = new System.Drawing.Point(329, 14);
            this.gpCoreStrExt.Name = "gpCoreStrExt";
            this.gpCoreStrExt.Size = new System.Drawing.Size(291, 65);
            this.gpCoreStrExt.TabIndex = 3;
            this.gpCoreStrExt.TabStop = false;
            this.gpCoreStrExt.Text = "将核心字符串的以下变形加入核心字符串集";
            // 
            // chkbReverse
            // 
            this.chkbReverse.AutoSize = true;
            this.chkbReverse.Location = new System.Drawing.Point(169, 28);
            this.chkbReverse.Name = "chkbReverse";
            this.chkbReverse.Size = new System.Drawing.Size(84, 16);
            this.chkbReverse.TabIndex = 0;
            this.chkbReverse.Text = "大小写反转";
            this.chkbReverse.UseVisualStyleBackColor = true;
            // 
            // chkbToLower
            // 
            this.chkbToLower.AutoSize = true;
            this.chkbToLower.Location = new System.Drawing.Point(104, 28);
            this.chkbToLower.Name = "chkbToLower";
            this.chkbToLower.Size = new System.Drawing.Size(48, 16);
            this.chkbToLower.TabIndex = 0;
            this.chkbToLower.Text = "小写";
            this.chkbToLower.UseVisualStyleBackColor = true;
            // 
            // chkbToUpper
            // 
            this.chkbToUpper.AutoSize = true;
            this.chkbToUpper.Location = new System.Drawing.Point(39, 28);
            this.chkbToUpper.Name = "chkbToUpper";
            this.chkbToUpper.Size = new System.Drawing.Size(48, 16);
            this.chkbToUpper.TabIndex = 0;
            this.chkbToUpper.Text = "大写";
            this.chkbToUpper.UseVisualStyleBackColor = true;
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOutput.Location = new System.Drawing.Point(232, 245);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(58, 32);
            this.btnOutput.TabIndex = 2;
            this.btnOutput.Text = "导出";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("宋体", 12F);
            this.btnInput.Location = new System.Drawing.Point(30, 245);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(58, 32);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "导入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblCore
            // 
            this.lblCore.AutoSize = true;
            this.lblCore.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCore.Location = new System.Drawing.Point(18, 221);
            this.lblCore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(296, 16);
            this.lblCore.TabIndex = 1;
            this.lblCore.Text = "输入核心字符串，每行一个，不支持中文";
            // 
            // rtbCore
            // 
            this.rtbCore.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbCore.Location = new System.Drawing.Point(4, 4);
            this.rtbCore.Margin = new System.Windows.Forms.Padding(4);
            this.rtbCore.Name = "rtbCore";
            this.rtbCore.Size = new System.Drawing.Size(318, 211);
            this.rtbCore.TabIndex = 0;
            this.rtbCore.Text = "";
            // 
            // tpBitrhMode
            // 
            this.tpBitrhMode.Controls.Add(this.lblBirthMsg);
            this.tpBitrhMode.Controls.Add(this.lstbDate);
            this.tpBitrhMode.Controls.Add(this.lblDateStyle);
            this.tpBitrhMode.Controls.Add(this.lblDateEnd);
            this.tpBitrhMode.Controls.Add(this.lblDateStart);
            this.tpBitrhMode.Controls.Add(this.dtpEnd);
            this.tpBitrhMode.Controls.Add(this.dtpStart);
            this.tpBitrhMode.Controls.Add(this.lblEndDate);
            this.tpBitrhMode.Controls.Add(this.lblStartDate);
            this.tpBitrhMode.Location = new System.Drawing.Point(4, 26);
            this.tpBitrhMode.Margin = new System.Windows.Forms.Padding(4);
            this.tpBitrhMode.Name = "tpBitrhMode";
            this.tpBitrhMode.Padding = new System.Windows.Forms.Padding(4);
            this.tpBitrhMode.Size = new System.Drawing.Size(636, 284);
            this.tpBitrhMode.TabIndex = 3;
            this.tpBitrhMode.Text = "生日模式";
            this.tpBitrhMode.UseVisualStyleBackColor = true;
            // 
            // lblBirthMsg
            // 
            this.lblBirthMsg.AutoSize = true;
            this.lblBirthMsg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBirthMsg.Location = new System.Drawing.Point(245, 59);
            this.lblBirthMsg.Name = "lblBirthMsg";
            this.lblBirthMsg.Size = new System.Drawing.Size(216, 16);
            this.lblBirthMsg.TabIndex = 16;
            this.lblBirthMsg.Text = "起始日期必须小于结束日期！";
            this.lblBirthMsg.Visible = false;
            // 
            // lstbDate
            // 
            this.lstbDate.FormattingEnabled = true;
            this.lstbDate.ItemHeight = 16;
            this.lstbDate.Items.AddRange(new object[] {
            "2010年01月01日",
            "2010年1月1日",
            "20100101",
            "2010.01.01",
            "2010.1.1",
            "2010-01-01",
            "2010-1-1"});
            this.lstbDate.Location = new System.Drawing.Point(17, 85);
            this.lstbDate.Name = "lstbDate";
            this.lstbDate.Size = new System.Drawing.Size(228, 180);
            this.lstbDate.TabIndex = 15;
            // 
            // lblDateStyle
            // 
            this.lblDateStyle.AutoSize = true;
            this.lblDateStyle.Location = new System.Drawing.Point(47, 59);
            this.lblDateStyle.Name = "lblDateStyle";
            this.lblDateStyle.Size = new System.Drawing.Size(104, 16);
            this.lblDateStyle.TabIndex = 14;
            this.lblDateStyle.Text = "日期样式选择";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(371, 18);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(80, 16);
            this.lblDateEnd.TabIndex = 12;
            this.lblDateEnd.Text = "结束日期:";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(25, 18);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(80, 16);
            this.lblDateStart.TabIndex = 12;
            this.lblDateStart.Text = "开始日期:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(457, 13);
            this.dtpEnd.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1949, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(135, 26);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.Value = new System.DateTime(2010, 9, 25, 0, 0, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "";
            this.dtpStart.Location = new System.Drawing.Point(111, 13);
            this.dtpStart.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1949, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(135, 26);
            this.dtpStart.TabIndex = 11;
            this.dtpStart.Value = new System.DateTime(2010, 9, 25, 0, 0, 0, 0);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(123, 59);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(48, 16);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "     ";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(122, 18);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(48, 16);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "     ";
            // 
            // tpDictEdit
            // 
            this.tpDictEdit.Controls.Add(this.tabControlEdit);
            this.tpDictEdit.Location = new System.Drawing.Point(4, 26);
            this.tpDictEdit.Margin = new System.Windows.Forms.Padding(4);
            this.tpDictEdit.Name = "tpDictEdit";
            this.tpDictEdit.Padding = new System.Windows.Forms.Padding(4);
            this.tpDictEdit.Size = new System.Drawing.Size(636, 284);
            this.tpDictEdit.TabIndex = 5;
            this.tpDictEdit.Text = "字典编辑";
            this.tpDictEdit.UseVisualStyleBackColor = true;
            this.tpDictEdit.Enter += new System.EventHandler(this.tpDictEdit_Enter);
            this.tpDictEdit.Leave += new System.EventHandler(this.tpDictEdit_Leave);
            // 
            // tabControlEdit
            // 
            this.tabControlEdit.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlEdit.Controls.Add(this.tpAdd);
            this.tabControlEdit.Controls.Add(this.tpDel);
            this.tabControlEdit.Controls.Add(this.tpReplace);
            this.tabControlEdit.Controls.Add(this.tpSort);
            this.tabControlEdit.ItemSize = new System.Drawing.Size(152, 25);
            this.tabControlEdit.Location = new System.Drawing.Point(9, 63);
            this.tabControlEdit.Multiline = true;
            this.tabControlEdit.Name = "tabControlEdit";
            this.tabControlEdit.SelectedIndex = 0;
            this.tabControlEdit.Size = new System.Drawing.Size(620, 215);
            this.tabControlEdit.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlEdit.TabIndex = 2;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.lblTPInsert);
            this.tpAdd.Controls.Add(this.txtbInsertNum);
            this.tpAdd.Controls.Add(this.txtbInsertStr);
            this.tpAdd.Controls.Add(this.txtbInsertTail);
            this.tpAdd.Controls.Add(this.txtbInsertHead);
            this.tpAdd.Controls.Add(this.lblInsertMid2);
            this.tpAdd.Controls.Add(this.lblInsertMid1);
            this.tpAdd.Controls.Add(this.lblInsertEnd);
            this.tpAdd.Controls.Add(this.lblInsertHead);
            this.tpAdd.Location = new System.Drawing.Point(4, 4);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(612, 182);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "逐行插入";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // lblTPInsert
            // 
            this.lblTPInsert.AutoSize = true;
            this.lblTPInsert.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTPInsert.Location = new System.Drawing.Point(92, 136);
            this.lblTPInsert.Name = "lblTPInsert";
            this.lblTPInsert.Size = new System.Drawing.Size(376, 32);
            this.lblTPInsert.TabIndex = 2;
            this.lblTPInsert.Text = "同时在多个位置插入时，软件执行顺序是C-B-A。\r\n当插入位置大于字符串长度，字符串将连接在最后。";
            this.lblTPInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbInsertNum
            // 
            this.txtbInsertNum.Location = new System.Drawing.Point(98, 89);
            this.txtbInsertNum.Name = "txtbInsertNum";
            this.txtbInsertNum.Size = new System.Drawing.Size(35, 26);
            this.txtbInsertNum.TabIndex = 1;
            // 
            // txtbInsertStr
            // 
            this.txtbInsertStr.Location = new System.Drawing.Point(290, 89);
            this.txtbInsertStr.Name = "txtbInsertStr";
            this.txtbInsertStr.Size = new System.Drawing.Size(296, 26);
            this.txtbInsertStr.TabIndex = 1;
            // 
            // txtbInsertTail
            // 
            this.txtbInsertTail.Location = new System.Drawing.Point(185, 48);
            this.txtbInsertTail.Name = "txtbInsertTail";
            this.txtbInsertTail.Size = new System.Drawing.Size(296, 26);
            this.txtbInsertTail.TabIndex = 1;
            // 
            // txtbInsertHead
            // 
            this.txtbInsertHead.Location = new System.Drawing.Point(185, 14);
            this.txtbInsertHead.Name = "txtbInsertHead";
            this.txtbInsertHead.Size = new System.Drawing.Size(296, 26);
            this.txtbInsertHead.TabIndex = 1;
            // 
            // lblInsertMid2
            // 
            this.lblInsertMid2.AutoSize = true;
            this.lblInsertMid2.Location = new System.Drawing.Point(134, 94);
            this.lblInsertMid2.Name = "lblInsertMid2";
            this.lblInsertMid2.Size = new System.Drawing.Size(152, 16);
            this.lblInsertMid2.TabIndex = 0;
            this.lblInsertMid2.Text = "个字符前插入字符串";
            // 
            // lblInsertMid1
            // 
            this.lblInsertMid1.AutoSize = true;
            this.lblInsertMid1.Location = new System.Drawing.Point(27, 94);
            this.lblInsertMid1.Name = "lblInsertMid1";
            this.lblInsertMid1.Size = new System.Drawing.Size(72, 16);
            this.lblInsertMid1.TabIndex = 0;
            this.lblInsertMid1.Text = "C.  在第";
            // 
            // lblInsertEnd
            // 
            this.lblInsertEnd.AutoSize = true;
            this.lblInsertEnd.Location = new System.Drawing.Point(27, 53);
            this.lblInsertEnd.Name = "lblInsertEnd";
            this.lblInsertEnd.Size = new System.Drawing.Size(152, 16);
            this.lblInsertEnd.TabIndex = 0;
            this.lblInsertEnd.Text = "B.  尾部插入字符串";
            // 
            // lblInsertHead
            // 
            this.lblInsertHead.AutoSize = true;
            this.lblInsertHead.Location = new System.Drawing.Point(27, 19);
            this.lblInsertHead.Name = "lblInsertHead";
            this.lblInsertHead.Size = new System.Drawing.Size(152, 16);
            this.lblInsertHead.TabIndex = 0;
            this.lblInsertHead.Text = "A.  首部插入字符串";
            // 
            // tpDel
            // 
            this.tpDel.Controls.Add(this.rbtnDelMid);
            this.tpDel.Controls.Add(this.rbtnDelTail);
            this.tpDel.Controls.Add(this.rbtnDelHead);
            this.tpDel.Controls.Add(this.txtbEditDelMidStartPoint);
            this.tpDel.Controls.Add(this.txtbEditDelMidLength);
            this.tpDel.Controls.Add(this.txtbEditDelTailCount);
            this.tpDel.Controls.Add(this.txtbEditDelHeadCount);
            this.tpDel.Controls.Add(this.lblEditDelMidB);
            this.tpDel.Controls.Add(this.lblEditDelMidA);
            this.tpDel.Location = new System.Drawing.Point(4, 4);
            this.tpDel.Name = "tpDel";
            this.tpDel.Padding = new System.Windows.Forms.Padding(3);
            this.tpDel.Size = new System.Drawing.Size(612, 182);
            this.tpDel.TabIndex = 1;
            this.tpDel.Text = "逐行删除";
            this.tpDel.UseVisualStyleBackColor = true;
            // 
            // rbtnDelMid
            // 
            this.rbtnDelMid.AutoSize = true;
            this.rbtnDelMid.Location = new System.Drawing.Point(30, 115);
            this.rbtnDelMid.Name = "rbtnDelMid";
            this.rbtnDelMid.Size = new System.Drawing.Size(90, 20);
            this.rbtnDelMid.TabIndex = 11;
            this.rbtnDelMid.TabStop = true;
            this.rbtnDelMid.Text = "中间删除";
            this.rbtnDelMid.UseVisualStyleBackColor = true;
            // 
            // rbtnDelTail
            // 
            this.rbtnDelTail.AutoSize = true;
            this.rbtnDelTail.Location = new System.Drawing.Point(30, 67);
            this.rbtnDelTail.Name = "rbtnDelTail";
            this.rbtnDelTail.Size = new System.Drawing.Size(186, 20);
            this.rbtnDelTail.TabIndex = 11;
            this.rbtnDelTail.TabStop = true;
            this.rbtnDelTail.Text = "尾部删除    字符个数";
            this.rbtnDelTail.UseVisualStyleBackColor = true;
            // 
            // rbtnDelHead
            // 
            this.rbtnDelHead.AutoSize = true;
            this.rbtnDelHead.Location = new System.Drawing.Point(30, 16);
            this.rbtnDelHead.Name = "rbtnDelHead";
            this.rbtnDelHead.Size = new System.Drawing.Size(186, 20);
            this.rbtnDelHead.TabIndex = 11;
            this.rbtnDelHead.TabStop = true;
            this.rbtnDelHead.Text = "头部删掉    字符个数";
            this.rbtnDelHead.UseVisualStyleBackColor = true;
            // 
            // txtbEditDelMidStartPoint
            // 
            this.txtbEditDelMidStartPoint.Location = new System.Drawing.Point(228, 112);
            this.txtbEditDelMidStartPoint.Name = "txtbEditDelMidStartPoint";
            this.txtbEditDelMidStartPoint.Size = new System.Drawing.Size(55, 26);
            this.txtbEditDelMidStartPoint.TabIndex = 6;
            this.txtbEditDelMidStartPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelNonDigit_KeyPress);
            // 
            // txtbEditDelMidLength
            // 
            this.txtbEditDelMidLength.Location = new System.Drawing.Point(399, 112);
            this.txtbEditDelMidLength.Name = "txtbEditDelMidLength";
            this.txtbEditDelMidLength.Size = new System.Drawing.Size(55, 26);
            this.txtbEditDelMidLength.TabIndex = 7;
            this.txtbEditDelMidLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelNonDigit_KeyPress);
            // 
            // txtbEditDelTailCount
            // 
            this.txtbEditDelTailCount.Location = new System.Drawing.Point(228, 61);
            this.txtbEditDelTailCount.Name = "txtbEditDelTailCount";
            this.txtbEditDelTailCount.Size = new System.Drawing.Size(55, 26);
            this.txtbEditDelTailCount.TabIndex = 8;
            this.txtbEditDelTailCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelNonDigit_KeyPress);
            // 
            // txtbEditDelHeadCount
            // 
            this.txtbEditDelHeadCount.Location = new System.Drawing.Point(228, 16);
            this.txtbEditDelHeadCount.Name = "txtbEditDelHeadCount";
            this.txtbEditDelHeadCount.Size = new System.Drawing.Size(55, 26);
            this.txtbEditDelHeadCount.TabIndex = 9;
            this.txtbEditDelHeadCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelNonDigit_KeyPress);
            // 
            // lblEditDelMidB
            // 
            this.lblEditDelMidB.AutoSize = true;
            this.lblEditDelMidB.Location = new System.Drawing.Point(289, 117);
            this.lblEditDelMidB.Name = "lblEditDelMidB";
            this.lblEditDelMidB.Size = new System.Drawing.Size(104, 16);
            this.lblEditDelMidB.TabIndex = 3;
            this.lblEditDelMidB.Text = "删除字符个数";
            // 
            // lblEditDelMidA
            // 
            this.lblEditDelMidA.AutoSize = true;
            this.lblEditDelMidA.Location = new System.Drawing.Point(144, 117);
            this.lblEditDelMidA.Name = "lblEditDelMidA";
            this.lblEditDelMidA.Size = new System.Drawing.Size(72, 16);
            this.lblEditDelMidA.TabIndex = 2;
            this.lblEditDelMidA.Text = "开始位置";
            // 
            // tpReplace
            // 
            this.tpReplace.Controls.Add(this.rbtnFirstToUpper);
            this.tpReplace.Controls.Add(this.rbtnReverse);
            this.tpReplace.Controls.Add(this.rbtnToLower);
            this.tpReplace.Controls.Add(this.rbtnToUpper);
            this.tpReplace.Location = new System.Drawing.Point(4, 4);
            this.tpReplace.Name = "tpReplace";
            this.tpReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tpReplace.Size = new System.Drawing.Size(612, 182);
            this.tpReplace.TabIndex = 2;
            this.tpReplace.Text = "替换";
            this.tpReplace.UseVisualStyleBackColor = true;
            // 
            // rbtnFirstToUpper
            // 
            this.rbtnFirstToUpper.AutoSize = true;
            this.rbtnFirstToUpper.Location = new System.Drawing.Point(8, 117);
            this.rbtnFirstToUpper.Name = "rbtnFirstToUpper";
            this.rbtnFirstToUpper.Size = new System.Drawing.Size(106, 20);
            this.rbtnFirstToUpper.TabIndex = 0;
            this.rbtnFirstToUpper.TabStop = true;
            this.rbtnFirstToUpper.Text = "首字母大写";
            this.rbtnFirstToUpper.UseVisualStyleBackColor = true;
            // 
            // rbtnReverse
            // 
            this.rbtnReverse.AutoSize = true;
            this.rbtnReverse.Location = new System.Drawing.Point(8, 81);
            this.rbtnReverse.Name = "rbtnReverse";
            this.rbtnReverse.Size = new System.Drawing.Size(138, 20);
            this.rbtnReverse.TabIndex = 0;
            this.rbtnReverse.TabStop = true;
            this.rbtnReverse.Text = "字母大小写反转";
            this.rbtnReverse.UseVisualStyleBackColor = true;
            // 
            // rbtnToLower
            // 
            this.rbtnToLower.AutoSize = true;
            this.rbtnToLower.Location = new System.Drawing.Point(8, 45);
            this.rbtnToLower.Name = "rbtnToLower";
            this.rbtnToLower.Size = new System.Drawing.Size(122, 20);
            this.rbtnToLower.TabIndex = 0;
            this.rbtnToLower.TabStop = true;
            this.rbtnToLower.Text = "字母全部小写";
            this.rbtnToLower.UseVisualStyleBackColor = true;
            // 
            // rbtnToUpper
            // 
            this.rbtnToUpper.AutoSize = true;
            this.rbtnToUpper.Location = new System.Drawing.Point(8, 9);
            this.rbtnToUpper.Name = "rbtnToUpper";
            this.rbtnToUpper.Size = new System.Drawing.Size(122, 20);
            this.rbtnToUpper.TabIndex = 0;
            this.rbtnToUpper.TabStop = true;
            this.rbtnToUpper.Text = "字母全部大写";
            this.rbtnToUpper.UseVisualStyleBackColor = true;
            // 
            // tpSort
            // 
            this.tpSort.Controls.Add(this.rbtnSortCBA);
            this.tpSort.Controls.Add(this.rbtnSortABC);
            this.tpSort.Location = new System.Drawing.Point(4, 4);
            this.tpSort.Name = "tpSort";
            this.tpSort.Padding = new System.Windows.Forms.Padding(3);
            this.tpSort.Size = new System.Drawing.Size(612, 182);
            this.tpSort.TabIndex = 3;
            this.tpSort.Text = "排序";
            this.tpSort.UseVisualStyleBackColor = true;
            // 
            // rbtnSortCBA
            // 
            this.rbtnSortCBA.AutoSize = true;
            this.rbtnSortCBA.Location = new System.Drawing.Point(17, 51);
            this.rbtnSortCBA.Name = "rbtnSortCBA";
            this.rbtnSortCBA.Size = new System.Drawing.Size(138, 20);
            this.rbtnSortCBA.TabIndex = 2;
            this.rbtnSortCBA.TabStop = true;
            this.rbtnSortCBA.Text = "所有行逆序排列";
            this.rbtnSortCBA.UseVisualStyleBackColor = true;
            // 
            // rbtnSortABC
            // 
            this.rbtnSortABC.AutoSize = true;
            this.rbtnSortABC.Location = new System.Drawing.Point(17, 15);
            this.rbtnSortABC.Name = "rbtnSortABC";
            this.rbtnSortABC.Size = new System.Drawing.Size(138, 20);
            this.rbtnSortABC.TabIndex = 1;
            this.rbtnSortABC.TabStop = true;
            this.rbtnSortABC.Text = "所有行正序排列";
            this.rbtnSortABC.UseVisualStyleBackColor = true;
            // 
            // tpDictCom
            // 
            this.tpDictCom.Controls.Add(this.lblFileA);
            this.tpDictCom.Controls.Add(this.lblFileB);
            this.tpDictCom.Controls.Add(this.rbtnBsubA);
            this.tpDictCom.Controls.Add(this.rbtnAsubB);
            this.tpDictCom.Controls.Add(this.rbtnCombineDiff);
            this.tpDictCom.Controls.Add(this.rbtnCombineBoth);
            this.tpDictCom.Controls.Add(this.rbtnDescartes);
            this.tpDictCom.Controls.Add(this.rbtnCombineTotal);
            this.tpDictCom.Location = new System.Drawing.Point(4, 26);
            this.tpDictCom.Margin = new System.Windows.Forms.Padding(4);
            this.tpDictCom.Name = "tpDictCom";
            this.tpDictCom.Padding = new System.Windows.Forms.Padding(4);
            this.tpDictCom.Size = new System.Drawing.Size(636, 284);
            this.tpDictCom.TabIndex = 4;
            this.tpDictCom.Text = "字典组合";
            this.tpDictCom.UseVisualStyleBackColor = true;
            // 
            // lblFileA
            // 
            this.lblFileA.AutoSize = true;
            this.lblFileA.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileA.Location = new System.Drawing.Point(22, 17);
            this.lblFileA.Name = "lblFileA";
            this.lblFileA.Size = new System.Drawing.Size(57, 19);
            this.lblFileA.TabIndex = 1;
            this.lblFileA.Text = "文件A";
            // 
            // lblFileB
            // 
            this.lblFileB.AutoSize = true;
            this.lblFileB.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileB.Location = new System.Drawing.Point(22, 58);
            this.lblFileB.Name = "lblFileB";
            this.lblFileB.Size = new System.Drawing.Size(57, 19);
            this.lblFileB.TabIndex = 1;
            this.lblFileB.Text = "文件B";
            // 
            // rbtnBsubA
            // 
            this.rbtnBsubA.AutoSize = true;
            this.rbtnBsubA.Location = new System.Drawing.Point(221, 170);
            this.rbtnBsubA.Name = "rbtnBsubA";
            this.rbtnBsubA.Size = new System.Drawing.Size(186, 20);
            this.rbtnBsubA.TabIndex = 4;
            this.rbtnBsubA.TabStop = true;
            this.rbtnBsubA.Text = "B的行中减去与A重复的";
            this.rbtnBsubA.UseVisualStyleBackColor = true;
            // 
            // rbtnAsubB
            // 
            this.rbtnAsubB.AutoSize = true;
            this.rbtnAsubB.Location = new System.Drawing.Point(221, 132);
            this.rbtnAsubB.Name = "rbtnAsubB";
            this.rbtnAsubB.Size = new System.Drawing.Size(186, 20);
            this.rbtnAsubB.TabIndex = 4;
            this.rbtnAsubB.TabStop = true;
            this.rbtnAsubB.Text = "A的行中减去与B重复的";
            this.rbtnAsubB.UseVisualStyleBackColor = true;
            // 
            // rbtnCombineDiff
            // 
            this.rbtnCombineDiff.AutoSize = true;
            this.rbtnCombineDiff.Location = new System.Drawing.Point(21, 170);
            this.rbtnCombineDiff.Name = "rbtnCombineDiff";
            this.rbtnCombineDiff.Size = new System.Drawing.Size(170, 20);
            this.rbtnCombineDiff.TabIndex = 5;
            this.rbtnCombineDiff.TabStop = true;
            this.rbtnCombineDiff.Text = "保留两者不重复的行";
            this.rbtnCombineDiff.UseVisualStyleBackColor = true;
            // 
            // rbtnCombineBoth
            // 
            this.rbtnCombineBoth.AutoSize = true;
            this.rbtnCombineBoth.Location = new System.Drawing.Point(21, 132);
            this.rbtnCombineBoth.Name = "rbtnCombineBoth";
            this.rbtnCombineBoth.Size = new System.Drawing.Size(154, 20);
            this.rbtnCombineBoth.TabIndex = 2;
            this.rbtnCombineBoth.TabStop = true;
            this.rbtnCombineBoth.Text = "保留两者共有的行";
            this.rbtnCombineBoth.UseVisualStyleBackColor = true;
            // 
            // rbtnDescartes
            // 
            this.rbtnDescartes.AutoSize = true;
            this.rbtnDescartes.Location = new System.Drawing.Point(21, 94);
            this.rbtnDescartes.Name = "rbtnDescartes";
            this.rbtnDescartes.Size = new System.Drawing.Size(138, 20);
            this.rbtnDescartes.TabIndex = 3;
            this.rbtnDescartes.TabStop = true;
            this.rbtnDescartes.Text = "A和B的笛卡尔积";
            this.rbtnDescartes.UseVisualStyleBackColor = true;
            // 
            // rbtnCombineTotal
            // 
            this.rbtnCombineTotal.AutoSize = true;
            this.rbtnCombineTotal.Location = new System.Drawing.Point(221, 94);
            this.rbtnCombineTotal.Name = "rbtnCombineTotal";
            this.rbtnCombineTotal.Size = new System.Drawing.Size(218, 20);
            this.rbtnCombineTotal.TabIndex = 3;
            this.rbtnCombineTotal.TabStop = true;
            this.rbtnCombineTotal.Text = "文本行之和，去掉了重复行";
            this.rbtnCombineTotal.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.BlogToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(119, 48);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.AboutToolStripMenuItem.Text = "关于";
            // 
            // BlogToolStripMenuItem
            // 
            this.BlogToolStripMenuItem.Name = "BlogToolStripMenuItem";
            this.BlogToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.BlogToolStripMenuItem.Text = "作者博客";
            this.BlogToolStripMenuItem.Click += new System.EventHandler(this.BlogToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 529);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.gpbPreview);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.gpbSave);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrazyDict";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gpbPreview.ResumeLayout(false);
            this.gpbPreview.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            this.tpCharsMode.ResumeLayout(false);
            this.tpCharsMode.PerformLayout();
            this.gpbCharsMode.ResumeLayout(false);
            this.gpbCharsMode.PerformLayout();
            this.tpStrMode.ResumeLayout(false);
            this.tpStrMode.PerformLayout();
            this.gpbCoreStrCombine.ResumeLayout(false);
            this.gpbCoreStrCombine.PerformLayout();
            this.gpCoreStrExt.ResumeLayout(false);
            this.gpCoreStrExt.PerformLayout();
            this.tpBitrhMode.ResumeLayout(false);
            this.tpBitrhMode.PerformLayout();
            this.tpDictEdit.ResumeLayout(false);
            this.tabControlEdit.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.tpDel.ResumeLayout(false);
            this.tpDel.PerformLayout();
            this.tpReplace.ResumeLayout(false);
            this.tpReplace.PerformLayout();
            this.tpSort.ResumeLayout(false);
            this.tpSort.PerformLayout();
            this.tpDictCom.ResumeLayout(false);
            this.tpDictCom.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.CheckBox chkbHyphen;
        private System.Windows.Forms.CheckBox chkbNumber;
        private System.Windows.Forms.CheckBox chkbLsmall;
        private System.Windows.Forms.CheckBox chkbLbig;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.GroupBox gpbSave;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox gpbPreview;
        private System.Windows.Forms.TextBox txtbFileSize;
        private System.Windows.Forms.TextBox txtbStrNum;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblLinesNum;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tpCharsMode;
        private System.Windows.Forms.TabPage tpStrMode;
        private System.Windows.Forms.TabPage tpBitrhMode;
        private System.Windows.Forms.TabPage tpDictCom;
        private System.Windows.Forms.TabPage tpDictEdit;
        private System.Windows.Forms.GroupBox gpbCharsMode;
        private System.Windows.Forms.TextBox txtbSelf;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblSelf;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label lblCore;
        private System.Windows.Forms.RichTextBox rtbCore;
        private System.Windows.Forms.OpenFileDialog ofDlg;
        private System.Windows.Forms.SaveFileDialog sfDlg;
        private uc.ucFileOpen ucFOCombineA;
        private uc.ucFileOpen ucFOCombineB;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateStyle;
        private System.Windows.Forms.TabControl tabControlEdit;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TabPage tpDel;
        private System.Windows.Forms.Label lblFileB;
        private System.Windows.Forms.Label lblFileA;
        private System.Windows.Forms.TabPage tpReplace;
        private System.Windows.Forms.TabPage tpSort;
        private System.Windows.Forms.Label lblInsertMid2;
        private System.Windows.Forms.Label lblInsertMid1;
        private System.Windows.Forms.Label lblInsertEnd;
        private System.Windows.Forms.Label lblInsertHead;
        private System.Windows.Forms.TextBox txtbInsertNum;
        private System.Windows.Forms.TextBox txtbInsertStr;
        private System.Windows.Forms.TextBox txtbInsertTail;
        private System.Windows.Forms.TextBox txtbInsertHead;
        private System.Windows.Forms.ComboBox cbbEnd;
        private System.Windows.Forms.ComboBox cbbStart;
        private System.Windows.Forms.Label lblCharsModeError;
        private System.Windows.Forms.Label lblTPInsert;
        private ucFileOpen ucFODictEdit;
        private ucFileSave ucDstPath;
        private System.Windows.Forms.TextBox txtbEditDelMidStartPoint;
        private System.Windows.Forms.TextBox txtbEditDelMidLength;
        private System.Windows.Forms.TextBox txtbEditDelTailCount;
        private System.Windows.Forms.TextBox txtbEditDelHeadCount;
        private System.Windows.Forms.Label lblEditDelMidB;
        private System.Windows.Forms.Label lblEditDelMidA;
        private System.Windows.Forms.GroupBox gpCoreStrExt;
        private System.Windows.Forms.CheckBox chkbReverse;
        private System.Windows.Forms.CheckBox chkbToLower;
        private System.Windows.Forms.CheckBox chkbToUpper;
        private System.Windows.Forms.GroupBox gpbCoreStrCombine;
        private System.Windows.Forms.RadioButton rbtnCoreStrX;
        private System.Windows.Forms.RadioButton rbtnCoreStrEasy;
        private System.Windows.Forms.RadioButton rbtnCoreStrSelf;
        private System.Windows.Forms.Button btnCoreStrClean;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lstbDate;
        private System.Windows.Forms.Label lblBirthMsg;
        private System.Windows.Forms.RadioButton rbtnFirstToUpper;
        private System.Windows.Forms.RadioButton rbtnReverse;
        private System.Windows.Forms.RadioButton rbtnToLower;
        private System.Windows.Forms.RadioButton rbtnToUpper;
        private System.Windows.Forms.RadioButton rbtnSortCBA;
        private System.Windows.Forms.RadioButton rbtnSortABC;
        private System.Windows.Forms.RadioButton rbtnAsubB;
        private System.Windows.Forms.RadioButton rbtnCombineDiff;
        private System.Windows.Forms.RadioButton rbtnCombineBoth;
        private System.Windows.Forms.RadioButton rbtnCombineTotal;
        private System.Windows.Forms.RadioButton rbtnBsubA;
        private System.Windows.Forms.RadioButton rbtnDescartes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlogToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbtnDelMid;
        private System.Windows.Forms.RadioButton rbtnDelTail;
        private System.Windows.Forms.RadioButton rbtnDelHead;
    }
}

