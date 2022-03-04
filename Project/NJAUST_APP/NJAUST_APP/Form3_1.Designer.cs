namespace NJAUST_APP
{
    partial class Form3_1
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
            this.ADMNAME = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FLASH = new System.Windows.Forms.Button();
            this.OUt = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.num = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 22F);
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "查看登录日志";
            // 
            // ADMNAME
            // 
            this.ADMNAME.AutoSize = true;
            this.ADMNAME.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ADMNAME.Location = new System.Drawing.Point(12, 48);
            this.ADMNAME.Name = "ADMNAME";
            this.ADMNAME.Size = new System.Drawing.Size(64, 25);
            this.ADMNAME.TabIndex = 4;
            this.ADMNAME.Text = "NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前管理员";
            // 
            // FLASH
            // 
            this.FLASH.Font = new System.Drawing.Font("宋体", 15F);
            this.FLASH.Location = new System.Drawing.Point(17, 394);
            this.FLASH.Name = "FLASH";
            this.FLASH.Size = new System.Drawing.Size(136, 55);
            this.FLASH.TabIndex = 5;
            this.FLASH.Text = "刷新";
            this.FLASH.UseVisualStyleBackColor = true;
            this.FLASH.Click += new System.EventHandler(this.FLASH_Click);
            // 
            // OUt
            // 
            this.OUt.Font = new System.Drawing.Font("宋体", 15F);
            this.OUt.Location = new System.Drawing.Point(861, 394);
            this.OUt.Name = "OUt";
            this.OUt.Size = new System.Drawing.Size(136, 55);
            this.OUt.TabIndex = 6;
            this.OUt.Text = "退出";
            this.OUt.UseVisualStyleBackColor = true;
            this.OUt.Click += new System.EventHandler(this.OUt_Click);
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListView1.Font = new System.Drawing.Font("宋体", 15F);
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(17, 86);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(980, 298);
            this.ListView1.TabIndex = 7;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(942, 56);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(55, 15);
            this.num.TabIndex = 8;
            this.num.Text = "label3";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "登录时间";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 380;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "账户名";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 256;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "属性";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 131;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "是否允许";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 127;
            // 
            // Form3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 461);
            this.Controls.Add(this.num);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.OUt);
            this.Controls.Add(this.FLASH);
            this.Controls.Add(this.ADMNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3_1";
            this.Text = "Form3_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ADMNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FLASH;
        private System.Windows.Forms.Button OUt;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}