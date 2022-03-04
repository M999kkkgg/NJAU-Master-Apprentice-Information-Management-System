namespace NJAUST_APP
{
    partial class Form3
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
            this.ADMNAME = new System.Windows.Forms.Label();
            this.OUT = new System.Windows.Forms.Button();
            this.DELETELOG = new System.Windows.Forms.Button();
            this.LOOKLOG = new System.Windows.Forms.Button();
            this.ADDADM = new System.Windows.Forms.Button();
            this.FIELD = new System.Windows.Forms.Button();
            this.COLLEGE = new System.Windows.Forms.Button();
            this.PLACE = new System.Windows.Forms.Button();
            this.CHANGE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 22F);
            this.label1.Location = new System.Drawing.Point(243, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员界面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前管理员";
            // 
            // ADMNAME
            // 
            this.ADMNAME.AutoSize = true;
            this.ADMNAME.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ADMNAME.Location = new System.Drawing.Point(12, 42);
            this.ADMNAME.Name = "ADMNAME";
            this.ADMNAME.Size = new System.Drawing.Size(64, 25);
            this.ADMNAME.TabIndex = 2;
            this.ADMNAME.Text = "NULL";
            // 
            // OUT
            // 
            this.OUT.Font = new System.Drawing.Font("宋体", 15F);
            this.OUT.Location = new System.Drawing.Point(370, 370);
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(188, 69);
            this.OUT.TabIndex = 3;
            this.OUT.Text = "退出登录";
            this.OUT.UseVisualStyleBackColor = true;
            this.OUT.Click += new System.EventHandler(this.OUT_Click);
            // 
            // DELETELOG
            // 
            this.DELETELOG.Font = new System.Drawing.Font("宋体", 15F);
            this.DELETELOG.Location = new System.Drawing.Point(125, 192);
            this.DELETELOG.Name = "DELETELOG";
            this.DELETELOG.Size = new System.Drawing.Size(188, 69);
            this.DELETELOG.TabIndex = 4;
            this.DELETELOG.Text = "清空登录日志";
            this.DELETELOG.UseVisualStyleBackColor = true;
            this.DELETELOG.Click += new System.EventHandler(this.DELETELOG_Click);
            // 
            // LOOKLOG
            // 
            this.LOOKLOG.Font = new System.Drawing.Font("宋体", 15F);
            this.LOOKLOG.Location = new System.Drawing.Point(125, 101);
            this.LOOKLOG.Name = "LOOKLOG";
            this.LOOKLOG.Size = new System.Drawing.Size(188, 69);
            this.LOOKLOG.TabIndex = 5;
            this.LOOKLOG.Text = "查看登录日志";
            this.LOOKLOG.UseVisualStyleBackColor = true;
            this.LOOKLOG.Click += new System.EventHandler(this.LOOKLOG_Click);
            // 
            // ADDADM
            // 
            this.ADDADM.Font = new System.Drawing.Font("宋体", 15F);
            this.ADDADM.Location = new System.Drawing.Point(125, 279);
            this.ADDADM.Name = "ADDADM";
            this.ADDADM.Size = new System.Drawing.Size(188, 69);
            this.ADDADM.TabIndex = 6;
            this.ADDADM.Text = "添加新管理员";
            this.ADDADM.UseVisualStyleBackColor = true;
            this.ADDADM.Click += new System.EventHandler(this.ADDADM_Click);
            // 
            // FIELD
            // 
            this.FIELD.Font = new System.Drawing.Font("宋体", 15F);
            this.FIELD.Location = new System.Drawing.Point(370, 101);
            this.FIELD.Name = "FIELD";
            this.FIELD.Size = new System.Drawing.Size(188, 69);
            this.FIELD.TabIndex = 7;
            this.FIELD.Text = "查看全部领域";
            this.FIELD.UseVisualStyleBackColor = true;
            this.FIELD.Click += new System.EventHandler(this.FIELD_Click);
            // 
            // COLLEGE
            // 
            this.COLLEGE.Font = new System.Drawing.Font("宋体", 15F);
            this.COLLEGE.Location = new System.Drawing.Point(370, 192);
            this.COLLEGE.Name = "COLLEGE";
            this.COLLEGE.Size = new System.Drawing.Size(188, 69);
            this.COLLEGE.TabIndex = 8;
            this.COLLEGE.Text = "查看全部学院";
            this.COLLEGE.UseVisualStyleBackColor = true;
            this.COLLEGE.Click += new System.EventHandler(this.COLLEGE_Click);
            // 
            // PLACE
            // 
            this.PLACE.Font = new System.Drawing.Font("宋体", 15F);
            this.PLACE.Location = new System.Drawing.Point(370, 279);
            this.PLACE.Name = "PLACE";
            this.PLACE.Size = new System.Drawing.Size(188, 69);
            this.PLACE.TabIndex = 9;
            this.PLACE.Text = "查看学习场所";
            this.PLACE.UseVisualStyleBackColor = true;
            this.PLACE.Click += new System.EventHandler(this.PLACE_Click);
            // 
            // CHANGE
            // 
            this.CHANGE.Font = new System.Drawing.Font("宋体", 15F);
            this.CHANGE.Location = new System.Drawing.Point(125, 370);
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.Size = new System.Drawing.Size(188, 69);
            this.CHANGE.TabIndex = 10;
            this.CHANGE.Text = "修改用户状态";
            this.CHANGE.UseVisualStyleBackColor = true;
            this.CHANGE.Click += new System.EventHandler(this.CHANGE_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 459);
            this.Controls.Add(this.CHANGE);
            this.Controls.Add(this.PLACE);
            this.Controls.Add(this.COLLEGE);
            this.Controls.Add(this.FIELD);
            this.Controls.Add(this.ADDADM);
            this.Controls.Add(this.LOOKLOG);
            this.Controls.Add(this.DELETELOG);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.ADMNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ADMNAME;
        private System.Windows.Forms.Button OUT;
        private System.Windows.Forms.Button DELETELOG;
        private System.Windows.Forms.Button LOOKLOG;
        private System.Windows.Forms.Button ADDADM;
        private System.Windows.Forms.Button FIELD;
        private System.Windows.Forms.Button COLLEGE;
        private System.Windows.Forms.Button PLACE;
        private System.Windows.Forms.Button CHANGE;
    }
}