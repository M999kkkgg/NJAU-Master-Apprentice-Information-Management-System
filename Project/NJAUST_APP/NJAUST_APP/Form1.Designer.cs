namespace NJAUST_APP
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_Box = new System.Windows.Forms.TextBox();
            this.Pass_Box = new System.Windows.Forms.TextBox();
            this.Log_Butten = new System.Windows.Forms.Button();
            this.Regist_Butten = new System.Windows.Forms.Button();
            this.ForgetPass_Butten = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(83, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(83, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // User_Box
            // 
            this.User_Box.Font = new System.Drawing.Font("宋体", 15F);
            this.User_Box.Location = new System.Drawing.Point(217, 62);
            this.User_Box.Name = "User_Box";
            this.User_Box.Size = new System.Drawing.Size(323, 36);
            this.User_Box.TabIndex = 2;
            // 
            // Pass_Box
            // 
            this.Pass_Box.Font = new System.Drawing.Font("宋体", 15F);
            this.Pass_Box.Location = new System.Drawing.Point(217, 118);
            this.Pass_Box.MaxLength = 6;
            this.Pass_Box.Name = "Pass_Box";
            this.Pass_Box.PasswordChar = '*';
            this.Pass_Box.Size = new System.Drawing.Size(323, 36);
            this.Pass_Box.TabIndex = 3;
            // 
            // Log_Butten
            // 
            this.Log_Butten.Font = new System.Drawing.Font("宋体", 15F);
            this.Log_Butten.Location = new System.Drawing.Point(88, 189);
            this.Log_Butten.Name = "Log_Butten";
            this.Log_Butten.Size = new System.Drawing.Size(103, 38);
            this.Log_Butten.TabIndex = 4;
            this.Log_Butten.Text = "登录";
            this.Log_Butten.UseVisualStyleBackColor = true;
            this.Log_Butten.Click += new System.EventHandler(this.Log_Butten_Click);
            // 
            // Regist_Butten
            // 
            this.Regist_Butten.Font = new System.Drawing.Font("宋体", 15F);
            this.Regist_Butten.Location = new System.Drawing.Point(437, 189);
            this.Regist_Butten.Name = "Regist_Butten";
            this.Regist_Butten.Size = new System.Drawing.Size(103, 38);
            this.Regist_Butten.TabIndex = 5;
            this.Regist_Butten.Text = "注册";
            this.Regist_Butten.UseVisualStyleBackColor = true;
            this.Regist_Butten.Click += new System.EventHandler(this.Regist_Butten_Click);
            // 
            // ForgetPass_Butten
            // 
            this.ForgetPass_Butten.Font = new System.Drawing.Font("宋体", 15F);
            this.ForgetPass_Butten.Location = new System.Drawing.Point(242, 189);
            this.ForgetPass_Butten.Name = "ForgetPass_Butten";
            this.ForgetPass_Butten.Size = new System.Drawing.Size(147, 38);
            this.ForgetPass_Butten.TabIndex = 6;
            this.ForgetPass_Butten.Text = "忘记密码";
            this.ForgetPass_Butten.UseVisualStyleBackColor = true;
            this.ForgetPass_Butten.Click += new System.EventHandler(this.ForgetPass_Butten_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("楷体", 22F);
            this.label3.Location = new System.Drawing.Point(189, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "用户登录界面";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(88, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "管理员入口";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(437, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 308);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ForgetPass_Butten);
            this.Controls.Add(this.Regist_Butten);
            this.Controls.Add(this.Log_Butten);
            this.Controls.Add(this.Pass_Box);
            this.Controls.Add(this.User_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_Box;
        private System.Windows.Forms.TextBox Pass_Box;
        private System.Windows.Forms.Button Log_Butten;
        private System.Windows.Forms.Button Regist_Butten;
        private System.Windows.Forms.Button ForgetPass_Butten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

