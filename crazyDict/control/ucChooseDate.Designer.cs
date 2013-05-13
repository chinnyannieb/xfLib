namespace uc
{
    partial class ucChooseDate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtbYear = new System.Windows.Forms.TextBox();
            this.txtbMonth = new System.Windows.Forms.TextBox();
            this.txtbDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(78, 9);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(17, 12);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "年";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(160, 9);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "月";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(239, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(17, 12);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "日";
            // 
            // txtbYear
            // 
            this.txtbYear.Location = new System.Drawing.Point(11, 5);
            this.txtbYear.Name = "txtbYear";
            this.txtbYear.Size = new System.Drawing.Size(57, 21);
            this.txtbYear.TabIndex = 1;
            this.txtbYear.MouseLeave += new System.EventHandler(this.txtbYear_MouseLeave);
            // 
            // txtbMonth
            // 
            this.txtbMonth.Location = new System.Drawing.Point(103, 5);
            this.txtbMonth.Name = "txtbMonth";
            this.txtbMonth.Size = new System.Drawing.Size(48, 21);
            this.txtbMonth.TabIndex = 1;
            // 
            // txtbDay
            // 
            this.txtbDay.Location = new System.Drawing.Point(184, 5);
            this.txtbDay.Name = "txtbDay";
            this.txtbDay.Size = new System.Drawing.Size(43, 21);
            this.txtbDay.TabIndex = 1;
            // 
            // ucChooseDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbDay);
            this.Controls.Add(this.txtbMonth);
            this.Controls.Add(this.txtbYear);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Name = "ucChooseDate";
            this.Size = new System.Drawing.Size(266, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtbYear;
        private System.Windows.Forms.TextBox txtbMonth;
        private System.Windows.Forms.TextBox txtbDay;
    }
}
