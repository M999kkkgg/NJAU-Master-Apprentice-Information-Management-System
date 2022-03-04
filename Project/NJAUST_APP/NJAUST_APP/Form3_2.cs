using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NJAUST_APP
{
    public partial class Form3_2 : Form
    {
        public Form3_2(string n)
        {
            InitializeComponent();
            Start(n);
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

        private void Start(string x)
        {
            //设置传参
            ADMNAME.Text = x;
            //设置提醒
            var toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(ADM_Name, @"管理员名要小于10位，并且不能以空格开头或者结尾");

            var toolTip2 = new ToolTip();
            toolTip2.AutoPopDelay = 10000;
            toolTip2.InitialDelay = 500;
            toolTip2.ReshowDelay = 500;
            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(ADM_Code, @"管理员密码必须是6位数字");

            var toolTip3 = new ToolTip();
            toolTip3.AutoPopDelay = 10000;
            toolTip3.InitialDelay = 500;
            toolTip3.ReshowDelay = 500;
            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(CREATE, @"管理员账号和密码一旦创建就不能更改和找回嗷，要仔细了！");
        }

        private void NONE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CREATE_Click(object sender, EventArgs e)
        {
            //检验输入合法性
            if (ADM_Name.TextLength > 10 || ADM_Name.Text == String.Empty)
            {
                MessageBox.Show("用户名不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ADM_Name.Clear();
                return;
            }
            if (ADM_Code.TextLength != 6 || ADM_Code.Text == String.Empty || !Code(ADM_Code.Text))
            {
                MessageBox.Show("密码不合法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ADM_Code.Clear();
                return;
            }
            //去空格
            ADM_Name.Text = ADM_Name.Text.Trim();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //检验重名
            com.CommandText = "select *from ADM_Table where ADMName='" + ADM_Name.Text + "'";
            rd = com.ExecuteReader();
            if(rd.HasRows)
            {
                MessageBox.Show("这个管理员名已经存在了吆", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                rd.Close();
                con.Close();
                ADM_Name.Clear();
                return;
            }
            rd.Close();
            //添加账户
            com.CommandText = "insert into ADM_Table(ADMName,ADMCode) values('" + ADM_Name.Text + "','" + ADM_Code.Text + "')";
            if(com.ExecuteNonQuery()!=1)
            {
                MessageBox.Show("添加账户时遇到了预期之外的问题", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            rd.Close();
            con.Close();
            MessageBox.Show("创建成功，快去登录试试吧！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
