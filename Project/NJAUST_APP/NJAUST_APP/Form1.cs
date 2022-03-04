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
using System.Timers;

namespace NJAUST_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(ForgetPass_Butten, @"如果忘记密码点击此按钮根据注册电话号修改
若均忘记可以联系管理员帮助查询
管理员电话：18863082902");
        }

        private void Log_Butten_Click(object sender, EventArgs e)
        {
            if (User_Box.Text == String.Empty)
            {
                MessageBox.Show("用户名不能为空","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (Pass_Box.Text == String.Empty)
            {
                MessageBox.Show("密码不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from USER_Table where UName='"+User_Box.Text+"'";
            SqlDataReader sr = com.ExecuteReader();
            if(!sr.HasRows)
            {
                User_Box.Clear();
                Pass_Box.Clear();
                MessageBox.Show("不存在该用户", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //读取第一行
            string ucode = "null";
            bool ustatus = false;
            if(sr.Read())
            {
                ucode = sr["UCode"].ToString();
                ustatus = (bool)sr["UStatus"];
            }
            if (ucode == Pass_Box.Text && !ustatus)
            {
                //写入登录记录
                sr.Close();
                string time= DateTime.Now.ToLocalTime().ToString();
                com.CommandText = "insert into SIGNLOG_Table (SLName,SLStatus,SLTime,SLReturn) values('" + User_Box.Text + "','" + "User" + "','" + time + "','"+"Allowed"+"')";
                com.ExecuteNonQuery();
                con.Close();
                //打开用户界面
                this.Hide();
                Form2 form = new Form2((string)User_Box.Text);
                form.ShowDialog();
                this.Dispose();//释放所有资源
            }
            else
            {
                //写入登录记录
                sr.Close();
                string time = DateTime.Now.ToLocalTime().ToString();
                com.CommandText = "insert into SIGNLOG_Table (SLName,SLStatus,SLTime,SLReturn) values('" + User_Box.Text + "','" + "User" + "','" + time + "','" + "Refused" + "')";
                com.ExecuteNonQuery();
                con.Close();
                Pass_Box.Clear();
                if(!ustatus)
                    MessageBox.Show("密码和用户名不匹配", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                    MessageBox.Show("用户被冻结, 请联系管理员\n电话：18863082902", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
        }

        private void ForgetPass_Butten_Click(object sender, EventArgs e)
        {
            Form1_1 form = new Form1_1();
            form.ShowDialog();
        }

        private void Regist_Butten_Click(object sender, EventArgs e)
        {
            Form1_2 form = new Form1_2();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1_3 form = new Form1_3();
            form.ShowDialog();
            this.Dispose();//释放所有资源
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
