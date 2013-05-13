using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace uc
{
    public partial class ucChooseDate : UserControl
    {
        public ucChooseDate()
        {
            InitializeComponent();
        }

        private void txtbYear_MouseLeave(object sender, EventArgs e)
        {
            if (txtbYear.Text == String.Empty)
                return;
            if (Int32.Parse(txtbYear.Text) <= 1990 || Int32.Parse(txtbYear.Text) >= 2020)
            {
                MessageBox.Show("请输入1990—2020之间的一个合法数值");
                txtbYear.Text = "";
                return;
            }
        }
    }
}
