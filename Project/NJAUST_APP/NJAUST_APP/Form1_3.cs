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
    public partial class Form1_3 : Form
    {
        public Form1_3()
        {
            InitializeComponent();
        }

        private void LOG_Click(object sender, EventArgs e)
        {
            if (ADMname.Text == String.Empty)
            {
                MessageBox.Show("管理员名不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(ADMcode.Text==String.Empty)
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
            com.CommandText = "select * from ADM_Table where ADMName='"+ADMname.Text+"'";
            SqlDataReader sr = com.ExecuteReader();
            if(!sr.HasRows)
            {
                MessageBox.Show("管理员名不存在", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ADMcode.Clear();
                ADMname.Clear();
                return;
            }
            if(sr.Read())
            {
                if (ADMcode.Text == (string)sr["ADMCode"])
                {
                    sr.Close();
                    con.Close();
                    //打开管理员界面
                    this.Hide();
                    Form3 form = new Form3(ADMname.Text);
                    form.ShowDialog();
                    this.Dispose();//释放所有资源
                }
                else
                {
                    sr.Close();
                    con.Close();
                    MessageBox.Show("密码不正确", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    ADMcode.Clear();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
