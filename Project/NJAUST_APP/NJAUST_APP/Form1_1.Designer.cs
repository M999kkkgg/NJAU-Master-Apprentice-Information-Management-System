namespace NJAUST_APP
{
    partial class Form1_1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.Sure_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("楷体", 22F);
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "忘记密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(52, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "手机号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(52, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(52, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "新密码：";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("宋体", 15F);
            this.Phone.Location = new System.Drawing.Point(170, 59);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(280, 36);
            this.Phone.TabIndex = 4;
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("宋体", 15F);
            this.User.Location = new System.Drawing.Point(170, 120);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(280, 36);
            this.User.TabIndex = 5;
            // 
            // Code
            // 
            this.Code.Font = new System.Drawing.Font("宋体", 15F);
            this.Code.Location = new System.Drawing.Point(170, 179);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(280, 36);
            this.Code.TabIndex = 6;
            // 
            // Sure_Button
            // 
            this.Sure_Button.Font = new System.Drawing.Font("宋体", 15F);
            this.Sure_Button.Location = new System.Drawing.Point(57, 253);
            this.Sure_Button.Name = "Sure_Button";
            this.Sure_Button.Size = new System.Drawing.Size(181, 57);
            this.Sure_Button.TabIndex = 7;
            this.Sure_Button.Text = "确定";
            this.Sure_Button.UseVisualStyleBackColor = true;
            this.Sure_Button.Click += new System.EventHandler(this.Sure_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "密码为六位数字";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(269, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Sure_Button);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1_1";
            this.Text = "Form1_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button Sure_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}