namespace NJAUST_APP
{
    partial class Form2_5
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
            this.FLASH = new System.Windows.Forms.Button();
            this.OUT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(435, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "拜师记录";
            // 
            // FLASH
            // 
            this.FLASH.Font = new System.Drawing.Font("宋体", 15F);
            this.FLASH.Location = new System.Drawing.Point(12, 348);
            this.FLASH.Name = "FLASH";
            this.FLASH.Size = new System.Drawing.Size(136, 69);
            this.FLASH.TabIndex = 1;
            this.FLASH.Text = "刷新";
            this.FLASH.UseVisualStyleBackColor = true;
            this.FLASH.Click += new System.EventHandler(this.FLASH_Click);
            // 
            // OUT
            // 
            this.OUT.Font = new System.Drawing.Font("宋体", 15F);
            this.OUT.Location = new System.Drawing.Point(866, 348);
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(136, 69);
            this.OUT.TabIndex = 2;
            this.OUT.Text = "退出";
            this.OUT.UseVisualStyleBackColor = true;
            this.OUT.Click += new System.EventHandler(this.OUT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NAME.Location = new System.Drawing.Point(96, 55);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(64, 25);
            this.NAME.TabIndex = 4;
            this.NAME.Text = "用户";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView1.Font = new System.Drawing.Font("宋体", 15F);
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(12, 93);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(990, 236);
            this.ListView1.TabIndex = 5;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "师傅";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "领域";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 230;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(942, 63);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(60, 15);
            this.num.TabIndex = 6;
            this.num.Text = "0条记录";
            // 
            // Form2_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 436);
            this.Controls.Add(this.num);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.FLASH);
            this.Controls.Add(this.label1);
            this.Name = "Form2_5";
            this.Text = "Form2_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FLASH;
        private System.Windows.Forms.Button OUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label num;
    }
}