using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Text;
using xf;

namespace crazyDict
{
    public partial class mainForm : Form
    {
        bool isFirstClick = true;

        /// <summary>
        /// 程序主窗口的各个方法
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
        }

        #region 主操作界面的方法
        private void mainForm_Load(object sender, EventArgs e)
        {
            cbbStart.Text = "1";
            cbbEnd.Text = "3";
            toolTip1.SetToolTip(this.gpbCoreStrCombine, "当采用B方法时，生成核心字符串集和常见弱口令\n\r的组合文本。弱口令存放在commonDict\\easy.txt。\n\r可以修改easy.txt，但不能更改路径或文件名，否则出错。");
            rbtnDelHead.Checked = true;
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            if (ucDstPath.Text == "")
            {
                MessageBox.Show("目标文件夹不存在！");
                return;
            }
            switch (tabCtrl.SelectedTab.Text)
            {
                case "字符穷举": charsModeMake(); break;
                case "核心字符串": coreStrMake(); break;
                case "生日模式": birthdayMake(); break;
                case "字典编辑": dictEditMake(); break;
                case "字典组合": dictCombineMake(); break;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            switch (tabCtrl.SelectedTab.Text)
            {
                case "字符穷举": charsModePreview(); break;
                case "核心字符串": coreStrPreview(); break;
                case "生日模式": birthdayPreview(); break;
                case "字典组合": combinePreview(); break;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", ucDstPath.Directory);
        }
        #endregion

        #region 字符模式TabPage内的方法
        //字符模式下"生成"的方法
        private void charsModeMake()
        {
            CharsMode mydict = new CharsMode(chkbLsmall.Checked, chkbLbig.Checked, chkbNumber.Checked, chkbHyphen.Checked,
            txtbSelf.Text, Int32.Parse(cbbStart.Text), Int32.Parse(cbbEnd.Text));
            if (isFirstClick == true)
            {
                if (mydict.dictRows() > 100000)  //如果生成量过大，则进行提示
                {
                    charsModePreview();
                    MessageBox.Show("字典文件较大，生成耗时，请在预览区查看体积，如需生成，再次点击“生成”");
                    isFirstClick = false;
                    return;
                }
                else
                {
                    mydict.writeFile();
                    string tmpPath = ucDstPath.Text;
                    File.Copy(@"c:\result.txt", tmpPath, true);
                    lblMsg.Visible = true;
                }
            }
            else
            {
                mydict.writeFile();
                string tmpPath = ucDstPath.Text;
                File.Copy(@"c:\result.txt", tmpPath, true);
                lblMsg.Visible = true;
                isFirstClick = true;
            }
        }

        //字符模式下预览的方法
        private void charsModePreview()
        {
            CharsMode mydict = new CharsMode(chkbLsmall.Checked, chkbLbig.Checked, chkbNumber.Checked, chkbHyphen.Checked,
            txtbSelf.Text, Int32.Parse(cbbStart.Text), Int32.Parse(cbbEnd.Text));
            txtbStrNum.Text = mydict.dictRows().ToString();
            txtbFileSize.Text = mydict.fileSize();
        }

        private void cbbStart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbStart.Text != "" && cbbEnd.Text != "")
                if (int.Parse(cbbStart.Text) >= int.Parse(cbbEnd.Text))
                {
                    lblCharsModeError.Text = "起始长度不能大于结束长度，请修改";
                    lblCharsModeError.Visible = true;
                    cbbStart.Text = "";
                }
                else
                {
                    lblCharsModeError.Visible = false;
                }
        }

        private void cbbEnd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbStart.Text != "" && cbbEnd.Text != "")
                if (int.Parse(cbbStart.Text) >= int.Parse(cbbEnd.Text))
                {
                    lblCharsModeError.Text = "起始长度不能大于结束长度，请修改";
                    lblCharsModeError.Visible = true;
                    cbbEnd.Text = "";
                }
                else
                {
                    lblCharsModeError.Visible = false;
                }
        }
        #endregion

        #region 核心字符串TabPage内的方法
        private void btnInput_Click(object sender, EventArgs e)
        {
            ofDlg.InitialDirectory = xf.xfSysInfo.getDesktopPath();
            ofDlg.Filter = "文本文件|*.txt|所有文件|*.*";
            if (ofDlg.ShowDialog() == DialogResult.OK)
            {
                if (xf.xfText.isAsciiFile(ofDlg.FileName) == true)
                {
                    StreamReader sr = new StreamReader(ofDlg.FileName);
                    rtbCore.Text = sr.ReadToEnd();
                    sr.Close();
                    lblCore.Text = "输入核心字符串，每行一个，不支持中文";
                    lblCore.ForeColor = Parent.ForeColor;
                }
                else
                {
                    lblCore.Text = "文件里有不支持的非ASCII字符，请重试";
                    lblCore.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void btnCoreStrClean_Click(object sender, EventArgs e)
        {
            rtbCore.Text = String.Empty;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            sfDlg.InitialDirectory = xf.xfSysInfo.getDesktopPath();
            ofDlg.Filter = "文本文件|*.txt|全部文件|*.*";
            ofDlg.FileName = "核心字符串字典.txt";
            if (sfDlg.ShowDialog() == DialogResult.OK)
            {
                string tmpName = sfDlg.FileName;
                if (tmpName.IndexOf(".") != -1)
                {
                    StreamWriter sw = File.CreateText(tmpName);
                    sw.Write(rtbCore.Text);
                    sw.Flush();
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = File.CreateText(tmpName + ".txt");
                    sw.Write(rtbCore.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private void coreStrMake()
        {
            rtbCoreCHK();
            string[] coreStrArray = rtbCore.Lines;
            string[] commonStrArray = File.ReadAllLines(@"commonDict\easy.txt");
            string[] resultArray = null;
            string destPath = ucDstPath.Text;
            if (rbtnCoreStrSelf.Checked)     //这三个if必定会选择一个
            {
                resultArray = xf.xfStrArray.strArrayDescartes(coreStrArray, coreStrArray);
                File.WriteAllLines(destPath, resultArray);
            }
            if (rbtnCoreStrEasy.Checked)
            {
                resultArray = xf.xfStrArray.strArrayDescartes(coreStrArray, commonStrArray);
                File.WriteAllLines(destPath, resultArray);
            }
            if (rbtnCoreStrX.Checked)       //对前两项的字符串数组进行一个组合即可
            {
                resultArray = xf.xfStrArray.strArrayAdd(
 (xf.xfStrArray.strArrayDescartes(coreStrArray, commonStrArray)),
 (xf.xfStrArray.strArrayDescartes(coreStrArray, coreStrArray))
 );
                File.WriteAllLines(destPath, resultArray);
            }
        }

        private void rtbCoreCHK()
        {
            if (rtbCore.Text == String.Empty)
            {
                lblCore.Text = "核心字符串不能为空";
                lblCore.ForeColor = System.Drawing.Color.Red;
                return;
            }
        }

        private string[] coreStrSelf()
        {
            string[] coreStrs = File.ReadAllLines(@"C:\tmp.txt");
            return xf.xfStrArray.strArrayDescartes(coreStrs, coreStrs);
        }

        private string[] coreStrMix()
        {
            string[] coreStrs = File.ReadAllLines(@"C:\tmp.txt");
            string[] easyStrs = File.ReadAllLines("easyDict.txt");
            return xf.xfStrArray.strArrayDescartes(coreStrs, easyStrs);
        }

        /// <summary>
        /// 根据用户的选择扩展核心字符串集
        /// </summary>
        /// <returns>核心字符串集的string</returns>
        private string resultCoreStr()
        {
            string coreStr = rtbCore.Text;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(coreStr);
            if (chkbToUpper.Checked)
                sb.AppendLine(coreStr.ToUpper());
            if (chkbToLower.Checked)
                sb.AppendLine(coreStr.ToLower());
            if (chkbReverse.Checked)
                sb.AppendLine(xf.xfText.strCaseChange(coreStr));
            return sb.ToString();
        }

        private void coreStrPreview()
        {
            rtbCoreCHK();
            int originalLength = rtbCore.Lines.Length;
            if (chkbToLower.Checked)
                originalLength += originalLength;
            if (chkbToUpper.Checked)
                originalLength += originalLength;
            if (chkbReverse.Checked)
                originalLength += originalLength;
            int easyDictLength = xf.xfText.numOfRows(@"commonDict\easy.txt");
            int resultNum = 0;
            if (rbtnCoreStrSelf.Checked)
                resultNum = originalLength * originalLength * 2;
            if (rbtnCoreStrEasy.Checked)
                resultNum = originalLength * easyDictLength * 2;
            if (rbtnCoreStrX.Checked)
                resultNum = originalLength * originalLength * 2 + originalLength * easyDictLength * 2;
            this.txtbStrNum.Text = resultNum.ToString();
            //TODO：此处不再计算总字符数和文件体积
        }
        #endregion

        #region 生日模式TabPage内的方法

        private void birthdayMake()
        {
            if (dtpEnd.Value <= dtpStart.Value)
            {
                lblBirthMsg.Visible = true;
                return;
            }
            DateTime dtStart = dtpStart.Value;
            DateTime dtEnd = dtpEnd.Value;
            DateTime dtTmp = dtStart;
            StreamWriter sw = new StreamWriter(ucDstPath.Text);
            while (dtTmp < dtEnd)
            {
                int index = lstbDate.SelectedIndex;
                switch (index)
                {
                    case 0: sw.WriteLine(dtTmp.ToString("yyyy年MM月dd日")); break;
                    case 1: sw.WriteLine(dtTmp.ToString("yyyy年M月d日")); break;
                    case 2: sw.WriteLine(dtTmp.ToString("yyyyMMdd")); break;
                    case 3: sw.WriteLine(dtTmp.ToString("yyyy.MM.dd")); break;
                    case 4: sw.WriteLine(dtTmp.ToString("yyyy.M.d")); break;
                    case 5: sw.WriteLine(dtTmp.ToString("yyyy-MM-dd")); break;
                    case 6: sw.WriteLine(dtTmp.ToString("yyyy-M-d")); break;
                }
                dtTmp = dtTmp.AddDays(1);
            }
            sw.Flush();
            sw.Close();
        }

        private void birthdayPreview()
        {
            if (dtpEnd.Value <= dtpStart.Value)
            {
                lblBirthMsg.Visible = true;
                return;
            }
            TimeSpan ts = dtpEnd.Value - dtpStart.Value;
            txtbStrNum.Text = ts.Days.ToString();
            txtbFileSize.Text = xf.xfText.sizeOfChars(ts.Days * 15);
        }

        #endregion

        #region 字典编辑TabPage内的方法
        private void dictEditMake()
        {
            if (ucFODictEdit.Text == "")
                return;
            switch (tabControlEdit.SelectedTab.Text)
            {
                case "逐行插入": editInsertMake(); break;
                case "逐行删除": editDelMake(); break;
                case "替换": editReplaceMake(); break;
                case "排序": editSortMake(); break;
            }
        }

        /// <summary>
        /// 处理编辑TabPage页的插入操作
        /// </summary>
        private void editInsertMake()
        {
            //三个位置的字符串均为空则提示
            if (txtbInsertStr.Text == "" && txtbInsertHead.Text == "" && txtbInsertTail.Text == "")
            {
                MessageBox.Show("请填写需要插入的字符串");
                return;
            }
            int insertPoint = (txtbInsertNum.Text != "") ? int.Parse(txtbInsertNum.Text) : 0;
            string sourcePath = ucFODictEdit.Text;
            string destPath = ucDstPath.Text;
            StreamReader sr = new StreamReader(sourcePath);
            StreamWriter sw = new StreamWriter(destPath);
            StringBuilder sb = new StringBuilder();
            string tmp = "";      //此字符串存储不带新头和新尾的字符串
            for (int i = 0; i < xf.xfText.numOfRows(sourcePath); i++)
            {
                tmp = sr.ReadLine();
                if (txtbInsertNum.Text != "" && txtbInsertStr.Text != "")//有中间插入的情况
                {
                    if (insertPoint > tmp.Length)
                    {
                        tmp = tmp + txtbInsertStr.Text;
                    }
                    else
                    {
                        string front = tmp.Substring(0, insertPoint - 1);
                        string behind = tmp.Substring(insertPoint - 1, tmp.Length - front.Length);
                        tmp = front + txtbInsertStr.Text + behind;
                    }
                }
                sb.Append(txtbInsertHead.Text);
                sb.Append(tmp);
                sb.Append(txtbInsertTail.Text);
                sw.WriteLine(sb.ToString());
                sb.Remove(0, sb.Length);         //清空此SB，用以接受下一行
            }
            sr.Close();
            sw.Flush();
            sw.Close();
        }

        /// <summary>
        /// 处理编辑TabPage的删除操作
        /// </summary>
        private void editDelMake()
        {
            string sourcePath = ucFODictEdit.Text;
            string destPath = ucDstPath.Text;
            StreamReader sr = new StreamReader(sourcePath);
            StreamWriter sw = new StreamWriter(destPath);
            string tmp = "";
            int rowCount = xf.xfText.numOfRows(sourcePath);

            if (rbtnDelHead.Checked)
            {
                if (txtbEditDelHeadCount.Text == String.Empty)
                {
                    MessageBox.Show("请输入删除长度"); return;
                }
                int cutHead = Int32.Parse(txtbEditDelHeadCount.Text);
                for (int i = 0; i < rowCount; i++)
                {
                    tmp = sr.ReadLine();
                    if (tmp == String.Empty)
                    {
                        continue;
                    }
                    if (cutHead > tmp.Length)
                        tmp = "";
                    else
                        tmp = tmp.Substring(cutHead);
                    sw.WriteLine(tmp);
                }
            }
            if (rbtnDelTail.Checked)
            {
                if (txtbEditDelTailCount.Text == String.Empty)
                {
                    MessageBox.Show("请输入删除长度"); return;
                }
                int cutTail = Int32.Parse(txtbEditDelTailCount.Text);
                for (int i = 0; i < rowCount; i++)
                {
                    tmp = sr.ReadLine();
                    if (tmp == String.Empty)
                    {
                        continue;
                    }
                    if (cutTail > tmp.Length)
                        tmp = "";
                    else
                        tmp = tmp.Substring(0, tmp.Length - cutTail);
                    sw.WriteLine(tmp);
                }
            }
            if (rbtnDelMid.Checked)
            {
                if (txtbEditDelMidStartPoint.Text == String.Empty || txtbEditDelMidLength.Text == String.Empty)
                {
                    MessageBox.Show("删除开始位置和删除长度必须都输入"); return;
                }
                int delStartPoint, delLength;
                delStartPoint = (txtbEditDelMidStartPoint.Text != "") ? Int32.Parse(txtbEditDelMidStartPoint.Text) : 0;
                delLength = (txtbEditDelMidLength.Text != "") ? Int32.Parse(txtbEditDelMidLength.Text) : 0;

                for (int i = 0; i < rowCount; i++)
                {
                    tmp = sr.ReadLine();
                    if (tmp == String.Empty)
                    {
                        continue;
                    }
                    //开始删除点在字符串之内则删除，否则不删
                    if (delStartPoint < tmp.Length)
                    {
                        string headString = tmp.Substring(0, delStartPoint - 1);
                        string rearString = tmp.Substring(delStartPoint - 1);
                        string newRearString = "";
                        if (rearString.Length > delLength)
                        {
                            newRearString = rearString.Substring(delLength - 1);
                        }
                        tmp = headString + newRearString;
                    }
                    sw.WriteLine(tmp);
                }
            }
            sr.Close();
            sw.Flush();
            sw.Close();
            lblMsg.Text = "编辑完毕！";
        }

        private void editReplaceMake()
        {
            if (rbtnToLower.Checked)
            {
                string tmp = File.ReadAllText(ucFODictEdit.Text);
                tmp = tmp.ToLower();
                File.WriteAllText(ucDstPath.Text, tmp);
            }
            if (rbtnToUpper.Checked)
            {
                string tmp = File.ReadAllText(ucFODictEdit.Text);
                tmp = tmp.ToUpper();
                File.WriteAllText(ucDstPath.Text, tmp);
            }
            if (rbtnReverse.Checked)
            {
                string tmp = File.ReadAllText(ucFODictEdit.Text);
                tmp = xf.xfText.strCaseChange(tmp);
                File.WriteAllText(ucDstPath.Text, tmp);
            }
            if (rbtnFirstToUpper.Checked)
            {
                string[] strArray = File.ReadAllLines(ucFODictEdit.Text);
                string[] result = strArray;
                for (int i = 0; i < strArray.Length; i++)
                {
                    result[i] = xf.xfText.firstLetterToUpper(strArray[i]);
                }
                File.WriteAllLines(ucDstPath.Text, result);
            }
        }

        private void editSortMake()
        {
            if (rbtnSortABC.Checked)
            {
                xf.xfText.fileSort(ucFODictEdit.Text, ucDstPath.Text, true);
            }
            else
            {
                xf.xfText.fileSort(ucFODictEdit.Text, ucDstPath.Text, false);
            }
        }
        #endregion

        #region 字典组合TabPage内的方法
        private void dictCombineMake()
        {
            if (ucFOCombineA.Text == "" || ucFOCombineB.Text == "")
            {
                MessageBox.Show("请先选择操作的文件");
                return;
            }
            else
            {
                string[] strArrayA = File.ReadAllLines(ucFOCombineA.Text);
                string[] strArrayB = File.ReadAllLines(ucFOCombineB.Text);
                string destPath = ucDstPath.Text;
                string[] result = null;
                if (rbtnDescartes.Checked)
                {
                    result = xf.xfStrArray.strArrayDescartes(strArrayA, strArrayB);
                }
                if (rbtnCombineBoth.Checked)
                {
                    result = xf.xfStrArray.strArrayBoth(strArrayA, strArrayB);
                }
                if (rbtnCombineDiff.Checked)
                {
                    string[] total = xf.xfStrArray.strArrayTotal(strArrayA, strArrayB);
                    string[] both = xf.xfStrArray.strArrayBoth(strArrayA, strArrayB);
                    result = xf.xfStrArray.strArraySub(total, both);
                }
                if (rbtnCombineTotal.Checked)
                {
                    result = xf.xfStrArray.strArrayTotal(strArrayA, strArrayB);
                }
                if (rbtnAsubB.Checked)
                {
                    result = xf.xfStrArray.strArraySub(strArrayA, strArrayB);
                }
                if (rbtnBsubA.Checked)
                {
                    result = xf.xfStrArray.strArraySub(strArrayB, strArrayA);
                }
                File.WriteAllLines(destPath, result);
            }
        }

        private void combinePreview()
        {
            /*
            if (ucFOCombineA.Text == "" || ucFOCombineB.Text == "")
            {
                MessageBox.Show("请先选择操作的文件");
                return;
            }
            else
            {
                string[] strArrayA = File.ReadAllLines(ucFOCombineA.Text);
                string[] strArrayB = File.ReadAllLines(ucFOCombineB.Text);
                if (rbtnDescartes.Checked)
                {

                }
                if (rbtnCombineBoth.Checked)
                {

                }
                if (rbtnCombineDiff.Checked)
                {

                }
                if (rbtnCombineTotal.Checked)
                {

                }
                if (rbtnAsubB.Checked)
                {

                }
                if (rbtnBsubA.Checked)
                {

                }
            }
             */
        }
        #endregion


        private void CancelNonDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tpDictEdit_Enter(object sender, EventArgs e)
        {
            this.gpbPreview.Visible = false;
        }

        private void tpDictEdit_Leave(object sender, EventArgs e)
        {
            this.gpbPreview.Visible = true;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.Show();
        }

        private void BlogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", @"http://hi.baidu.com/%CD%F8%B0%B2%CA%AF");
        }
    }
}