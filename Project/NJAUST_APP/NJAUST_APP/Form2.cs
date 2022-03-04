using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NJAUST_APP
{
    public partial class Form2 : Form
    {
        public Form2(string User_name)
        {
            InitializeComponent();
            Start(User_name);
        }
        private void Start(string _name)
        {
            HelloLabel.Text = _name;
            tname.Text = "真实姓名：";
            name.Text = "用户名：";
            college.Text = "学院：";
            pnum.Text = "电话号码：";
            place.Text = "学习场所：";
            field.Text = "擅长领域：";
            gender.Text = "性别；";
            age.Text = "年龄：";
            tvalue.Text = "师傅潜力值：";
            svalue.Text = "学徒潜力值；";
            entrust.Text = "完成的委托：";
            learn.Text = "完成的学习：";
        }

        private void CheckINFO_Click(object sender, EventArgs e)
        {
            string u_name = HelloLabel.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from USER_Table,COLLEGE_Table,FIELD_Table,PLACE_Table where UName='" + u_name + "' and USER_Table.UCid=COLLEGE_Table.COid and USER_Table.UFid=FIELD_Table.Fid and USER_Table.UPid=PLACE_Table.Pid";
            SqlDataReader sr = com.ExecuteReader();
            //修改label
            if(sr.Read()&&sr.HasRows)
            {
                tname.Text = "真实姓名：";
                name.Text = "用户名：";
                college.Text = "学院：";
                pnum.Text = "电话号码：";
                place.Text = "学习场所：";
                field.Text = "擅长领域：";
                gender.Text = "性别；";
                age.Text = "年龄：";
                tvalue.Text = "师傅潜力值：";
                svalue.Text = "学徒潜力值；";
                entrust.Text = "完成的委托：";
                learn.Text = "完成的学习：";

                tname.Text += sr["UTname"].ToString().Trim();
                name.Text += sr["UName"].ToString().Trim();
                name.Text += "    注册编号: ";
                name.Text += sr["UNo"].ToString();
                name.Text += "号";
                college.Text += sr["COName"].ToString().Trim();
                pnum.Text += sr["UPnum"].ToString().Trim();
                place.Text += sr["PName"].ToString().Trim();
                field.Text += sr["FName"].ToString().Trim();
                if ((bool)sr["UGender"])
                    gender.Text += "男";
                else
                    gender.Text += "女";
                age.Text += sr["UAge"].ToString();
                tvalue.Text += sr["UTvalue"].ToString();
                svalue.Text += sr["USvalue"].ToString();
                entrust.Text += sr["UEntrust"].ToString();
                learn.Text += sr["ULearn"].ToString();
            }
            sr.Close();
            con.Close();
        }

        private void ModifyINFO_Click(object sender, EventArgs e)
        {
            Form2_1 form = new Form2_1((string)HelloLabel.Text);
            form.ShowDialog();
        }

        private void List_Click(object sender, EventArgs e)
        {
            Form2_2 form = new Form2_2();
            form.ShowDialog();
        }

        private void Question_Click(object sender, EventArgs e)
        {
            Form2_3 form = new Form2_3(HelloLabel.Text);
            form.ShowDialog();
        }

        private void OUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Dispose();//释放所有资源
        }

        private void MyLearn_Click(object sender, EventArgs e)
        {
            Form2_4 form = new Form2_4(HelloLabel.Text);
            form.ShowDialog();
        }

        private void MyTeacher_Click(object sender, EventArgs e)
        {
            Form2_5 form = new Form2_5(HelloLabel.Text);
            form.ShowDialog();
        }

        private void MyStudent_Click(object sender, EventArgs e)
        {
            Form2_6 form = new Form2_6(HelloLabel.Text);
            form.ShowDialog();
        }
    }
}
