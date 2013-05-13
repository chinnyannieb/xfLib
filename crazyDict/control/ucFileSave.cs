using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace uc
{
    public partial class ucFileSave : UserControl
    {
        public ucFileSave()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (fbdlgChoose.ShowDialog() == DialogResult.OK)
            { txtbPath.Text = fbdlgChoose.SelectedPath; }
        }

        public override string Text
        { 
            get { return txtbPath.Text + txtbFilename.Text; }
        }

        public string Directory
        { 
            get { return txtbPath.Text; } 
        }
    }
}
