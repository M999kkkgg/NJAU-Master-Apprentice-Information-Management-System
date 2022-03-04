namespace NJAUST_APP
{
    partial class Form2_4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.YES = new System.Windows.Forms.Button();
            this.FLASH = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.num = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "个人学习记录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("宋体", 15F);
            this.NAME.Location = new System.Drawing.Point(105, 67);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(62, 25);
            this.NAME.TabIndex = 2;
            this.NAME.Text = "用户";
            // 
            // YES
            // 
            this.YES.Font = new System.Drawing.Font("宋体", 15F);
            this.YES.Location = new System.Drawing.Point(1003, 389);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(147, 67);
            this.YES.TabIndex = 3;
            this.YES.Text = "退出";
            this.YES.UseVisualStyleBackColor = true;
            this.YES.Click += new System.EventHandler(this.YES_Click);
            // 
            // FLASH
            // 
            this.FLASH.Font = new System.Drawing.Font("宋体", 15F);
            this.FLASH.Location = new System.Drawing.Point(17, 389);
            this.FLASH.Name = "FLASH";
            this.FLASH.Size = new System.Drawing.Size(147, 67);
            this.FLASH.TabIndex = 4;
            this.FLASH.Text = "刷新";
            this.FLASH.UseVisualStyleBackColor = true;
            this.FLASH.Click += new System.EventHandler(this.FLASH_Click);
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.ListView1.Font = new System.Drawing.Font("宋体", 15F);
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(17, 106);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(1133, 265);
            this.ListView1.TabIndex = 5;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(1095, 75);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(55, 15);
            this.num.TabIndex = 6;
            this.num.Text = "label3";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "老师";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "开始时间";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 270;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "结束时间";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 270;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "领域";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ST评分";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TS评分";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 110;
            // 
            // Form2_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 478);
            this.Controls.Add(this.num);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.FLASH);
            this.Controls.Add(this.YES);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2_4";
            this.Text = "Form2_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Button YES;
        private System.Windows.Forms.Button FLASH;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}