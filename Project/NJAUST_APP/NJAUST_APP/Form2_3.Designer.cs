namespace NJAUST_APP
{
    partial class Form2_3
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
            this.TITLE = new System.Windows.Forms.Label();
            this.FIND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QUESTION = new System.Windows.Forms.TextBox();
            this.FID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SELECT = new System.Windows.Forms.Button();
            this.Method = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MCollege = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MPlace = new System.Windows.Forms.ComboBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SHOW = new System.Windows.Forms.Button();
            this.APPLY = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.GodNum = new System.Windows.Forms.Label();
            this.NOW_QUESTION = new System.Windows.Forms.Button();
            this.NOW_LEARN = new System.Windows.Forms.Button();
            this.NOW_APPLY = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.Label();
            this.pnum = new System.Windows.Forms.Label();
            this._fname = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.Label();
            this.college = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.tvalue = new System.Windows.Forms.Label();
            this.entrust = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TITLE.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TITLE.Location = new System.Drawing.Point(569, 9);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(169, 38);
            this.TITLE.TabIndex = 0;
            this.TITLE.Text = "师生交互";
            // 
            // FIND
            // 
            this.FIND.Font = new System.Drawing.Font("宋体", 15F);
            this.FIND.Location = new System.Drawing.Point(12, 245);
            this.FIND.Name = "FIND";
            this.FIND.Size = new System.Drawing.Size(130, 73);
            this.FIND.TabIndex = 1;
            this.FIND.Text = "发布问题";
            this.FIND.UseVisualStyleBackColor = true;
            this.FIND.Click += new System.EventHandler(this.FIND_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前用户：";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NAME.Location = new System.Drawing.Point(149, 20);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(64, 25);
            this.NAME.TabIndex = 3;
            this.NAME.Text = "NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "咨询领域：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "问题描述：";
            // 
            // QUESTION
            // 
            this.QUESTION.Font = new System.Drawing.Font("宋体", 15F);
            this.QUESTION.Location = new System.Drawing.Point(155, 115);
            this.QUESTION.MaxLength = 25;
            this.QUESTION.Multiline = true;
            this.QUESTION.Name = "QUESTION";
            this.QUESTION.Size = new System.Drawing.Size(279, 203);
            this.QUESTION.TabIndex = 7;
            // 
            // FID
            // 
            this.FID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FID.Font = new System.Drawing.Font("宋体", 15F);
            this.FID.FormattingEnabled = true;
            this.FID.IntegralHeight = false;
            this.FID.Location = new System.Drawing.Point(155, 73);
            this.FID.Name = "FID";
            this.FID.Size = new System.Drawing.Size(279, 33);
            this.FID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 60);
            this.label4.TabIndex = 9;
            this.label4.Text = "问题描述不能\r\n超过25个字嗷\r\n要简短明确嗷";
            // 
            // SELECT
            // 
            this.SELECT.Font = new System.Drawing.Font("宋体", 15F);
            this.SELECT.Location = new System.Drawing.Point(468, 431);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(164, 78);
            this.SELECT.TabIndex = 10;
            this.SELECT.Text = "筛选";
            this.SELECT.UseVisualStyleBackColor = true;
            this.SELECT.Click += new System.EventHandler(this.SELECT_Click);
            // 
            // Method
            // 
            this.Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Method.Font = new System.Drawing.Font("宋体", 15F);
            this.Method.FormattingEnabled = true;
            this.Method.IntegralHeight = false;
            this.Method.Location = new System.Drawing.Point(205, 335);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(229, 33);
            this.Method.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(12, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "选择筛选方式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(12, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "要筛选的学院";
            // 
            // MCollege
            // 
            this.MCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MCollege.Font = new System.Drawing.Font("宋体", 15F);
            this.MCollege.FormattingEnabled = true;
            this.MCollege.IntegralHeight = false;
            this.MCollege.Location = new System.Drawing.Point(205, 382);
            this.MCollege.Name = "MCollege";
            this.MCollege.Size = new System.Drawing.Size(229, 33);
            this.MCollege.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(12, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "要筛选的场所";
            // 
            // MPlace
            // 
            this.MPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MPlace.Font = new System.Drawing.Font("宋体", 15F);
            this.MPlace.FormattingEnabled = true;
            this.MPlace.IntegralHeight = false;
            this.MPlace.Location = new System.Drawing.Point(205, 431);
            this.MPlace.Name = "MPlace";
            this.MPlace.Size = new System.Drawing.Size(229, 33);
            this.MPlace.TabIndex = 16;
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("宋体", 15F);
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 25;
            this.ListBox.Location = new System.Drawing.Point(468, 89);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(164, 229);
            this.ListBox.TabIndex = 18;
            // 
            // SHOW
            // 
            this.SHOW.Font = new System.Drawing.Font("宋体", 15F);
            this.SHOW.Location = new System.Drawing.Point(468, 335);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(164, 80);
            this.SHOW.TabIndex = 19;
            this.SHOW.Text = "显示信息";
            this.SHOW.UseVisualStyleBackColor = true;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // APPLY
            // 
            this.APPLY.Font = new System.Drawing.Font("宋体", 15F);
            this.APPLY.Location = new System.Drawing.Point(1019, 443);
            this.APPLY.Name = "APPLY";
            this.APPLY.Size = new System.Drawing.Size(255, 66);
            this.APPLY.TabIndex = 21;
            this.APPLY.Text = "发出拜师申请";
            this.APPLY.UseVisualStyleBackColor = true;
            this.APPLY.Click += new System.EventHandler(this.APPLY_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(664, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "搜索到的大神";
            // 
            // GodNum
            // 
            this.GodNum.AutoSize = true;
            this.GodNum.Font = new System.Drawing.Font("楷体", 30F);
            this.GodNum.Location = new System.Drawing.Point(859, 457);
            this.GodNum.Name = "GodNum";
            this.GodNum.Size = new System.Drawing.Size(122, 50);
            this.GodNum.TabIndex = 23;
            this.GodNum.Text = "0 人";
            // 
            // NOW_QUESTION
            // 
            this.NOW_QUESTION.Font = new System.Drawing.Font("宋体", 15F);
            this.NOW_QUESTION.Location = new System.Drawing.Point(1019, 227);
            this.NOW_QUESTION.Name = "NOW_QUESTION";
            this.NOW_QUESTION.Size = new System.Drawing.Size(255, 66);
            this.NOW_QUESTION.TabIndex = 24;
            this.NOW_QUESTION.Text = "已发布的问题";
            this.NOW_QUESTION.UseVisualStyleBackColor = true;
            this.NOW_QUESTION.Click += new System.EventHandler(this.NOW_QUESTION_Click);
            // 
            // NOW_LEARN
            // 
            this.NOW_LEARN.Font = new System.Drawing.Font("宋体", 15F);
            this.NOW_LEARN.Location = new System.Drawing.Point(1019, 299);
            this.NOW_LEARN.Name = "NOW_LEARN";
            this.NOW_LEARN.Size = new System.Drawing.Size(255, 66);
            this.NOW_LEARN.TabIndex = 25;
            this.NOW_LEARN.Text = "当前学习状况";
            this.NOW_LEARN.UseVisualStyleBackColor = true;
            this.NOW_LEARN.Click += new System.EventHandler(this.NOW_LEARN_Click);
            // 
            // NOW_APPLY
            // 
            this.NOW_APPLY.Font = new System.Drawing.Font("宋体", 15F);
            this.NOW_APPLY.Location = new System.Drawing.Point(1019, 371);
            this.NOW_APPLY.Name = "NOW_APPLY";
            this.NOW_APPLY.Size = new System.Drawing.Size(255, 66);
            this.NOW_APPLY.TabIndex = 26;
            this.NOW_APPLY.Text = "当前申请状况";
            this.NOW_APPLY.UseVisualStyleBackColor = true;
            this.NOW_APPLY.Click += new System.EventHandler(this.NOW_APPLY_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F);
            this.label8.Location = new System.Drawing.Point(12, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "要筛选的领域";
            // 
            // FName
            // 
            this.FName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FName.Font = new System.Drawing.Font("宋体", 15F);
            this.FName.FormattingEnabled = true;
            this.FName.IntegralHeight = false;
            this.FName.Location = new System.Drawing.Point(205, 476);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(229, 33);
            this.FName.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F);
            this.label10.Location = new System.Drawing.Point(664, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "真实姓名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15F);
            this.label11.Location = new System.Drawing.Point(1014, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "学院";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15F);
            this.label12.Location = new System.Drawing.Point(664, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "电话";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 15F);
            this.label13.Location = new System.Drawing.Point(1014, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "性别";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 15F);
            this.label14.Location = new System.Drawing.Point(1014, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "年龄";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 15F);
            this.label15.Location = new System.Drawing.Point(664, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 25);
            this.label15.TabIndex = 35;
            this.label15.Text = "擅长领域";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 15F);
            this.label16.Location = new System.Drawing.Point(664, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 25);
            this.label16.TabIndex = 36;
            this.label16.Text = "学习场所";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 15F);
            this.label17.Location = new System.Drawing.Point(664, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 25);
            this.label17.TabIndex = 37;
            this.label17.Text = "完成委托";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 15F);
            this.label18.Location = new System.Drawing.Point(664, 301);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 25);
            this.label18.TabIndex = 38;
            this.label18.Text = "师傅潜力值";
            // 
            // tname
            // 
            this.tname.AutoSize = true;
            this.tname.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tname.Location = new System.Drawing.Point(813, 73);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(64, 25);
            this.tname.TabIndex = 39;
            this.tname.Text = "null";
            // 
            // pnum
            // 
            this.pnum.AutoSize = true;
            this.pnum.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnum.Location = new System.Drawing.Point(755, 118);
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(103, 25);
            this.pnum.TabIndex = 40;
            this.pnum.Text = "label19";
            // 
            // _fname
            // 
            this._fname.AutoSize = true;
            this._fname.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._fname.Location = new System.Drawing.Point(813, 157);
            this._fname.Name = "_fname";
            this._fname.Size = new System.Drawing.Size(103, 25);
            this._fname.TabIndex = 41;
            this._fname.Text = "label19";
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.place.Location = new System.Drawing.Point(813, 208);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(103, 25);
            this.place.TabIndex = 42;
            this.place.Text = "label19";
            // 
            // college
            // 
            this.college.AutoSize = true;
            this.college.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.college.Location = new System.Drawing.Point(1091, 73);
            this.college.Name = "college";
            this.college.Size = new System.Drawing.Size(103, 25);
            this.college.TabIndex = 43;
            this.college.Text = "label19";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gender.Location = new System.Drawing.Point(1091, 118);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(103, 25);
            this.gender.TabIndex = 44;
            this.gender.Text = "label19";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.age.Location = new System.Drawing.Point(1091, 161);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(103, 25);
            this.age.TabIndex = 45;
            this.age.Text = "label19";
            // 
            // tvalue
            // 
            this.tvalue.AutoSize = true;
            this.tvalue.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvalue.Location = new System.Drawing.Point(813, 301);
            this.tvalue.Name = "tvalue";
            this.tvalue.Size = new System.Drawing.Size(103, 25);
            this.tvalue.TabIndex = 46;
            this.tvalue.Text = "label19";
            // 
            // entrust
            // 
            this.entrust.AutoSize = true;
            this.entrust.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.entrust.Location = new System.Drawing.Point(813, 254);
            this.entrust.Name = "entrust";
            this.entrust.Size = new System.Drawing.Size(103, 25);
            this.entrust.TabIndex = 47;
            this.entrust.Text = "label19";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(463, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 25);
            this.label19.TabIndex = 48;
            this.label19.Text = "查询结果";
            // 
            // Form2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 527);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.entrust);
            this.Controls.Add(this.tvalue);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.college);
            this.Controls.Add(this.place);
            this.Controls.Add(this._fname);
            this.Controls.Add(this.pnum);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NOW_APPLY);
            this.Controls.Add(this.NOW_LEARN);
            this.Controls.Add(this.NOW_QUESTION);
            this.Controls.Add(this.GodNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.APPLY);
            this.Controls.Add(this.SHOW);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.MPlace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MCollege);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.SELECT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FID);
            this.Controls.Add(this.QUESTION);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIND);
            this.Controls.Add(this.TITLE);
            this.Name = "Form2_3";
            this.Text = "Form2_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Button FIND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QUESTION;
        private System.Windows.Forms.ComboBox FID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SELECT;
        private System.Windows.Forms.ComboBox Method;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MCollege;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MPlace;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button SHOW;
        private System.Windows.Forms.Button APPLY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GodNum;
        private System.Windows.Forms.Button NOW_QUESTION;
        private System.Windows.Forms.Button NOW_LEARN;
        private System.Windows.Forms.Button NOW_APPLY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label tname;
        private System.Windows.Forms.Label pnum;
        private System.Windows.Forms.Label _fname;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Label college;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label tvalue;
        private System.Windows.Forms.Label entrust;
        private System.Windows.Forms.Label label19;
    }
}