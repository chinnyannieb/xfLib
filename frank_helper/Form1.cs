using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using xf;

namespace assistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbDesktop.Text = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Desktop", "未找到键值");
            txtbDoc.Text = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Personal", "未找到键值");
            txtbStore.Text = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Favorites", "未找到键值");
            string osVersion = Environment.OSVersion.VersionString;
            MessageBox.Show(osVersion);
        }

        #region  更新notepad

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblInfo.Text = String.Empty;
            try
            {
                File.Delete(@"C:\WINDOWS\system32\dllcache\notepad.exe");
                File.Copy(@"notepad 2.exe", @"C:\WINDOWS\system32\notepad.exe", true);
                File.Copy(@"notepad 2.exe", @"C:\WINDOWS\notepad.exe", true);
            }
            catch (Exception ex)
            { lblInfo.Text = ex.Message + "替换出错，请关闭杀毒软件再重试"; }
            lblInfo.Text = "替换成功";
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            lblInfo.Text = String.Empty;
            try
            {
                File.Copy(@"xp自带NOTEPAD.EXE", @"C:\WINDOWS\system32\dllcache\notepad.exe", true);
                File.Copy(@"xp自带NOTEPAD.EXE", @"C:\WINDOWS\system32\notepad.exe", true);
                File.Copy(@"xp自带NOTEPAD.EXE", @"C:\WINDOWS\notepad.exe", true);
            }
            catch (Exception ex)
            { lblInfo.Text = "替换出错，请关闭杀毒软件再重试"; }
            lblInfo.Text = "替换成功";
        }

        private void llblNotepad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.flos-freeware.ch/notepad2.html");
        }

        private void llblMod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://sourceforge.net/projects/notepad2/");
        }

        private void llblMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://hi.baidu.com/网安石/home");
        }

        #endregion

        #region 修改用户常用文件夹

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            if (fbdlg1.ShowDialog() == DialogResult.OK)
                txtbDesktop.Text = fbdlg1.SelectedPath;
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (fbdlg1.ShowDialog() == DialogResult.OK)
            {
                txtbDoc.Text = fbdlg1.SelectedPath;
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            if (fbdlg1.ShowDialog() == DialogResult.OK)
                txtbStore.Text = fbdlg1.SelectedPath;
        }

        private bool setReg()
        {

            if (!Directory.Exists(@txtbDesktop.Text))
                Directory.CreateDirectory(@txtbDesktop.Text);
            if (!Directory.Exists(@txtbDoc.Text))
                Directory.CreateDirectory(@txtbDoc.Text);
            if (!Directory.Exists(@txtbStore.Text))
                Directory.CreateDirectory(@txtbStore.Text);//三个文件夹都存在,再尝试操作
            try
            {
                //桌面
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Desktop", txtbDesktop.Text);
                //我的文档
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Personal", txtbDoc.Text);
                //my music
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "My Music", txtbDoc.Text + "\\My Music");
                //my picture
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "My Pictures", txtbDoc.Text + "\\My Pictures");
                //我的收藏
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Favorites", txtbStore.Text);

                foreach (Process proc in Process.GetProcessesByName("explorer"))
                {
                    if (!proc.CloseMainWindow())
                        proc.Kill();
                }
                Process.Start("explorer");
            }

            catch (Exception e)
            {
                MessageBox.Show("出错信息" + e.Message);
                return false;//操作失败返回false
            }
            return true;//操作成功返回true
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (setReg() == true)
                lblState.Text = "设置成功";
            lblState.Text = "设置失败";
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (setReg() == true)
            {
                //迁移文件,Directory.Move方法无法跨分区
                string Desktop = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Desktop", "未找到键值");
                string Doc = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Personal", "未找到键值");
                string Store = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders", "Favorites", "未找到键值");
                xf.xfFile.dirMove(@Desktop, @txtbDesktop.Text);
                xf.xfFile.dirMove(@Doc, @txtbDoc.Text);
                xf.xfFile.dirMove(@Store, @txtbStore.Text);
                lblState.Text = "设置成功";
            }
            else
            {
                lblState.Text = "设置失败";
                return;
            }
        }

        #endregion
    }
}
