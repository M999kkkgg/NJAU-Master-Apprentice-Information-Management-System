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
    public partial class Form2_3_3 : Form
    {
        public Form2_3_3(string N)
        {
            InitializeComponent();
            Start(N);
        }

        private void Start(string x)
        {
            //传参当前用户名
            NAME.Text = x;
            //初始化label
            L1.Text = String.Empty;
            L2.Text = String.Empty;
            L3.Text = String.Empty;
            L4.Text = String.Empty;
            L5.Text = String.Empty;
            L6.Text = String.Empty;
            num1.Text = "0";
            num2.Text = "0";
            num3.Text = "0";
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Flash_Click(object sender, EventArgs e)
        {
            //清空已经存在的数据
            ListView1.Items.Clear();
            ListView2.Items.Clear();
            ListBox1.Items.Clear();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            int NO=0;
            string TNAME = "null";
            string FNAME = "null";
            //查询你发出的申请
            com.CommandText = "select *from MASTER_RECORD_Table,FIELD_Table where MFid=Fid and MSName='" + NAME.Text + "'";
            sr = com.ExecuteReader();
            NO = 0;
            if (sr.HasRows)
            {
                while(sr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    NO++;
                    TNAME = sr["MTName"].ToString();
                    FNAME = sr["FName"].ToString();
                    lvi.Text = NO.ToString();
                    lvi.SubItems.Add(TNAME);
                    lvi.SubItems.Add(FNAME);
                    if ((bool)sr["Flag"])
                        lvi.SubItems.Add("通过");
                    else
                        lvi.SubItems.Add("未通过");
                    ListView1.Items.Add(lvi);
                }
                ListView1.EndUpdate();
            }
            num1.Text = NO.ToString();
            sr.Close();
            //查询你没批准且收到的申请
            com.CommandText= "select *from MASTER_RECORD_Table,FIELD_Table where Flag='False' and MFid=Fid and MTName='" + NAME.Text + "'";
            sr = com.ExecuteReader();
            NO = 0;
            if(sr.HasRows)
            {
                while(sr.Read())
                {
                    NO++;
                    ListBox1.Items.Add(sr["MSName"].ToString());
                }
            }
            num2.Text = NO.ToString();
            sr.Close();
            //查询你批准过的申请
            com.CommandText= "select *from MASTER_RECORD_Table,FIELD_Table where Flag='True' and MFid=Fid and MTName='" + NAME.Text + "'";
            sr = com.ExecuteReader();
            NO = 0;
            if (sr.HasRows)
            {
                while (sr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    NO++;
                    TNAME = sr["MSName"].ToString();
                    FNAME = sr["FName"].ToString();
                    lvi.Text = NO.ToString();
                    lvi.SubItems.Add(TNAME);
                    lvi.SubItems.Add(FNAME);
                    ListView2.Items.Add(lvi);
                }
                ListView2.EndUpdate();
            }
            num3.Text = NO.ToString();
            sr.Close();
            con.Close();
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            //检查数据合法性，不合法则拒绝显示
            if (ListBox1.Items.Count == 0)
            {
                MessageBox.Show("没有数据嗷", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要查看的学生", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            string strname = ListBox1.SelectedItem.ToString();
            com.CommandText = "select *from MASTER_RECORD_Table,FIELD_Table where Fid=MFid and MTName='" + NAME.Text + "' and MSName='" + strname + "' and Flag='False'";
            sr = com.ExecuteReader();
            if(sr.Read())
                L3.Text = sr["FName"].ToString();
            sr.Close();
            com.CommandText = "select *from USER_Table,PLACE_Table where Pid=UPid and UName='" + strname + "'";
            sr = com.ExecuteReader();
            if (sr.Read())
            {
                L1.Text = sr["UTname"].ToString();
                L2.Text = sr["UPnum"].ToString();
                L4.Text = sr["PName"].ToString();
                L5.Text = sr["USvalue"].ToString();
                L6.Text = sr["ULearn"].ToString();
            }
            sr.Close();
            con.Close();
        }

        private void ALLOW_Click(object sender, EventArgs e)
        {
            //检查数据合法性，不合法则拒绝显示
            if (ListBox1.Items.Count == 0)
            {
                MessageBox.Show("没有数据嗷", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要查看的学生", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader sr;
            string strname = ListBox1.SelectedItem.ToString();
            //Fid
            string fid = "null";
            com.CommandText = "select *from MASTER_RECORD_Table,FIELD_Table where Fid=MFid and MTName='" + NAME.Text + "' and MSName='" + strname + "' and Flag='False'";
            sr = com.ExecuteReader();
            if (sr.Read())
                fid = sr["Fid"].ToString();
            sr.Close();
            //获取当前时间
            string time = DateTime.Now.ToLocalTime().ToString();
            //添加一条新的学习记录
            com.CommandText = "insert into LEARN_RECORD_Table(LTName,LSName,LRFid,StartTime) values('" + NAME.Text + "','" + strname + "','" + fid + "','" + time + "')";
            if(com.ExecuteNonQuery()!=1)
            {
                MessageBox.Show("预料之外的错误", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                con.Close();
                return;
            }
            //将拜师申请中Flag的值改为True
            com.CommandText = "update MASTER_RECORD_Table set Flag='True' where MTName='" + NAME.Text + "' and MSName='" + strname + "' and Flag='False'";
            if (com.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("预料之外的错误", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                con.Close();
                return;
            }
            MessageBox.Show("操作成功，请点击刷新检查", "GOOD", MessageBoxButtons.OK, MessageBoxIcon.Question);
            con.Close();
        }
    }
}
