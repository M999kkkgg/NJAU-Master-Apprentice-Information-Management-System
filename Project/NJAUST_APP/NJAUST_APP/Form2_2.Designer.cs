namespace NJAUST_APP
{
    partial class Form2_2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TITLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(646, 406);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(57, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "最佳老师";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(57, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 67);
            this.button2.TabIndex = 7;
            this.button2.Text = "最为助人";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 15F);
            this.button3.Location = new System.Drawing.Point(57, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 67);
            this.button3.TabIndex = 8;
            this.button3.Text = "最为勤奋";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 15F);
            this.button4.Location = new System.Drawing.Point(57, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 67);
            this.button4.TabIndex = 9;
            this.button4.Text = "最佳学徒";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 15F);
            this.button5.Location = new System.Drawing.Point(57, 449);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 67);
            this.button5.TabIndex = 10;
            this.button5.Text = "高频问题";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.UNAME,
            this.NUM});
            this.ListView.Font = new System.Drawing.Font("宋体", 13F);
            this.ListView.GridLines = true;
            this.ListView.Location = new System.Drawing.Point(252, 98);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(425, 418);
            this.ListView.TabIndex = 15;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // no
            // 
            this.no.Text = "排序";
            this.no.Width = 50;
            // 
            // UNAME
            // 
            this.UNAME.Text = "用户名或领域";
            this.UNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UNAME.Width = 250;
            // 
            // NUM
            // 
            this.NUM.Text = "对应数值";
            this.NUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUM.Width = 100;
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TITLE.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TITLE.Location = new System.Drawing.Point(301, 25);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(131, 38);
            this.TITLE.TabIndex = 16;
            this.TITLE.Text = "排行榜";
            // 
            // Form2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 552);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2_2";
            this.Text = "Form2_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader UNAME;
        private System.Windows.Forms.ColumnHeader NUM;
        private System.Windows.Forms.Label TITLE;
    }
}