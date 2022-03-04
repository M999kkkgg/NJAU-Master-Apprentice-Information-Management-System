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
    public partial class Form2_3_4 : Form
    {
        public Form2_3_4(string n)
        {
            InitializeComponent();
            Start(n);
        }

        private bool IsNumberic(string oText)
        {
            try
            {
                int var1 = Convert.ToInt32(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void Start(string x)
        {
            NAME.Text = x;
        }

        private void YES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLASH_Click(object sender, EventArgs e)
        {
            //清空表格内容
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //查询
            com.CommandText = "select *from LEARN_RECORD_Table,FIELD_Table where LRFid=Fid and EndTime is null and LSName='" + NAME.Text + "'";
            rd = com.ExecuteReader();
            while(rd.Read())
            {
                ListBox1.Items.Add(rd["LTName"].ToString());
            }
            rd.Close();
            com.CommandText= "select *from LEARN_RECORD_Table,FIELD_Table where LRFid=Fid and EndTime is null and LTName='" + NAME.Text + "'";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                ListBox2.Items.Add(rd["LSName"].ToString());
            }
            rd.Close();
            con.Close();
        }

        private void SHOW1_Click(object sender, EventArgs e)
        {
            //检查数据合法性，不合法则拒绝显示
            if (ListBox1.Items.Count == 0)
            {
                MessageBox.Show("好像表里没有数据呢", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要查看的老师，亲", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //查询
            com.CommandText = "select *from LEARN_RECORD_Table,FIELD_Table where LRFid=Fid and EndTime is null and LTName='" + ListBox1.SelectedItem.ToString() + "' and LSName='" + NAME.Text + "'";
            rd = com.ExecuteReader();
            if (rd.Read())
            {
                L1.Text = rd["StartTime"].ToString();
                L2.Text = rd["FName"].ToString();
            }
            rd.Close();
            con.Close();
        }

        private void SHOW2_Click(object sender, EventArgs e)
        {
            //检查数据合法性，不合法则拒绝显示
            if (ListBox2.Items.Count == 0)
            {
                MessageBox.Show("好像表里没有数据呢", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox2.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要查看的学生，亲", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //查询
            com.CommandText = "select *from LEARN_RECORD_Table,FIELD_Table where LRFid=Fid and EndTime is null and LTName='" + NAME.Text + "' and LSName='" + ListBox2.SelectedItem.ToString() + "'";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                L3.Text = rd["StartTime"].ToString();
                L4.Text = rd["FName"].ToString();
            }
            rd.Close();
            con.Close();
        }

        private void END1_Click(object sender, EventArgs e)
        {
            //检验输入合法性
            if (ListBox1.Items.Count == 0)
            {
                MessageBox.Show("好像表里没有数据呢", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要评分的老师", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            string str = Goal1.Text;
            if (str==String.Empty || !IsNumberic(str))
            {
                MessageBox.Show("评分不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            int x= Convert.ToInt32(str);
            if (x < 0 || x > 100) 
            {
                MessageBox.Show("评分不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //SqlDataReader rd;
            //修改学习记录表
            com.CommandText = "update LEARN_RECORD_Table set STEva='" + x.ToString() + "' where EndTime is null and LTName='" + ListBox1.SelectedItem.ToString() + "' and LSName='" + NAME.Text + "'";
            com.ExecuteNonQuery();
            /*
            //修改用户表
            com.CommandText = "update USER_Table set UTvalue=(UTvalue+ '" + x.ToString() + "')/2 where UName='" + ListBox1.SelectedItem.ToString() + "'";
            if (com.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("出现了预期之外的错误", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //检查是否存在均互评且无结束时间的记录
            com.CommandText = "select *from LEARN_RECORD_Table where TSEva is not null and STEva is not null and EndTime is null and LTName='" + ListBox1.SelectedItem.ToString() + "' and LSName='" + NAME.Text + "'";
            rd = com.ExecuteReader();
            if (rd.HasRows)//如果存在，添加结束时间, 并且使得师生两人的记录分别加1
            {
                rd.Read();
                string temp1 = rd["TSEva"].ToString();
                string temp2 = rd["STEva"].ToString();
                rd.Close();
                //获取系统时间
                string time = DateTime.Now.ToLocalTime().ToString();
                com.CommandText = "update LEARN_RECORD_Table set EndTime='" + time + "' where TSEva='" + temp1 + "' and STEva='" + temp2 + "' and LTName='" + ListBox1.SelectedItem.ToString() + "' and LSName='" + NAME.Text + "'";
                com.ExecuteNonQuery();
                com.CommandText = "update USER_Table set ULearn +='1' where UName='" + NAME.Text + "'";
                com.ExecuteNonQuery();
                com.CommandText = "update USER_Table set UEntrust +='1' where UName='" + ListBox1.SelectedItem.ToString() + "'";
                com.ExecuteNonQuery();
            }
            */
            MessageBox.Show("评价成功，请等待您的搭档评价", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            con.Close();
        }

        private void END2_Click(object sender, EventArgs e)
        {
            //检验输入合法性
            if (ListBox2.Items.Count == 0)
            {
                MessageBox.Show("好像表里没有数据呢", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox2.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要评分的老师", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            string str = Goal2.Text;
            if (str == String.Empty || !IsNumberic(str))
            {
                MessageBox.Show("评分不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            int x = Convert.ToInt32(str);
            if (x < 0 || x > 100)
            {
                MessageBox.Show("评分不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //SqlDataReader rd;
            //修改学习记录表
            com.CommandText = "update LEARN_RECORD_Table set TSEva='" + x.ToString() + "' where EndTime is null and LSName='" + ListBox2.SelectedItem.ToString() + "' and LTName='" + NAME.Text + "'";
            com.ExecuteNonQuery();
            /*
            //修改用户表
            com.CommandText = "update USER_Table set USvalue=(USvalue+ '" + x.ToString() + "')/2 where UName='" + ListBox2.SelectedItem.ToString() + "'";
            if (com.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("出现了预期之外的错误", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //检查是否存在均互评且无结束时间的记录
            com.CommandText = "select *from LEARN_RECORD_Table where TSEva is not null and STEva is not null and EndTime is null and LSName='" + ListBox2.SelectedItem.ToString() + "' and LTName='" + NAME.Text + "'";
            rd = com.ExecuteReader();
            if (rd.HasRows)//如果存在，添加结束时间, 并且使得师生两人的记录分别加1
            {
                rd.Read();
                string temp1 = rd["TSEva"].ToString();
                string temp2 = rd["STEva"].ToString();
                rd.Close();
                //获取系统时间
                string time = DateTime.Now.ToLocalTime().ToString();
                com.CommandText = "update LEARN_RECORD_Table set EndTime='" + time + "' where TSEva='" + temp1 + "' and STEva='" + temp2 + "' and LSName='" + ListBox2.SelectedItem.ToString() + "' and LTName='" + NAME.Text + "'";
                com.ExecuteNonQuery();
                com.CommandText = "update USER_Table set UEntrust +='1' where UName='" + NAME.Text + "'";
                com.ExecuteNonQuery();
                com.CommandText = "update USER_Table set ULearn +='1' where UName='" + ListBox2.SelectedItem.ToString() + "'";
                com.ExecuteNonQuery();
            }
            */
            MessageBox.Show("评价成功，请等待您的搭档评价", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            con.Close();
        }
    }
}
