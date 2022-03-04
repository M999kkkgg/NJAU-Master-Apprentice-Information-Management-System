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
    public partial class Form2_3 : Form
    {
        public Form2_3(string name)
        {
            InitializeComponent();
            Start(name);
        }
        private void Start(string _name)
        {
            //传参用户名
            NAME.Text = _name;
            //设置tooltip
            var toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(NOW_LEARN, @"查看当前学习状态仅显示正在学习的内容
你也可以在其中选择结束学习");

            var toolTip2 = new ToolTip();
            toolTip2.AutoPopDelay = 10000;
            toolTip2.InitialDelay = 500;
            toolTip2.ReshowDelay = 500;
            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(NOW_APPLY, @"查看当前申请状态仅显示未被申请的内容嗷以及你
收到的申请，你也可以在其中选择取消或拒绝申请");
            //初始化lable
            tname.Text = String.Empty;
            college.Text = String.Empty;
            pnum.Text = String.Empty;
            gender.Text = String.Empty;
            _fname.Text = String.Empty;
            age.Text = String.Empty;
            place.Text = String.Empty;
            entrust.Text = String.Empty;
            tvalue.Text = String.Empty;
            //初始化listbox
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //设置擅长领域下拉表
            com.CommandText = "select FName from FIELD_Table order by Fid";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                FID.Items.Add((string)rd["FName"]);
                FName.Items.Add((string)rd["FName"]);
            }
            rd.Close();
            //设置常去学习场所下拉框
            com.CommandText = "select PName from PLACE_Table order by Pid";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                MPlace.Items.Add((string)rd["PName"]);
            }
            rd.Close();
            //设置学院下拉列表
            com.CommandText = "select COName from COLLEGE_Table order by COid";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                MCollege.Items.Add((string)rd["COName"]);
            }
            rd.Close();
            //设置筛选方式下拉表
            Method.Items.Add("领域");
            Method.Items.Add("学院");
            Method.Items.Add("常去学习场所");
            Method.Items.Add("师傅潜力值");
            Method.Items.Add("完成委托数");
            con.Close();
        }

        private void FIND_Click(object sender, EventArgs e)
        {
            //判断用户输入合法性以保护数据库
            if(FID.Text==String.Empty)
            {
                MessageBox.Show("咨询的领域不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(QUESTION.Text==String.Empty)
            {
                MessageBox.Show("问题描述不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //获取当前系统时间
            string time = DateTime.Now.ToLocalTime().ToString();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //Fid
            string fid="null";
            com.CommandText = "select * from FIELD_Table";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                if ((string)rd["FName"] == FID.Text)
                    fid = (string)rd["Fid"].ToString();
            }
            rd.Close();
            //若存在同一用户同一领域问题，且都是未解决，则拒绝插入
            com.CommandText = "select COUNT(*) as CT from QUESTION_Table where QName='"+NAME.Text+"' and QFid='"+fid+"' and QSolve='False'";
            rd = com.ExecuteReader();
            int n=0;
            if (rd.Read())
                n = (int)rd["CT"];
            if (n != 0) 
            {
                MessageBox.Show("你已经有一个同类型的待解决的问题了", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                rd.Close();
                con.Close();
                return;
            }
            rd.Close();
            //插入记录到问题表中
            com.CommandText = "insert into QUESTION_Table(QName, QTime, QFid, QDescribe, QSolve) values('" + NAME.Text + "','" + time + "','" + fid + "','" + QUESTION.Text + "','False')";
            if(com.ExecuteNonQuery()!=1)
            {
                MessageBox.Show("问题记录表更新失败", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                con.Close();
                return;
            }
            MessageBox.Show("您提出的问题已经存入后台", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
            con.Close();
        }

        private void SELECT_Click(object sender, EventArgs e)
        {
            //判断用户输入合法性以保护数据库
            if (Method.Text == String.Empty) 
            {
                MessageBox.Show("请选择筛选的方法", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(FName.Text==String.Empty && Method.Text=="领域")
            {
                MessageBox.Show("请选择要筛选的领域", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (MCollege.Text == String.Empty&& Method.Text=="学院")
            {
                MessageBox.Show("请选择要筛选的学院","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (MPlace.Text == String.Empty && Method.Text == "常去学习场所")
            {
                MessageBox.Show("请选择要筛选的常去学习场所", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //清空原来ListBox的内容
            ListBox.Items.Clear();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            //按照要求进行筛选
            string TempName = "null";
            string college = "null";
            string place = "null";
            string fname = "null";
            //领域要求
            if(Method.Text=="领域")
            {
                fname = FName.Text;
                com.CommandText = "select * from FIELD_Table,USER_Table where USER_Table.UFid=FIELD_Table.Fid and FIELD_Table.FName='" + fname + "' order by UTvalue desc";
                rd = com.ExecuteReader();
                if (!rd.HasRows)
                {
                    MessageBox.Show("很抱歉，没有符合条件的老师", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    rd.Close();
                    con.Close();
                    return;
                }
                while (rd.Read())
                {
                    TempName = rd["UName"].ToString();
                    ListBox.Items.Add(TempName);
                }
                rd.Close();
            }
            //学院要求
            if (Method.Text == "学院")
            {
                college = MCollege.Text;
                com.CommandText = "select * from USER_Table,COLLEGE_Table where USER_Table.UCid=COLLEGE_Table.COid and COLLEGE_Table.COName='" + college + "' order by UTvalue desc";
                rd = com.ExecuteReader();
                if (!rd.HasRows)
                {
                    MessageBox.Show("很抱歉，没有符合条件的老师", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    rd.Close();
                    con.Close();
                    return;
                }
                while (rd.Read())
                {
                    TempName = rd["UName"].ToString();
                    ListBox.Items.Add(TempName);
                }
                rd.Close();
            }
            //场所要求
            else if (Method.Text == "常去学习场所")
            {
                place = MPlace.Text;
                com.CommandText = "select *from USER_Table,PLACE_Table where USER_Table.UPid=PLACE_Table.Pid and PLACE_Table.PName='"+place+"' order by UTvalue desc";
                rd = com.ExecuteReader();
                if (!rd.HasRows)
                {
                    MessageBox.Show("很抱歉，没有符合条件的老师", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    rd.Close();
                    con.Close();
                    return;
                }
                while (rd.Read())
                {
                    TempName = rd["UName"].ToString();
                    ListBox.Items.Add(TempName);
                }
                rd.Close();
            }
            //潜力值要求
            else if (Method.Text == "师傅潜力值")
            {
                com.CommandText = "select *from USER_Table order by UTvalue desc";
                rd = com.ExecuteReader();
                if (!rd.HasRows)
                {
                    MessageBox.Show("很抱歉，没有符合条件的老师", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    rd.Close();
                    con.Close();
                    return;
                }
                while (rd.Read())
                {
                    TempName = rd["UName"].ToString();
                    ListBox.Items.Add(TempName);
                }
                rd.Close();
            }
            //完成委托数要求
            else if (Method.Text == "完成委托数")
            {
                com.CommandText = "select *from USER_Table order by UEntrust desc";
                rd = com.ExecuteReader();
                if (!rd.HasRows)
                {
                    MessageBox.Show("很抱歉，没有符合条件的老师", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    rd.Close();
                    con.Close();
                    return;
                }
                while (rd.Read())
                {
                    TempName = rd["UName"].ToString();
                    ListBox.Items.Add(TempName);
                }
                rd.Close();
            }
            con.Close();
            GodNum.Text = ListBox.Items.Count.ToString() + "人";
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            //检查数据合法性，不合法则拒绝显示
            if (ListBox.Items.Count == 0)
            {
                MessageBox.Show("请先点击筛选嗷，亲", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要查看的老师，亲", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //提取选中的值
            string uname = ListBox.SelectedItem.ToString();
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            com.CommandText = "select *from USER_Table,FIELD_Table,COLLEGE_Table,PLACE_Table where USER_Table.UCid=COLLEGE_Table.COid and USER_Table.UFid=FIELD_Table.Fid and USER_Table.UPid=PLACE_Table.Pid and USER_Table.UName='" + uname + "'";
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
                tname.Text = rd["UTname"].ToString().Trim();
                college.Text = rd["COName"].ToString().Trim();
                pnum.Text = rd["UPnum"].ToString().Trim();
                if ((bool)rd["UGender"])
                    gender.Text = "男";
                else
                    gender.Text = "女";
                _fname.Text = rd["FName"].ToString().Trim();
                age.Text = rd["UAge"].ToString().Trim();
                place.Text = rd["PName"].ToString().Trim();
                entrust.Text = rd["UEntrust"].ToString().Trim();
                tvalue.Text = rd["UTvalue"].ToString().Trim();
            }
            rd.Close();
            con.Close();
        }

        private void APPLY_Click(object sender, EventArgs e)
        {
            //检验数据合法性
            if (ListBox.Items.Count == 0)
            {
                MessageBox.Show("请先点击筛选嗷，亲", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要查看的老师，亲", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(ListBox.SelectedItem.ToString().Trim()==NAME.Text)
            {
                MessageBox.Show("不可以自己向自己拜师嗷", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            //检验是否重复拜师
            //连接数据库
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=NJAUST;uid=sa;pwd=msf97347110lol";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            SqlDataReader rd;
            com.CommandText = "select *from MASTER_RECORD_Table where Flag='False' and MSName='" + NAME.Text + "' and MTName='" + ListBox.SelectedItem.ToString().Trim() + "'";
            rd = com.ExecuteReader();
            if(rd.HasRows)
            {
                MessageBox.Show("你之前已经向他发出申请啦，请耐心的等待通过", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                rd.Close();
                con.Close();
                return;
            }
            rd.Close();
            //检验是否重复学习
            com.CommandText = "select *from LEARN_RECORD_Table where EndTime is null and LSName='" + NAME.Text + "' and LTName='" + ListBox.SelectedItem.ToString().Trim() + "'";
            rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("你已经正在和这个老师学习啦", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question);
                rd.Close();
                con.Close();
                return;
            }
            con.Close();
            //进入页面，传入用户参数
            Form2_3_1 form = new Form2_3_1(NAME.Text,ListBox.SelectedItem.ToString());
            form.ShowDialog();
        }

        private void NOW_QUESTION_Click(object sender, EventArgs e)
        {
            Form2_3_2 form = new Form2_3_2(NAME.Text);
            form.ShowDialog();
        }

        private void NOW_APPLY_Click(object sender, EventArgs e)
        {
            Form2_3_3 form = new Form2_3_3(NAME.Text);
            form.ShowDialog();
        }

        private void NOW_LEARN_Click(object sender, EventArgs e)
        {
            Form2_3_4 form = new Form2_3_4(NAME.Text);
            form.ShowDialog();
        }
    }
}
