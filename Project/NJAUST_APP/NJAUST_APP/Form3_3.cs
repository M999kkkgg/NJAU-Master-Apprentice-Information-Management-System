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
    public partial class Form3_3 : Form
    {
        public Form3_3(string n)
        {
            InitializeComponent();
            Start(n);
        }

        private void Start(string x)
        {
            ADMNAME.Text = x;
            num1.Text = "0条记录";
            num2.Text = "0条记录";
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
            ListView2.Items.Clear();
            //执行语句读取数据
            //添加表1
            int NO = 0;
            string fname = "null";
            string cname = "null";
            com.CommandText = "select *from FIELD_Table,FIELDCLASS_Table where FCid=Cid order by Fid";
            sr = com.ExecuteReader();
            while(sr.Read())
            {
                NO++;
                fname = sr["FName"].ToString();
                cname = sr["CName"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = NO.ToString();
                lvi.SubItems.Add(cname);
                lvi.SubItems.Add(fname);
                ListView1.Items.Add(lvi);
            }
            ListView1.EndUpdate();
            num1.Text = NO.ToString() + "条记录";
            sr.Close();
            //添加表2
            NO = 0;
            com.CommandText= "select *from FIELDCLASS_Table order by Cid";
            sr = com.ExecuteReader();
            while(sr.Read())
            {
                NO++;
                cname = sr["CName"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = NO.ToString();
                lvi.SubItems.Add(cname);
                ListView2.Items.Add(lvi);
            }
            ListView2.EndUpdate();
            num2.Text = NO.ToString() + "条记录";
            sr.Close();
            con.Close();
        }
    }
}
