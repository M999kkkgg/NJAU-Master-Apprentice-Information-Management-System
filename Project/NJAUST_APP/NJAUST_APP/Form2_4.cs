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
    public partial class Form2_4 : Form
    {
        public Form2_4(string n)
        {
            InitializeComponent();
            Start(n);
        }

        private void Start(string x)
        {
            NAME.Text = x;
            num.Text = "0条记录";
        }

        private void YES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLASH_Click(object sender, EventArgs e)
        {
            //清空已经存在的数据
            ListView1.Items.Clear();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            int NO = 0;
            string tname = "null";
            string fname = "null";
            string starttime = "null";
            string endtime = "null";
            string st = "null";
            string ts = "null";
            //查询
            com.CommandText = "select *from LEARN_RECORD_Table,FIELD_Table where LRFid=Fid and LSName='" + NAME.Text + "' order by StartTime";
            sr = com.ExecuteReader();
            while(sr.Read())
            {
                NO++;
                tname = sr["LTName"].ToString();
                fname = sr["FName"].ToString();
                starttime = sr["StartTime"].ToString();
                endtime = sr["EndTime"].ToString();
                st = sr["STEva"].ToString();
                ts = sr["TSEva"].ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = NO.ToString();
                lvi.SubItems.Add(tname);
                lvi.SubItems.Add(fname);
                lvi.SubItems.Add(starttime);
                lvi.SubItems.Add(endtime);
                lvi.SubItems.Add(st);
                lvi.SubItems.Add(ts);
                ListView1.Items.Add(lvi);
            }
            ListView1.EndUpdate();
            num.Text = NO.ToString() + "条记录";
            sr.Close();
            con.Close();
        }
    }
}
