using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace testForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“carsDataSet.车辆档案”中。您可以根据需要移动或删除它。
            this.车辆档案TableAdapter.Fill(this.carsDataSet.车辆档案);
            PrintDocument prtdoc = new PrintDocument();
            string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;//获取默认的打印机名

            foreach (string pt in PrinterSettings.InstalledPrinters)
            {
                ///在列表框中列出所有的打印机,
                this.lstbPrinters.Items.Add(pt);
                if (pt == strDefaultPrinter)//把默认打印机设为缺省值
                {
                    this.lstbPrinters.SelectedIndex = this.lstbPrinters.Items.IndexOf(pt);
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ppDlg.Show();
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawRectangle(System.Drawing.Pens.Aquamarine, 20,20,500,500);
        }

        private void btnPageSet_Click(object sender, EventArgs e)
        {
            //先监测打印机是否存在
            psDlg.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDoc.Print();
        }

    }
}
