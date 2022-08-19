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
    public partial class FormAccountCreate : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public FormAccountCreate()
        {
            InitializeComponent();
        }

        private void formAccountCreate_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn建立_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt密碼.Text != "") && (txt密碼2.Text != "") && (txt姓名.Text != "") && (txtEmail.Text != "") && (txt手機號碼.Text != ""))
            {
                
                if(txt密碼.Text == txt密碼2.Text)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(myDBConnectionString);
                        con.Open();
                        string strSQL = "insert into CustomerAccount values (@NewAccount,@NewPassword,@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirthday,0,0,0);";
                        SqlCommand cmd = new SqlCommand(strSQL, con);

                        cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                        cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                        cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                        cmd.Parameters.AddWithValue("@NewPhone", txt手機號碼.Text);
                        cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                        cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("帳號申請成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("帳號已存在", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("再次輸入密碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("打星號部分欄位必須填寫", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn清空_Click(object sender, EventArgs e)
        {
            txt姓名.Text = "";
            txtEmail.Text = "";
            txt手機號碼.Text = "";
            dtp生日.Value = DateTime.Now;
            txt地址.Text = "";
            txt帳號.Text = "";
            txt密碼.Text = "";
            txt密碼2.Text = "";
        }
    }
}
