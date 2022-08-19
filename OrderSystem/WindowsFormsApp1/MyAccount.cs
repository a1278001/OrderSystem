using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MyAccount : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        string 原始密碼 = "";

        public MyAccount()
        {
            InitializeComponent();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from CustomerAccount where 帳號 = @NewAccount;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewAccount", GlobalVar.登入帳號);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lbl帳號.Text = string.Format("{0}", reader["帳號"]);
                txt姓名.Text = string.Format("{0}", reader["姓名"]);
                txtEmail.Text = string.Format("{0}", reader["Email"]);
                txt手機號碼.Text = string.Format("{0}", reader["手機號碼"]);
                dtp生日.Value = Convert.ToDateTime(reader["生日"]);
                txt地址.Text = string.Format("{0}", reader["地址"]);
                lbl點數.Text = string.Format("{0}", reader["點數"]);
                原始密碼 = string.Format("{0}", reader["密碼"]);
            }
            reader.Close();
            con.Close();


        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {

            if ((txtEmail.Text != "") && (txt姓名.Text != "") && (txt手機號碼.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update CustomerAccount set 姓名 = @NewName , Email = @NewEmail , 手機號碼 = @NewPhone , 生日 = @NewBirthday , 地址 = @NewAddress where 帳號 = @SearchAccount;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchAccount", lbl帳號.Text);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt手機號碼.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("姓名、手機號碼及Email不得為空", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if ((txt密碼.Text != "") && (txt再次輸入.Text != ""))
            {
                if (txt密碼.Text == txt再次輸入.Text)
                {
                    if (txt密碼.Text != 原始密碼)
                    {
                        SqlConnection con = new SqlConnection(myDBConnectionString);
                        con.Open();
                        string strSQL = "update CustomerAccount set 密碼 = @NewPassword where 帳號 = @SearchAccount;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchAccount", lbl帳號.Text);
                        cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("密碼修改成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("密碼與原本密碼相同，請重新設定", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("密碼與再次輸入不一致", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("請輸入新密碼", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }
    }
}
