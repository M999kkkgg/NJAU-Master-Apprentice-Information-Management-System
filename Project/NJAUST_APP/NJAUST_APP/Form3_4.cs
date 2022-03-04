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
    public partial class Form3_4 : Form
    {
        public Form3_4(string n)
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
            string coid = "null";
            string coname = "null";
            com.CommandText = "select *from COLLEGE_Table order by COid";
            sr = com.ExecuteReader();
            while (sr.Read())
            {
                NO++;
                coid = sr["COid"].ToString();
                coname = sr["COName"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = NO.ToString();
                lvi.SubItems.Add(coid);
                lvi.SubItems.Add(coname);
                ListView1.Items.Add(lvi);
            }
            ListView1.EndUpdate();
            num.Text = NO.ToString() + "条记录";
            sr.Close();
            con.Close();
        }
    }
}
