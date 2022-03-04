namespace NJAUST_APP
{
    partial class Form3_2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ADM_Name = new System.Windows.Forms.TextBox();
            this.ADM_Code = new System.Windows.Forms.TextBox();
            this.CREATE = new System.Windows.Forms.Button();
            this.NONE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加管理员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(49, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作的管理员";
            // 
            // ADMNAME
            // 
            this.ADMNAME.AutoSize = true;
            this.ADMNAME.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ADMNAME.Location = new System.Drawing.Point(230, 87);
            this.ADMNAME.Name = "ADMNAME";
            this.ADMNAME.Size = new System.Drawing.Size(168, 25);
            this.ADMNAME.TabIndex = 2;
            this.ADMNAME.Text = "操作的管理员";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(49, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "设置账户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(49, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "设置密码";
            // 
            // ADM_Name
            // 
            this.ADM_Name.Font = new System.Drawing.Font("宋体", 15F);
            this.ADM_Name.Location = new System.Drawing.Point(235, 151);
            this.ADM_Name.MaxLength = 10;
            this.ADM_Name.Name = "ADM_Name";
            this.ADM_Name.Size = new System.Drawing.Size(240, 36);
            this.ADM_Name.TabIndex = 5;
            // 
            // ADM_Code
            // 
            this.ADM_Code.Font = new System.Drawing.Font("宋体", 15F);
            this.ADM_Code.Location = new System.Drawing.Point(235, 221);
            this.ADM_Code.MaxLength = 6;
            this.ADM_Code.Name = "ADM_Code";
            this.ADM_Code.Size = new System.Drawing.Size(240, 36);
            this.ADM_Code.TabIndex = 6;
            // 
            // CREATE
            // 
            this.CREATE.Font = new System.Drawing.Font("宋体", 15F);
            this.CREATE.Location = new System.Drawing.Point(54, 304);
            this.CREATE.Name = "CREATE";
            this.CREATE.Size = new System.Drawing.Size(118, 62);
            this.CREATE.TabIndex = 7;
            this.CREATE.Text = "创建";
            this.CREATE.UseVisualStyleBackColor = true;
            this.CREATE.Click += new System.EventHandler(this.CREATE_Click);
            // 
            // NONE
            // 
            this.NONE.Font = new System.Drawing.Font("宋体", 15F);
            this.NONE.Location = new System.Drawing.Point(357, 304);
            this.NONE.Name = "NONE";
            this.NONE.Size = new System.Drawing.Size(118, 62);
            this.NONE.TabIndex = 8;
            this.NONE.Text = "取消";
            this.NONE.UseVisualStyleBackColor = true;
            this.NONE.Click += new System.EventHandler(this.NONE_Click);
            // 
            // Form3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 387);
            this.Controls.Add(this.NONE);
            this.Controls.Add(this.CREATE);
            this.Controls.Add(this.ADM_Code);
            this.Controls.Add(this.ADM_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ADMNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3_2";
            this.Text = "Form3_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ADMNAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ADM_Name;
        private System.Windows.Forms.TextBox ADM_Code;
        private System.Windows.Forms.Button CREATE;
        private System.Windows.Forms.Button NONE;
    }
}