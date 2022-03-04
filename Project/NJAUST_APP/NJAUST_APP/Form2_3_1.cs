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
    public partial class Form2_3_1 : Form
    {
        public Form2_3_1(string sname,string tname)
        {
            InitializeComponent();
            Start(sname, tname);
        }

        private void Start(string SNAME,string TNAME)
        {
            //初始化label
            tname.Text = TNAME;
            sname.Text = SNAME;
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //获取老师数据
            com.CommandText = "select *from USER_Table,FIELD_Table where USER_Table.UFid=FIELD_Table.Fid and UName='" + tname.Text + "'";
            rd = com.ExecuteReader();
            if(!rd.HasRows)
            {
                MessageBox.Show("预期之外的错误", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                rd.Close();
                con.Close();
                return;
            }
            if(rd.Read())
            {
                tfname.Text = rd["FName"].ToString();
            }
            rd.Close();
            //初始化求助领域下拉表
            com.CommandText = "select *from FIELD_Table order by Fid";
            rd = com.ExecuteReader();
            while(rd.Read())
            {
                sfid.Items.Add(rd["FName"].ToString());
            }
            rd.Close();
            sfid.Text = tfname.Text;
            con.Close();
        }

        private void NO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YES_Click(object sender, EventArgs e)
        {
            //若求助领域不合适，自动拒绝，不做入记录
            if (sfid.Text.Trim() != tfname.Text.Trim())
            {
                MessageBox.Show("老师好像不太擅长这个方面呢", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //检索用户之前是否提出过该领域的问题，若提出过，修改是否解决
            //若未提出过，则自动补充记录
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //获取fid
            string fid="null";
            com.CommandText = "select *from FIELD_Table where FName='"+sfid.Text+"'";
            rd = com.ExecuteReader();
            if(!rd.HasRows)
            {
                MessageBox.Show("预期之外的错误", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                rd.Close();
                con.Close();
                return;
            }
            if (rd.Read())
            {
                fid = rd["Fid"].ToString();
            }
            rd.Close();
            //检查问题表
            com.CommandText = "select *from QUESTION_Table where QName='" + sname.Text + "' and QFid='" + fid + "' and QSolve='False'";
            rd = com.ExecuteReader();
            string x = "null";//用于修改时作为Qno标记
            if (!rd.HasRows)//不存在记录则添加
            {
                rd.Close();
                //获取当前系统时间
                string time = DateTime.Now.ToLocalTime().ToString();
                com.CommandText="insert into QUESTION_Table(QName,QTime,QFid,QSolve) values('"+sname.Text+"','"+time+"','"+fid+"','True')";
                if(com.ExecuteNonQuery()!=1)
                {
                    MessageBox.Show("预期之外的错误", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    con.Close();
                    return;
                }
            }
            else//存在记录则修改
            {
                if(rd.Read())
                    x = rd["Qno"].ToString();
                rd.Close();
                com.CommandText = "update QUESTION_Table set QSolve='True' where Qno='" + x + "'";
                if (com.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("预期之外的错误", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    con.Close();
                    return;
                }
            }
            //修改拜师申请表
            com.CommandText = "insert into MASTER_RECORD_Table(MSName,MTName,MFid,Flag) values('" + sname.Text + "','" + tname.Text + "','" + fid + "','False')";
            if (com.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("提交申请失败", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                con.Close();
                return;
            }
            con.Close();
            this.Close();
        }
    }
}
