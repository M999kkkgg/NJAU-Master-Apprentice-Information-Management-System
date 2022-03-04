namespace NJAUST_APP
{
    partial class Form1_3
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
            this.ADMname = new System.Windows.Forms.TextBox();
            this.ADMcode = new System.Windows.Forms.TextBox();
            this.LOG = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员登录界面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(62, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "管理员名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(62, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "登录密码：";
            // 
            // ADMname
            // 
            this.ADMname.Font = new System.Drawing.Font("宋体", 15F);
            this.ADMname.Location = new System.Drawing.Point(205, 74);
            this.ADMname.Name = "ADMname";
            this.ADMname.Size = new System.Drawing.Size(303, 36);
            this.ADMname.TabIndex = 3;
            // 
            // ADMcode
            // 
            this.ADMcode.Font = new System.Drawing.Font("宋体", 15F);
            this.ADMcode.Location = new System.Drawing.Point(205, 133);
            this.ADMcode.MaxLength = 6;
            this.ADMcode.Name = "ADMcode";
            this.ADMcode.PasswordChar = '*';
            this.ADMcode.Size = new System.Drawing.Size(303, 36);
            this.ADMcode.TabIndex = 4;
            // 
            // LOG
            // 
            this.LOG.Font = new System.Drawing.Font("宋体", 15F);
            this.LOG.Location = new System.Drawing.Point(67, 203);
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(131, 56);
            this.LOG.TabIndex = 5;
            this.LOG.Text = "登录";
            this.LOG.UseVisualStyleBackColor = true;
            this.LOG.Click += new System.EventHandler(this.LOG_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(377, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LOG);
            this.Controls.Add(this.ADMcode);
            this.Controls.Add(this.ADMname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1_3";
            this.Text = "Form1_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ADMname;
        private System.Windows.Forms.TextBox ADMcode;
        private System.Windows.Forms.Button LOG;
        private System.Windows.Forms.Button button1;
    }
}