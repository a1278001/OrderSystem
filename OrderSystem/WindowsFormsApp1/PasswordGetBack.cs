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
    public partial class PasswordGetBack : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public PasswordGetBack()
        {
            InitializeComponent();
        }

        private void PasswordGetBack_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            lbl註解.Text = "註：此為隨機產生之暫時密碼\n" + "此密碼僅供暫時登入使用\n" + "請登入後至會員專區變更密碼";
        }

        private void btn確認_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt姓名.Text != "") && (txtEmail.Text != "") && (txt手機號碼.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();

                string strSQL = "select * from CustomerAccount where 帳號 = @NewAccount;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                string 正確姓名 = "";
                string 正確Email = "";
                string 正確手機號碼 = "";

                if (reader.Read())
                {
                    正確姓名 = (string)reader["姓名"];
                    正確Email = (string)reader["Email"];
                    正確手機號碼 = (string)reader["手機號碼"];
                }

                reader.Close();

                Console.WriteLine(正確姓名);
                Console.WriteLine(正確Email);
                Console.WriteLine(正確手機號碼);

                if ((txt姓名.Text == 正確姓名) && (txtEmail.Text == 正確Email) && (txt手機號碼.Text == 正確手機號碼))
                {
                    System.Random myRnd = new Random();
                    int myNum = myRnd.Next(100000, 999999);


                    string strSQL2 = "update CustomerAccount set 密碼 = @NewPassword where 帳號 = @NewAccount;";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                    cmd2.Parameters.AddWithValue("@NewPassword", myNum.ToString());
                    cmd2.ExecuteNonQuery();

                    lbl暫時密碼.Text = myNum.ToString();
                    MessageBox.Show("密碼變更成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("資料輸入錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();


            }
            else
            {
                MessageBox.Show("請輸入完整資訊", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn清空_Click(object sender, EventArgs e)
        {
            txt帳號.Clear();
            txt姓名.Clear();
            txtEmail.Clear();
            txt手機號碼.Clear();
            lbl暫時密碼.Text = "";
        }
    }
}
