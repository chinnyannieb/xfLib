using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace uc
{
    public partial class ucFileOpen : UserControl
    {
        public ucFileOpen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 这是此控件对外提供的属性
        /// </summary>
        public override string Text
        {
            get { return txtbFilePath.Text; }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                txtbFilePath.Text = ofDialog.FileName;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (txtbFilePath.Text == "")
            {
                MessageBox.Show("请先选择文件！");
                return;
            }
            Process.Start(@txtbFilePath.Text);
        }
    }
}
