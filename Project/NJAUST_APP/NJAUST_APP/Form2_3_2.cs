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
    public partial class Form2_3_2 : Form
    {
        public Form2_3_2(string Name)
        {
            InitializeComponent();
            Start(Name);
        }

        private void Start(string name)
        {
            NAME.Text = name;
        }

        private void YES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //清空列表
            ListView1.Items.Clear();
            ListView2.Items.Clear();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;

            int NO = 0;
            string TIME;
            string FNAME;
            string DES;
            //已经解决的问题
            com.CommandText = "select *from QUESTION_Table,FIELD_Table where QFid=Fid and QSolve='True' and QName='" + NAME.Text + "' order by Qno";
            rd = com.ExecuteReader();
            if(!rd.HasRows)
            {
                MessageBox.Show("你还没有已经解决的问题嗷", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            NO = 0;
            while(rd.Read())
            {
                NO++;
                TIME = rd["QTime"].ToString();
                FNAME = rd["FName"].ToString().Trim();
                DES = rd["QDescribe"].ToString().Trim();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = NO.ToString();
                lvi.SubItems.Add(TIME);
                lvi.SubItems.Add(FNAME);
                lvi.SubItems.Add(DES);
                ListView1.Items.Add(lvi);
            }
            ListView1.EndUpdate();
            x.Text = NO.ToString();
            rd.Close();
            //没有解决的问题
            com.CommandText = "select *from QUESTION_Table,FIELD_Table where QFid=Fid and QSolve='False' and QName='" + NAME.Text + "' order by Qno";
            rd = com.ExecuteReader();
            if (!rd.HasRows)
            {
                MessageBox.Show("你已经没有未解决的问题了！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            NO = 0;
            while (rd.Read())
            {
                NO++;
                TIME = rd["QTime"].ToString();
                FNAME = rd["FName"].ToString().Trim();
                DES = rd["QDescribe"].ToString().Trim();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = NO.ToString();
                lvi.SubItems.Add(TIME);
                lvi.SubItems.Add(FNAME);
                lvi.SubItems.Add(DES);
                ListView2.Items.Add(lvi);
            }
            ListView2.EndUpdate();
            y.Text = NO.ToString();
            rd.Close();
            //所有用户发布的问题
            com.CommandText = "select QTime,QName,FName,QDescribe,QSolve,UPnum from QUESTION_Table,FIELD_Table,USER_Table where QFid=Fid and QName=UName";
            rd = com.ExecuteReader();
            NO = 0;
            string UNAME = "null";
            string FLAG = "null";
            string PNUM = "null";
            while(rd.Read())
            {
                NO++;
                UNAME = rd["QName"].ToString().Trim();
                TIME = rd["QTime"].ToString();
                FNAME = rd["FName"].ToString().Trim();
                DES = rd["QDescribe"].ToString().Trim();
                PNUM = rd["UPnum"].ToString().Trim();
                if ((bool)rd["QSolve"])
                    FLAG = "解决";
                else
                    FLAG = "未解决";
                ListViewItem lvi = new ListViewItem();
                lvi.Text = NO.ToString();
                lvi.SubItems.Add(UNAME);
                lvi.SubItems.Add(PNUM);
                lvi.SubItems.Add(TIME);
                lvi.SubItems.Add(FNAME);
                lvi.SubItems.Add(DES);
                lvi.SubItems.Add(FLAG);
                ListView3.Items.Add(lvi);
            }
            ListView3.EndUpdate();
            z.Text = NO.ToString();
            rd.Close();
            con.Close();
        }
    }
}
