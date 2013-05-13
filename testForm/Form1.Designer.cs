namespace testForm
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.车牌号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.驾驶员编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生产厂家DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发动机编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆类型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否报废DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆档案BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDataSet = new testForm.carsDataSet();
            this.车辆档案TableAdapter = new testForm.carsDataSetTableAdapters.车辆档案TableAdapter();
            this.btnPreview = new System.Windows.Forms.Button();
            this.psDlg = new System.Windows.Forms.PageSetupDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.ppDlg = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPageSet = new System.Windows.Forms.Button();
            this.lstbPrinters = new System.Windows.Forms.ListBox();
            this.打印机列表 = new System.Windows.Forms.Label();
            this.ptDlg = new System.Windows.Forms.PrintDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.车辆档案BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.车牌号DataGridViewTextBoxColumn,
            this.驾驶员编号DataGridViewTextBoxColumn,
            this.品牌DataGridViewTextBoxColumn,
            this.生产厂家DataGridViewTextBoxColumn,
            this.发动机编号DataGridViewTextBoxColumn,
            this.车辆类型DataGridViewTextBoxColumn,
            this.是否报废DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.车辆档案BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(743, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // 车牌号DataGridViewTextBoxColumn
            // 
            this.车牌号DataGridViewTextBoxColumn.DataPropertyName = "车牌号";
            this.车牌号DataGridViewTextBoxColumn.HeaderText = "车牌号";
            this.车牌号DataGridViewTextBoxColumn.Name = "车牌号DataGridViewTextBoxColumn";
            // 
            // 驾驶员编号DataGridViewTextBoxColumn
            // 
            this.驾驶员编号DataGridViewTextBoxColumn.DataPropertyName = "驾驶员编号";
            this.驾驶员编号DataGridViewTextBoxColumn.HeaderText = "驾驶员编号";
            this.驾驶员编号DataGridViewTextBoxColumn.Name = "驾驶员编号DataGridViewTextBoxColumn";
            // 
            // 品牌DataGridViewTextBoxColumn
            // 
            this.品牌DataGridViewTextBoxColumn.DataPropertyName = "品牌";
            this.品牌DataGridViewTextBoxColumn.HeaderText = "品牌";
            this.品牌DataGridViewTextBoxColumn.Name = "品牌DataGridViewTextBoxColumn";
            // 
            // 生产厂家DataGridViewTextBoxColumn
            // 
            this.生产厂家DataGridViewTextBoxColumn.DataPropertyName = "生产厂家";
            this.生产厂家DataGridViewTextBoxColumn.HeaderText = "生产厂家";
            this.生产厂家DataGridViewTextBoxColumn.Name = "生产厂家DataGridViewTextBoxColumn";
            // 
            // 发动机编号DataGridViewTextBoxColumn
            // 
            this.发动机编号DataGridViewTextBoxColumn.DataPropertyName = "发动机编号";
            this.发动机编号DataGridViewTextBoxColumn.HeaderText = "发动机编号";
            this.发动机编号DataGridViewTextBoxColumn.Name = "发动机编号DataGridViewTextBoxColumn";
            // 
            // 车辆类型DataGridViewTextBoxColumn
            // 
            this.车辆类型DataGridViewTextBoxColumn.DataPropertyName = "车辆类型";
            this.车辆类型DataGridViewTextBoxColumn.HeaderText = "车辆类型";
            this.车辆类型DataGridViewTextBoxColumn.Name = "车辆类型DataGridViewTextBoxColumn";
            // 
            // 是否报废DataGridViewTextBoxColumn
            // 
            this.是否报废DataGridViewTextBoxColumn.DataPropertyName = "是否报废";
            this.是否报废DataGridViewTextBoxColumn.HeaderText = "是否报废";
            this.是否报废DataGridViewTextBoxColumn.Name = "是否报废DataGridViewTextBoxColumn";
            // 
            // 车辆档案BindingSource
            // 
            this.车辆档案BindingSource.DataMember = "车辆档案";
            this.车辆档案BindingSource.DataSource = this.carsDataSet;
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "carsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 车辆档案TableAdapter
            // 
            this.车辆档案TableAdapter.ClearBeforeFill = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(272, 367);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(101, 32);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "打印预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // psDlg
            // 
            this.psDlg.Document = this.printDoc;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // ppDlg
            // 
            this.ppDlg.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDlg.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDlg.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDlg.Document = this.printDoc;
            this.ppDlg.Enabled = true;
            this.ppDlg.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDlg.Icon")));
            this.ppDlg.Name = "ppDlg";
            this.ppDlg.Visible = false;
            // 
            // btnPageSet
            // 
            this.btnPageSet.Location = new System.Drawing.Point(272, 331);
            this.btnPageSet.Name = "btnPageSet";
            this.btnPageSet.Size = new System.Drawing.Size(101, 30);
            this.btnPageSet.TabIndex = 1;
            this.btnPageSet.Text = "页面设置";
            this.btnPageSet.UseVisualStyleBackColor = true;
            this.btnPageSet.Click += new System.EventHandler(this.btnPageSet_Click);
            // 
            // lstbPrinters
            // 
            this.lstbPrinters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbPrinters.FormattingEnabled = true;
            this.lstbPrinters.ItemHeight = 12;
            this.lstbPrinters.Location = new System.Drawing.Point(72, 325);
            this.lstbPrinters.Name = "lstbPrinters";
            this.lstbPrinters.Size = new System.Drawing.Size(194, 74);
            this.lstbPrinters.TabIndex = 2;
            // 
            // 打印机列表
            // 
            this.打印机列表.AutoSize = true;
            this.打印机列表.Location = new System.Drawing.Point(1, 349);
            this.打印机列表.Name = "打印机列表";
            this.打印机列表.Size = new System.Drawing.Size(65, 12);
            this.打印机列表.TabIndex = 3;
            this.打印机列表.Text = "打印机列表";
            // 
            // ptDlg
            // 
            this.ptDlg.AllowSomePages = true;
            this.ptDlg.ShowHelp = true;
            this.ptDlg.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(379, 329);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 68);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 399);
            this.Controls.Add(this.打印机列表);
            this.Controls.Add(this.lstbPrinters);
            this.Controls.Add(this.btnPageSet);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.车辆档案BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private carsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource 车辆档案BindingSource;
        private carsDataSetTableAdapters.车辆档案TableAdapter 车辆档案TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 驾驶员编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产厂家DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发动机编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆类型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否报废DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PageSetupDialog psDlg;
        private System.Windows.Forms.PrintPreviewDialog ppDlg;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.Button btnPageSet;
        private System.Windows.Forms.ListBox lstbPrinters;
        private System.Windows.Forms.Label 打印机列表;
        private System.Windows.Forms.PrintDialog ptDlg;
        private System.Windows.Forms.Button btnPrint;
    }
}

