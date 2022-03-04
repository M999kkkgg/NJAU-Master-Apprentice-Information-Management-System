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
    public partial class Form3_6 : Form
    {
        public Form3_6(string n)
        {
            InitializeComponent();
            Start(n);
        }

        private void Start(string _name)
        {
            ADMNAME.Text = _name;
            num.Text = "0条记录";
        }

        private void OUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLASH_Click(object sender, EventArgs e)
        {
            //清空原有内容
            ListBox1.Items.Clear();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            //查询
            int NO = 0;
            string Uname = "null";
            string UPnum = "null";
            string UCode = "null";
            string UStatus = "null";
            com.CommandText = "select *from USER_Table";
            sr = com.ExecuteReader();
            if(!sr.HasRows)
            {
                MessageBox.Show("没有用户", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                sr.Close();
                con.Close();
                return;
            }
            while(sr.Read())
            {
                NO++;
                Uname = sr["UName"].ToString();
                ListBox1.Items.Add(Uname);
            }
            num.Text = NO.ToString() + "条记录";
            sr.Close();
            con.Close();
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            //检查选择合法性
            if(ListBox1.Items.Count==0)
            {
                MessageBox.Show("列表为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("未选中任何用户", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            //查询
            string Uname = ListBox1.SelectedItem.ToString();
            string UPnum = "null";
            string UCode = "null";
            string UStatus = "null";
            com.CommandText = "select *from USER_Table where UName='" + Uname + "'";
            sr = com.ExecuteReader();
            if (sr.Read())
            {
                UPnum = sr["UPnum"].ToString();
                UCode = sr["UCode"].ToString();
                if ((bool)sr["UStatus"])
                    UStatus = "冻结";
                else
                    UStatus = "自由";
                pnum.Text = UPnum;
                code.Text = UCode;
                status.Text = UStatus;
            }
            sr.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //检查输入合法性
            if (SELECT.Text == String.Empty) 
            {
                MessageBox.Show("请输入用户名", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //清空原有内容
            ListBox1.Items.Clear();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            string Uname = SELECT.Text;
            string UPnum = "null";
            string UCode = "null";
            string UStatus = "null";
            com.CommandText = "select * from USER_Table where UName='" + Uname + "'";
            sr = com.ExecuteReader();
            if(!sr.HasRows)
            {
                MessageBox.Show("不存在该用户", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                sr.Close();
                con.Close();
                return;
            }
            //清空原有内容
            ListBox1.Items.Clear();
            //读取查询结果
            if (sr.Read())
            {
                Uname = sr["UName"].ToString();
                UPnum = sr["UPnum"].ToString();
                UCode = sr["UCode"].ToString();
                if ((bool)sr["UStatus"])
                    UStatus = "冻结";
                else
                    UStatus = "自由";
            }
            //修改listbox与label
            ListBox1.Items.Add(Uname);
            ListBox1.SelectedIndex = 0;
            pnum.Text = UPnum;
            code.Text = UCode;
            status.Text = UStatus;
            num.Text = "1条记录";
            sr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //检查选择合法性
            if (ListBox1.Items.Count == 0)
            {
                MessageBox.Show("列表为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("未选中任何用户", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            string Uname = ListBox1.SelectedItem.ToString();
            com.CommandText = "select * from USER_Table where UName='" + Uname + "'";
            sr = com.ExecuteReader();
            if(sr.Read())
            {
                if(!(bool)sr["UStatus"])
                {
                    MessageBox.Show("该用户已经是自由人了", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    sr.Close();
                    con.Close();
                    return;
                }
            }
            sr.Close();
            com.CommandText = "update USER_Table set UStatus='False' where UName='" + Uname + "'";
            com.ExecuteNonQuery();
            MessageBox.Show("解冻成功", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //检查选择合法性
            if (ListBox1.Items.Count == 0)
            {
                MessageBox.Show("列表为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("未选中任何用户", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            string Uname = ListBox1.SelectedItem.ToString();
            com.CommandText = "select * from USER_Table where UName='" + Uname + "'";
            sr = com.ExecuteReader();
            if (sr.Read())
            {
                if ((bool)sr["UStatus"])
                {
                    MessageBox.Show("该用户已经被冻结了", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    sr.Close();
                    con.Close();
                    return;
                }
            }
            sr.Close();
            com.CommandText = "update USER_Table set UStatus='True' where UName='" + Uname + "'";
            com.ExecuteNonQuery();
            MessageBox.Show("冻结成功", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            con.Close();
        }
    }
}
