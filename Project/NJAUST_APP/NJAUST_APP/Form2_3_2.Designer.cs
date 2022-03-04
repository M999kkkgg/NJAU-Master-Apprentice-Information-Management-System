namespace NJAUST_APP
{
    partial class Form2_3_2
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
            this.NAME = new System.Windows.Forms.Label();
            this.YES = new System.Windows.Forms.Button();
            this.Solved = new System.Windows.Forms.Label();
            this.Unsolved = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListView3 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.z = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 22F);
            this.label1.Location = new System.Drawing.Point(610, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "发布的问题总览";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NAME.Location = new System.Drawing.Point(17, 61);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(64, 25);
            this.NAME.TabIndex = 2;
            this.NAME.Text = "用户";
            // 
            // YES
            // 
            this.YES.BackColor = System.Drawing.SystemColors.ControlLight;
            this.YES.Font = new System.Drawing.Font("宋体", 15F);
            this.YES.Location = new System.Drawing.Point(1096, 617);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(135, 64);
            this.YES.TabIndex = 3;
            this.YES.Text = "确定";
            this.YES.UseVisualStyleBackColor = false;
            this.YES.Click += new System.EventHandler(this.YES_Click);
            // 
            // Solved
            // 
            this.Solved.AutoSize = true;
            this.Solved.Font = new System.Drawing.Font("宋体", 15F);
            this.Solved.Location = new System.Drawing.Point(12, 100);
            this.Solved.Name = "Solved";
            this.Solved.Size = new System.Drawing.Size(187, 25);
            this.Solved.TabIndex = 4;
            this.Solved.Text = "已经解决的问题";
            // 
            // Unsolved
            // 
            this.Unsolved.AutoSize = true;
            this.Unsolved.Font = new System.Drawing.Font("宋体", 15F);
            this.Unsolved.Location = new System.Drawing.Point(12, 269);
            this.Unsolved.Name = "Unsolved";
            this.Unsolved.Size = new System.Drawing.Size(187, 25);
            this.Unsolved.TabIndex = 5;
            this.Unsolved.Text = "没有解决的问题";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListView1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(22, 132);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(1209, 134);
            this.ListView1.TabIndex = 6;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "时间";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 339;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "领域";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "描述";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 453;
            // 
            // ListView2
            // 
            this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ListView2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView2.GridLines = true;
            this.ListView2.Location = new System.Drawing.Point(22, 297);
            this.ListView2.Name = "ListView2";
            this.ListView2.Size = new System.Drawing.Size(1209, 134);
            this.ListView2.TabIndex = 7;
            this.ListView2.UseCompatibleStateImageBehavior = false;
            this.ListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "序号";
            this.columnHeader5.Width = 67;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "时间";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 338;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "领域";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 122;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "描述";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 451;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(22, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(1176, 108);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(55, 15);
            this.x.TabIndex = 9;
            this.x.Text = "label3";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(1176, 277);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(55, 15);
            this.y.TabIndex = 10;
            this.y.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(119, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "发布的问题";
            // 
            // ListView3
            // 
            this.ListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader13,
            this.columnHeader15,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14});
            this.ListView3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView3.GridLines = true;
            this.ListView3.Location = new System.Drawing.Point(22, 466);
            this.ListView3.Name = "ListView3";
            this.ListView3.Size = new System.Drawing.Size(1209, 134);
            this.ListView3.TabIndex = 12;
            this.ListView3.UseCompatibleStateImageBehavior = false;
            this.ListView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "序号";
            this.columnHeader9.Width = 67;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "用户";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 131;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "联系方式";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 214;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "时间";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 181;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "领域";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 97;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "描述";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 342;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "是否解决";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 153;
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Location = new System.Drawing.Point(986, 446);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(55, 15);
            this.z.TabIndex = 13;
            this.z.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(17, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "所有用户发布的问题";
            // 
            // Form2_3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 693);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.z);
            this.Controls.Add(this.ListView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListView2);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.Unsolved);
            this.Controls.Add(this.Solved);
            this.Controls.Add(this.YES);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label1);
            this.Name = "Form2_3_2";
            this.Text = "Form2_3_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Button YES;
        private System.Windows.Forms.Label Solved;
        private System.Windows.Forms.Label Unsolved;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView ListView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListView3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Label label4;
    }
}