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
    public partial class Form3 : Form
    {
        public Form3(string name)
        {
            InitializeComponent();
            Start(name);
        }

        private void Start(string _name)
        {
            ADMNAME.Text = _name;
        }

        private void OUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Dispose();//释放所有资源
        }

        private void LOOKLOG_Click(object sender, EventArgs e)
        {
            Form3_1 form = new Form3_1(ADMNAME.Text);
            form.ShowDialog();
        }

        private void DELETELOG_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "truncate table SIGNLOG_Table";
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("登录日志已经全部清除", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void ADDADM_Click(object sender, EventArgs e)
        {
            Form3_2 form = new Form3_2(ADMNAME.Text);
            form.ShowDialog();
        }

        private void FIELD_Click(object sender, EventArgs e)
        {
            Form3_3 form = new Form3_3(ADMNAME.Text);
            form.ShowDialog();
        }

        private void COLLEGE_Click(object sender, EventArgs e)
        {
            Form3_4 form = new Form3_4(ADMNAME.Text);
            form.ShowDialog();
        }

        private void PLACE_Click(object sender, EventArgs e)
        {
            Form3_5 form = new Form3_5(ADMNAME.Text);
            form.ShowDialog();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            Form3_6 form = new Form3_6(ADMNAME.Text);
            form.ShowDialog();
        }
    }
}
