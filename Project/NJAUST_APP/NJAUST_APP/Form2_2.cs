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
    public partial class Form2_2 : Form
    {
        public Form2_2()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {
            this.AutoScroll = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //清空已存在数据
            ListView.Items.Clear();
            //执行语句读取数据
            string name;
            int no,value;
            com.CommandText = "select UName,UTvalue from USER_Table order by UTvalue desc";
            SqlDataReader sr = com.ExecuteReader();
            if(!sr.HasRows)
            {
                MessageBox.Show("数据集为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            no = 0;
            while(sr.Read())
            {
                no++;
                value = (int)sr["UTvalue"];
                name = sr["UName"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = no.ToString();
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(value.ToString());
                this.ListView.Items.Add(lvi);
            }
            this.ListView.EndUpdate();
            sr.Close();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //清空已存在数据
            ListView.Items.Clear();
            //执行语句读取数据
            string name;
            int no, value;
            com.CommandText = "select UName,USvalue from USER_Table order by USvalue desc";
            SqlDataReader sr = com.ExecuteReader();
            if (!sr.HasRows)
            {
                MessageBox.Show("数据集为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            no = 0;
            while (sr.Read())
            {
                no++;
                value = (int)sr["USvalue"];
                name = sr["UName"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = no.ToString();
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(value.ToString());
                this.ListView.Items.Add(lvi);
            }
            this.ListView.EndUpdate();
            sr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //清空已存在数据
            ListView.Items.Clear();
            //执行语句读取数据
            string name;
            int no, value;
            com.CommandText = "select UName,UEntrust from USER_Table order by UEntrust desc";
            SqlDataReader sr = com.ExecuteReader();
            if (!sr.HasRows)
            {
                MessageBox.Show("数据集为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            no = 0;
            while (sr.Read())
            {
                no++;
                value = (int)sr["UEntrust"];
                name = sr["UName"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = no.ToString();
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(value.ToString());
                this.ListView.Items.Add(lvi);
            }
            this.ListView.EndUpdate();
            sr.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //清空已存在数据
            ListView.Items.Clear();
            //执行语句读取数据
            string name;
            int no, value;
            com.CommandText = "select UName,ULearn from USER_Table order by ULearn desc";
            SqlDataReader sr = com.ExecuteReader();
            if (!sr.HasRows)
            {
                MessageBox.Show("数据集为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            no = 0;
            while (sr.Read())
            {
                no++;
                value = (int)sr["ULearn"];
                name = sr["UName"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = no.ToString();
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(value.ToString());
                this.ListView.Items.Add(lvi);
            }
            this.ListView.EndUpdate();
            sr.Close();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //清空已存在数据
            ListView.Items.Clear();
            //执行语句读取数据
            string name;
            int no, value;
            com.CommandText = "select COUNT(*) as 'CT',FIELD_Table.FName from QUESTION_Table,FIELD_Table where QUESTION_Table.QFid=FIELD_Table.Fid group by FIELD_Table.FName order by CT desc";
            SqlDataReader sr = com.ExecuteReader();
            if (!sr.HasRows)
            {
                MessageBox.Show("数据集为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            no = 0;
            while (sr.Read())
            {
                no++;
                value = (int)sr["CT"];
                name = sr["FName"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = no.ToString();
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(value.ToString());
                this.ListView.Items.Add(lvi);
            }
            this.ListView.EndUpdate();
            sr.Close();
            con.Close();
        }
    }
}
