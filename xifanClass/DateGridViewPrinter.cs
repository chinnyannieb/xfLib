using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace xf
{
    public class Printer
    {
        private DataGridView dataview;
        private PrintDocument printDoc;
        //��ӡ��Ч����Ŀ��
        int width;
        int height;
        int columns;
        double Rate;
        bool hasMorePage = false;
        int currRow = 0;
        int rowHeight = 20;
        //��ҳ��
        int totalPageNumber;
        //ÿҳ������
        int rowsPerPage = 20;
        //��ǰ��ӡ��ҳ��
        int currentPageIndex;

        private int PageWidth; //��ӡֽ�Ŀ��
        private int PageHeight; //��ӡֽ�ĸ߶�
        private int LeftMargin; //��Ч��ӡ�������ӡֽ����ߴ�С
        private int TopMargin;//��Ч��ӡ�������ӡֽ�������С
        private int RightMargin;//��Ч��ӡ�������ӡֽ���ұߴ�С
        private int BottomMargin;//��Ч��ӡ�������ӡֽ���±ߴ�С

        int rows;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="dgView">Ҫ��ӡ��DateGridView</param>
        /// <param name="printDoc">PrintDocument���ڻ�ȡ��ӡ��������</param>
        public Printer(DataGridView dgView, PrintDocument printDoc)
        {
            this.dataview = dgView;
            this.printDoc = printDoc;
            currentPageIndex = 0;
            //��ȡ��ӡ���ݵ�����������
            this.rows = dgView.RowCount;
            this.columns = dgView.ColumnCount;
            //�жϴ�ӡ�����Ƿ��Ǻ����ӡ
            if (!printDoc.DefaultPageSettings.Landscape)
            {

                PageWidth = printDoc.DefaultPageSettings.PaperSize.Width;
                PageHeight = printDoc.DefaultPageSettings.PaperSize.Height;
            }
            else
            {
                PageHeight = printDoc.DefaultPageSettings.PaperSize.Width;
                PageWidth = printDoc.DefaultPageSettings.PaperSize.Height;
            }
            LeftMargin = printDoc.DefaultPageSettings.Margins.Left;
            TopMargin = printDoc.DefaultPageSettings.Margins.Top;
            RightMargin = printDoc.DefaultPageSettings.Margins.Right;
            BottomMargin = printDoc.DefaultPageSettings.Margins.Bottom;

            //��Ч��ӡ���Ĵ�С
            height = PageHeight - TopMargin - BottomMargin - 2;
            width = PageWidth - LeftMargin - RightMargin - 2;

            double tempheight = height;
            double tempRowHeight = rowHeight;
            while (true)
            {
                // �ܸ߶�/�иߣ��и�ȡ��λ��Ч���֣�
                string tmpRows = Convert.ToString(tempheight / Math.Round(tempRowHeight, 3));
                int i = tmpRows.IndexOf('.');  // i== -1��ʾδ�ҵ�С����
                double tt = 100;
                if (i != -1)
                {
                    tt = Math.Round(Convert.ToDouble(tmpRows.Substring(tmpRows.IndexOf('.'))), 3);
                }
                if (tt <= 0.01)
                {
                    rowHeight = Convert.ToInt32(tempRowHeight);
                    break;
                }
                else
                {
                    tempRowHeight = tempRowHeight + 0.01;
                }
            }
            rowsPerPage = height / rowHeight;
            if ((rows + 1) <= rowsPerPage)
            {
                rowsPerPage = rows + 1;
                totalPageNumber = 1;
            }
            else
            {
                totalPageNumber = rows / (rowsPerPage - 1);
                if (rows % (rowsPerPage - 1) != 0)
                {
                    totalPageNumber = totalPageNumber + 1;
                }

            }


        }


        /**/
        /// <summary>
        /// ��ʼ����ӡ
        /// </summary>
        private void InitPrint()
        {
            currentPageIndex = currentPageIndex + 1;
            if (currentPageIndex == totalPageNumber)
            {
                hasMorePage = false;
                if (currentPageIndex != 1)
                {
                    rowsPerPage = rows % (rowsPerPage - 1) + 1;
                }
            }
            else
            {
                hasMorePage = true;
            }


        }
        //��ӡͷ
        private void DrawHeader(Graphics g)
        {

            Font font = new Font("����", 12, FontStyle.Bold);
            int temptop = (rowHeight / 2) + TopMargin + 1;
            int templeft = LeftMargin + 1;

            for (int i = 0; i < this.columns; i++)
            {
                string headString = this.dataview.Columns[i].HeaderText;
                float fontHeight = g.MeasureString(headString, font).Height;
                float fontwidth = g.MeasureString(headString, font).Width;
                float temp = temptop - (fontHeight) / 3;
                g.DrawString(headString, font, Brushes.Black, new PointF(templeft, temp));
                templeft = templeft + (int)(this.dataview.Columns[i].Width / Rate) + 1;
            }

        }
        //�����
        private void DrawTable(Graphics g)
        {

            Rectangle border = new Rectangle(LeftMargin, TopMargin, width, (rowsPerPage) * rowHeight);
            g.DrawRectangle(new Pen(Brushes.Black, 2), border);
            for (int i = 1; i < rowsPerPage; i++)
            {
                if (i != 1)
                {
                    g.DrawLine(new Pen(Brushes.Black, 1), new Point(LeftMargin + 1, (rowHeight * i) + TopMargin + 1), new Point(width + LeftMargin, (rowHeight * i) + TopMargin + 1));
                }
                else
                {
                    g.DrawLine(new Pen(Brushes.Black, 2), new Point(LeftMargin + 1, (rowHeight * i) + TopMargin + 1), new Point(width + LeftMargin, (rowHeight * i) + TopMargin + 1));
                }
            }

            //������е��ܿ�Ⱥʹ�ӡֽ����
            Rate = Convert.ToDouble(GetDateViewWidth()) / Convert.ToDouble(width);
            int tempLeft = LeftMargin + 1;
            int endY = (rowsPerPage) * rowHeight + TopMargin;
            for (int i = 1; i < columns; i++)
            {
                tempLeft = tempLeft + 1 + (int)(this.dataview.Columns[i - 1].Width / Rate);
                g.DrawLine(new Pen(Brushes.Black, 1), new Point(tempLeft, TopMargin), new Point(tempLeft, endY));
            }

        }
        /**/
        /// <summary>
        /// ��ȡ��ӡ���е��ܿ��
        /// </summary>
        /// <returns></returns>
        private int GetDateViewWidth()
        {
            int total = 0;
            for (int i = 0; i < this.columns; i++)
            {
                total = total + this.dataview.Columns[i].Width;
            }
            return total;
        }

        //��ӡ������
        private void DrawRows(Graphics g)
        {

            Font font = new Font("����", 12, FontStyle.Regular);
            int temptop = (rowHeight / 2) + TopMargin + 1 + rowHeight;


            for (int i = currRow; i < rowsPerPage + currRow - 1; i++)
            {
                int templeft = LeftMargin + 1;
                for (int j = 0; j < columns; j++)
                {
                    string headString = this.dataview.Rows[i].Cells[j].Value.ToString();
                    float fontHeight = g.MeasureString(headString, font).Height;
                    float fontwidth = g.MeasureString(headString, font).Width;
                    float temp = temptop - (fontHeight) / 3;
                    while (true)
                    {
                        if (fontwidth <= (int)(this.dataview.Columns[j].Width / Rate))
                        {
                            break;
                        }
                        else
                        {
                            headString = headString.Substring(0, headString.Length - 1);
                            fontwidth = g.MeasureString(headString, font).Width;
                        }
                    }
                    g.DrawString(headString, font, Brushes.Black, new PointF(templeft, temp));

                    templeft = templeft + (int)(this.dataview.Columns[j].Width / Rate) + 1;
                }

                temptop = temptop + rowHeight;


            }
            currRow = rowsPerPage + currRow - 1;

        }

        /// <summary>
        /// ��PrintDocument�е�PrintPage�����е���
        /// </summary>
        /// <param name="g">����PrintPage��PrintPageEventArgs�е�Graphics</param>
        /// <returns>�Ƿ��д�ӡҳ �з���true�����򷵻�false</returns>
        public bool Print(Graphics g)
        {
            InitPrint();
            DrawTable(g);
            DrawHeader(g);
            DrawRows(g);

            //��ӡҳ��
            string pagestr = currentPageIndex + " / " + totalPageNumber;
            Font font = new Font("����", 12, FontStyle.Regular);
            g.DrawString(pagestr, font, Brushes.Black, new PointF((PageWidth / 2) - g.MeasureString(pagestr, font).Width, PageHeight - (BottomMargin / 2) - g.MeasureString(pagestr, font).Height));
            //��ӡ��ѯ�Ĺ���������
            string temp = dataview.Tag.ToString() + " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            g.DrawString(temp, font, Brushes.Black, new PointF(PageWidth - 5 - g.MeasureString(temp, font).Width, PageHeight - 5 - g.MeasureString(temp, font).Height));
            return hasMorePage;
        }
    }
}