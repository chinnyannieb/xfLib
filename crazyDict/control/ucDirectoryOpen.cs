using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace uc
{
    public partial class ucDirectoryOpen : UserControl
    {
        public ucDirectoryOpen()
        {
            InitializeComponent();
        }

        private void btnChooseDir_Click(object sender, EventArgs e)
        {
            if (fbDialog.ShowDialog()==DialogResult.OK)
            { 
                txtbDirPath.Text = fbDialog.SelectedPath; 
            }
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            if (txtbDirPath.Text== "")
            { 
                MessageBox.Show("请先选择目录！");
                return;
            }
            Process.Start("explorer.exe", @txtbDirPath.Text);
        }

        public override string Text
        { 
            get { return txtbDirPath.Text; } 
        }
    }
}
