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
    public partial class Form1_1 : Form
    {
        public Form1_1()
        {
            InitializeComponent();
        }

        private void Sure_Button_Click(object sender, EventArgs e)
        {
            if (Phone.Text == String.Empty)
            {
                MessageBox.Show("电话号不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (User.Text == String.Empty)
            {
                MessageBox.Show("用户名不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (Code.Text == String.Empty)
            {
                MessageBox.Show("新密码不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            //先判断是否存在该记录，检验用户输入合法性，不合法拒绝修改，保护数据库
            com.CommandText = "select count(*) as hang from USER_Table where UPnum='" + Phone.Text + "' and UName='" + User.Text + "'";
            SqlDataReader sr = com.ExecuteReader();
            if (!sr.HasRows)
            {
                Phone.Clear();
                User.Clear();
                Code.Clear();
                MessageBox.Show("用户名和预留电话号不匹配", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            int n=0;
            if (sr.Read())
                n = (int)sr["hang"];
            if(n!=1)
            {
                MessageBox.Show("用户名和预留电话号多项匹配", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            sr.Close();
            //合法，可以修改密码
            com.CommandText = "update USER_Table set UCode=" + Code.Text + "where UPnum='" + Phone.Text + "' and UName='" + User.Text + "'";
            if(com.ExecuteNonQuery()!=1)
            {
                MessageBox.Show("修改失败", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            con.Close();
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Dispose();//释放所有资源
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
