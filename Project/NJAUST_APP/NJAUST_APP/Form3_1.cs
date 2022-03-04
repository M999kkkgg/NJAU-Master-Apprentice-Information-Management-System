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
    public partial class Form3_1 : Form
    {
        public Form3_1(string n)
        {
            InitializeComponent();
            Start(n);
        }

        private void Start(string x)
        {
            ADMNAME.Text = x;
            num.Text = "0条记录";
        }

        private void OUt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLASH_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            //清空已存在数据
            ListView1.Items.Clear();
            //执行语句读取数据
            int NO = 0;
            string name = "null";
            string status = "null";
            string time = "null";
            string _return = "null";
            com.CommandText = "select *from SIGNLOG_Table order by SLTime";
            sr = com.ExecuteReader();
            while(sr.Read())
            {
                NO++;
                name = sr["SLName"].ToString();
                status = sr["SLStatus"].ToString().Trim();
                time = sr["SLTime"].ToString();
                _return = sr["SLReturn"].ToString().Trim();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = NO.ToString();
                lvi.SubItems.Add(time);
                lvi.SubItems.Add(name);
                if (status == "User")
                    lvi.SubItems.Add("用户");
                else
                    lvi.SubItems.Add("其他");
                if (_return == "Allowed")
                    lvi.SubItems.Add("允许");
                else if (_return == "Refused")
                    lvi.SubItems.Add("拒绝");
                else
                    lvi.SubItems.Add("其他");
                ListView1.Items.Add(lvi);
            }
            ListView1.EndUpdate();
            num.Text = NO.ToString() + "条记录";
            sr.Close();
            con.Close();
        }
    }
}
