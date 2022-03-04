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
    public partial class Form1_2 : Form
    {
        public Form1_2()
        {
            InitializeComponent();
            My_Conbobox();
        }
        //检验字符串是否全为数字，是返回1，不是返回0
        bool Code(string x)
        {
            try
            {
                long var1 = Convert.ToInt64(x);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //初始化下拉列表
        public void My_Conbobox()
        {
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //设置性别下拉列表
            UGender.Items.Add("男");
            UGender.Items.Add("女");
            //设置学院下拉列表
            com.CommandText = "select COName from COLLEGE_Table order by COid";
            SqlDataReader rd = com.ExecuteReader();
            while(rd.Read())
            {
                UCollege.Items.Add((string)rd["COName"]);
            }
            rd.Close();
            //设置擅长领域下拉表
            com.CommandText = "select FName from FIELD_Table order by Fid";
            rd = com.ExecuteReader();
            while(rd.Read())
            {
                UFid.Items.Add((string)rd["FName"]);
            }
            rd.Close();
            //设置常去学习场所下拉框
            com.CommandText = "select PName from PLACE_Table order by Pid";
            rd = com.ExecuteReader();
            while(rd.Read())
            {
                UPid.Items.Add((string)rd["PName"]);
            }
            rd.Close();
            con.Close();
        }
        private void SURE_Click(object sender, EventArgs e)
        {
            //检验用户输入合法性
            if(UName.TextLength>9||UName.Text==String.Empty)
            {
                MessageBox.Show("用户名不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UName.Clear();
                return;
            }
            if(UCode.TextLength!=6||UCode.Text==String.Empty||!Code(UCode.Text))
            {
                MessageBox.Show("密码不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UCode.Clear();
                return;
            }
            if(UTName.TextLength>9||UTName.Text==String.Empty)
            {
                MessageBox.Show("真实姓名不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UTName.Clear();
                return;
            }
            if(UAge.Text==String.Empty||!Code(UAge.Text))
            {
                MessageBox.Show("年龄不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UAge.Clear();
                return;
            }
            int x= Convert.ToInt32(UAge.Text);
            if(!(x>0&&x<150))
            {
                MessageBox.Show("年龄不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UAge.Clear();
                return;
            }
            if(!Code(UPnum.Text)||UPnum.TextLength!=11)
            {
                MessageBox.Show("电话号码不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UPnum.Clear();
                return;
            }
            if(UGender.Text==String.Empty)
            {
                MessageBox.Show("性别不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (UCollege.Text == String.Empty)
            {
                MessageBox.Show("学院不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (UFid.Text == String.Empty)
            {
                MessageBox.Show("擅长领域不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (UPid.Text == String.Empty)
            {
                MessageBox.Show("常去学习场所不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //根据Box设置各个字段的值
            string name = UName.Text.Trim();   string code = UCode.Text;
            string tname = UTName.Text; string gender="null";
            if (UGender.Text == "男")
                gender = "1";
            else if (UGender.Text == "女")
                gender = "0";
            string age = (string)UAge.Text;
            string pnum = (string)UPnum.Text;
            string cid = "null";    string pid = "null";    string fid = "null";
            //Cid
            com.CommandText = "select * from COLLEGE_Table";
            SqlDataReader rd = com.ExecuteReader();
            while(rd.Read())
            {
                if ((string)rd["COName"] == UCollege.Text)
                    cid = rd["COid"].ToString();
            }
            rd.Close();
            //Pid
            com.CommandText = "select * from PLACE_Table";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                if ((string)rd["PName"] == UPid.Text)
                    pid = (string)rd["Pid"].ToString();
            }
            rd.Close();
            //Fid
            com.CommandText = "select * from FIELD_Table";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                if ((string)rd["FName"] == UFid.Text)
                    fid = (string)rd["Fid"].ToString() ;
            }
            rd.Close();
            //检索是否已经存在同一用户名
            com.CommandText = "select * from USER_Table where UName='" + name + "'";
            rd = com.ExecuteReader();
            if(rd.HasRows)
            {
                MessageBox.Show("存在相同用户名", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UName.Clear();
                rd.Close();
                con.Close();
                return;
            }
            rd.Close();
            //检索是否已经存在同一电话号
            com.CommandText = "select * from USER_Table where UPnum='" + pnum + "'";
            rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("存在相同电话号", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UPnum.Clear();
                rd.Close();
                con.Close();
                return;
            }
            rd.Close();
            //执行插入语句
            string comstr = "insert into USER_Table (UName,UCode,UTname,UGender,UAge,UPnum,UCid,UFid,UPid) values('" + name + "','" + code + "','" + tname + "','" + gender + "','" + age + "','" + pnum + "','" + cid + "','" + fid + "','" + pid + "')";
            com.CommandText = comstr;
            if(com.ExecuteNonQuery()==1)
            {
                rd.Close();
                con.Close();
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                this.Dispose();//释放所有资源
            }
            else
            {
                MessageBox.Show("创建失败", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                rd.Close();
                con.Close();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
