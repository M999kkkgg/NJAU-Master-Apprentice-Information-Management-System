namespace NJAUST_APP
{
    partial class Form3_4
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
            this.num = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OUt = new System.Windows.Forms.Button();
            this.FLASH = new System.Windows.Forms.Button();
            this.ADMNAME = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(570, 77);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(55, 15);
            this.num.TabIndex = 15;
            this.num.Text = "label3";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView1.Font = new System.Drawing.Font("宋体", 15F);
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(22, 111);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(603, 300);
            this.ListView1.TabIndex = 14;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "代号";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "学院";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 388;
            // 
            // OUt
            // 
            this.OUt.Font = new System.Drawing.Font("宋体", 15F);
            this.OUt.Location = new System.Drawing.Point(489, 431);
            this.OUt.Name = "OUt";
            this.OUt.Size = new System.Drawing.Size(136, 55);
            this.OUt.TabIndex = 13;
            this.OUt.Text = "退出";
            this.OUt.UseVisualStyleBackColor = true;
            this.OUt.Click += new System.EventHandler(this.OUt_Click);
            // 
            // FLASH
            // 
            this.FLASH.Font = new System.Drawing.Font("宋体", 15F);
            this.FLASH.Location = new System.Drawing.Point(22, 431);
            this.FLASH.Name = "FLASH";
            this.FLASH.Size = new System.Drawing.Size(136, 55);
            this.FLASH.TabIndex = 12;
            this.FLASH.Text = "刷新";
            this.FLASH.UseVisualStyleBackColor = true;
            this.FLASH.Click += new System.EventHandler(this.FLASH_Click);
            // 
            // ADMNAME
            // 
            this.ADMNAME.AutoSize = true;
            this.ADMNAME.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ADMNAME.Location = new System.Drawing.Point(184, 67);
            this.ADMNAME.Name = "ADMNAME";
            this.ADMNAME.Size = new System.Drawing.Size(64, 25);
            this.ADMNAME.TabIndex = 11;
            this.ADMNAME.Text = "NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "当前管理员";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 22F);
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "查看学院目录";
            // 
            // Form3_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 517);
            this.Controls.Add(this.num);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.OUt);
            this.Controls.Add(this.FLASH);
            this.Controls.Add(this.ADMNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3_4";
            this.Text = "Form3_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button OUt;
        private System.Windows.Forms.Button FLASH;
        private System.Windows.Forms.Label ADMNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}