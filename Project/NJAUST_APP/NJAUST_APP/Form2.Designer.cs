namespace NJAUST_APP
{
    partial class Form2
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
            this.HelloLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckINFO = new System.Windows.Forms.Button();
            this.ModifyINFO = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Button();
            this.MyLearn = new System.Windows.Forms.Button();
            this.MyTeacher = new System.Windows.Forms.Button();
            this.MyStudent = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.tname = new System.Windows.Forms.Label();
            this.svalue = new System.Windows.Forms.Label();
            this.tvalue = new System.Windows.Forms.Label();
            this.learn = new System.Windows.Forms.Label();
            this.entrust = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.Label();
            this.pnum = new System.Windows.Forms.Label();
            this.college = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.OUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("隶书", 30F);
            this.label1.Location = new System.Drawing.Point(387, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "南农师徒系统";
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.BackColor = System.Drawing.SystemColors.Control;
            this.HelloLabel.Font = new System.Drawing.Font("宋体", 25F);
            this.HelloLabel.Location = new System.Drawing.Point(155, 16);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(144, 42);
            this.HelloLabel.TabIndex = 2;
            this.HelloLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "欢迎你！";
            // 
            // CheckINFO
            // 
            this.CheckINFO.Font = new System.Drawing.Font("宋体", 15F);
            this.CheckINFO.Location = new System.Drawing.Point(33, 88);
            this.CheckINFO.Name = "CheckINFO";
            this.CheckINFO.Size = new System.Drawing.Size(212, 79);
            this.CheckINFO.TabIndex = 4;
            this.CheckINFO.Text = "查看个人信息";
            this.CheckINFO.UseVisualStyleBackColor = true;
            this.CheckINFO.Click += new System.EventHandler(this.CheckINFO_Click);
            // 
            // ModifyINFO
            // 
            this.ModifyINFO.Font = new System.Drawing.Font("宋体", 15F);
            this.ModifyINFO.Location = new System.Drawing.Point(33, 343);
            this.ModifyINFO.Name = "ModifyINFO";
            this.ModifyINFO.Size = new System.Drawing.Size(212, 79);
            this.ModifyINFO.TabIndex = 5;
            this.ModifyINFO.Text = "修改个人信息";
            this.ModifyINFO.UseVisualStyleBackColor = true;
            this.ModifyINFO.Click += new System.EventHandler(this.ModifyINFO_Click);
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("宋体", 15F);
            this.Question.Location = new System.Drawing.Point(33, 258);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(212, 79);
            this.Question.TabIndex = 6;
            this.Question.Text = "师生交互";
            this.Question.UseVisualStyleBackColor = true;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // MyLearn
            // 
            this.MyLearn.Font = new System.Drawing.Font("宋体", 15F);
            this.MyLearn.Location = new System.Drawing.Point(782, 12);
            this.MyLearn.Name = "MyLearn";
            this.MyLearn.Size = new System.Drawing.Size(297, 79);
            this.MyLearn.TabIndex = 7;
            this.MyLearn.Text = "查看个人学习记录";
            this.MyLearn.UseVisualStyleBackColor = true;
            this.MyLearn.Click += new System.EventHandler(this.MyLearn_Click);
            // 
            // MyTeacher
            // 
            this.MyTeacher.Font = new System.Drawing.Font("宋体", 15F);
            this.MyTeacher.Location = new System.Drawing.Point(782, 97);
            this.MyTeacher.Name = "MyTeacher";
            this.MyTeacher.Size = new System.Drawing.Size(297, 79);
            this.MyTeacher.TabIndex = 8;
            this.MyTeacher.Text = "查看个人拜师记录";
            this.MyTeacher.UseVisualStyleBackColor = true;
            this.MyTeacher.Click += new System.EventHandler(this.MyTeacher_Click);
            // 
            // MyStudent
            // 
            this.MyStudent.Font = new System.Drawing.Font("宋体", 15F);
            this.MyStudent.Location = new System.Drawing.Point(782, 182);
            this.MyStudent.Name = "MyStudent";
            this.MyStudent.Size = new System.Drawing.Size(297, 79);
            this.MyStudent.TabIndex = 9;
            this.MyStudent.Text = "查看个人收徒记录";
            this.MyStudent.UseVisualStyleBackColor = true;
            this.MyStudent.Click += new System.EventHandler(this.MyStudent_Click);
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("宋体", 15F);
            this.List.Location = new System.Drawing.Point(33, 173);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(212, 79);
            this.List.TabIndex = 10;
            this.List.Text = "排行榜";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // tname
            // 
            this.tname.AutoSize = true;
            this.tname.Font = new System.Drawing.Font("宋体", 15F);
            this.tname.Location = new System.Drawing.Point(311, 142);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(90, 25);
            this.tname.TabIndex = 11;
            this.tname.Text = "label3";
            // 
            // svalue
            // 
            this.svalue.AutoSize = true;
            this.svalue.Font = new System.Drawing.Font("宋体", 15F);
            this.svalue.Location = new System.Drawing.Point(777, 359);
            this.svalue.Name = "svalue";
            this.svalue.Size = new System.Drawing.Size(90, 25);
            this.svalue.TabIndex = 12;
            this.svalue.Text = "label3";
            // 
            // tvalue
            // 
            this.tvalue.AutoSize = true;
            this.tvalue.Font = new System.Drawing.Font("宋体", 15F);
            this.tvalue.Location = new System.Drawing.Point(777, 305);
            this.tvalue.Name = "tvalue";
            this.tvalue.Size = new System.Drawing.Size(90, 25);
            this.tvalue.TabIndex = 13;
            this.tvalue.Text = "label3";
            // 
            // learn
            // 
            this.learn.AutoSize = true;
            this.learn.Font = new System.Drawing.Font("宋体", 15F);
            this.learn.Location = new System.Drawing.Point(777, 476);
            this.learn.Name = "learn";
            this.learn.Size = new System.Drawing.Size(90, 25);
            this.learn.TabIndex = 14;
            this.learn.Text = "label3";
            // 
            // entrust
            // 
            this.entrust.AutoSize = true;
            this.entrust.Font = new System.Drawing.Font("宋体", 15F);
            this.entrust.Location = new System.Drawing.Point(777, 422);
            this.entrust.Name = "entrust";
            this.entrust.Size = new System.Drawing.Size(90, 25);
            this.entrust.TabIndex = 15;
            this.entrust.Text = "label3";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("宋体", 15F);
            this.age.Location = new System.Drawing.Point(311, 476);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(90, 25);
            this.age.TabIndex = 16;
            this.age.Text = "label3";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("宋体", 15F);
            this.gender.Location = new System.Drawing.Point(311, 422);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(90, 25);
            this.gender.TabIndex = 17;
            this.gender.Text = "label3";
            // 
            // field
            // 
            this.field.AutoSize = true;
            this.field.Font = new System.Drawing.Font("宋体", 15F);
            this.field.Location = new System.Drawing.Point(311, 359);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(90, 25);
            this.field.TabIndex = 18;
            this.field.Text = "label3";
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Font = new System.Drawing.Font("宋体", 15F);
            this.place.Location = new System.Drawing.Point(311, 305);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(90, 25);
            this.place.TabIndex = 19;
            this.place.Text = "label3";
            // 
            // pnum
            // 
            this.pnum.AutoSize = true;
            this.pnum.Font = new System.Drawing.Font("宋体", 15F);
            this.pnum.Location = new System.Drawing.Point(311, 256);
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(90, 25);
            this.pnum.TabIndex = 20;
            this.pnum.Text = "label3";
            // 
            // college
            // 
            this.college.AutoSize = true;
            this.college.Font = new System.Drawing.Font("宋体", 15F);
            this.college.Location = new System.Drawing.Point(311, 202);
            this.college.Name = "college";
            this.college.Size = new System.Drawing.Size(90, 25);
            this.college.TabIndex = 21;
            this.college.Text = "label3";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("宋体", 15F);
            this.name.Location = new System.Drawing.Point(311, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(90, 25);
            this.name.TabIndex = 22;
            this.name.Text = "label3";
            // 
            // OUT
            // 
            this.OUT.Font = new System.Drawing.Font("宋体", 15F);
            this.OUT.Location = new System.Drawing.Point(33, 428);
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(212, 79);
            this.OUT.TabIndex = 23;
            this.OUT.Text = "退出系统";
            this.OUT.UseVisualStyleBackColor = true;
            this.OUT.Click += new System.EventHandler(this.OUT_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 524);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.name);
            this.Controls.Add(this.college);
            this.Controls.Add(this.pnum);
            this.Controls.Add(this.place);
            this.Controls.Add(this.field);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.entrust);
            this.Controls.Add(this.learn);
            this.Controls.Add(this.tvalue);
            this.Controls.Add(this.svalue);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.List);
            this.Controls.Add(this.MyStudent);
            this.Controls.Add(this.MyTeacher);
            this.Controls.Add(this.MyLearn);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.ModifyINFO);
            this.Controls.Add(this.CheckINFO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckINFO;
        private System.Windows.Forms.Button ModifyINFO;
        private System.Windows.Forms.Button Question;
        private System.Windows.Forms.Button MyLearn;
        private System.Windows.Forms.Button MyTeacher;
        private System.Windows.Forms.Button MyStudent;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Label tname;
        private System.Windows.Forms.Label svalue;
        private System.Windows.Forms.Label tvalue;
        private System.Windows.Forms.Label learn;
        private System.Windows.Forms.Label entrust;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label field;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Label pnum;
        private System.Windows.Forms.Label college;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button OUT;
    }
}