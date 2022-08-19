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
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        int VeAnswer = 0;
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt帳號.Text = "";
            
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            產生驗證碼();

        }

        void 產生驗證碼()
        {
            System.Random myRnd = new Random();
            int VeCode1 = myRnd.Next(1, 99);
            int VeCode2 = myRnd.Next(1, 9);
            lbl驗證碼.Text = VeCode1 + " + " + VeCode2 + " = ?";
            VeAnswer = VeCode1 + VeCode2;
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            if(txt驗證碼.Text == VeAnswer.ToString())
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from CustomerAccount where 帳號 = @NewAccount;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    if ((bool)reader["停權"] == false)
                    {
                        GlobalVar.使用者名稱 = (string)reader["姓名"];
                        GlobalVar.登入帳號 = (string)reader["帳號"];
                        GlobalVar.使用者電話 = (string)reader["手機號碼"];
                        if (txt密碼.Text == (string)reader["密碼"])
                        {

                            MessageBox.Show("登入成功");
                            if ((bool)reader["黑名單"] == true)
                            {
                                MessageBox.Show("已被列入黑名單", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            GlobalVar.使用者身分 = "A";
                            GlobalVar.登入判定 = true;
                            GlobalVar.登入者ID = (int)reader["id"];
                            GlobalVar.OrderList.Clear();
                            CustomerMenu formCustomer = new CustomerMenu();
                            GlobalVar.formCustomer = formCustomer;
                            formCustomer.Show();
                            GlobalVar.formMain.Hide();
                        }
                        else
                        {
                            MessageBox.Show("密碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("帳號已停權", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("查無此帳號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("驗證碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            產生驗證碼();
        }

        private void btn重設_Click(object sender, EventArgs e)
        {
            txt帳號.Text = "";
            txt密碼.Text = "";
            txt驗證碼.Text = "";
            產生驗證碼();
        }

        private void btn直接訂購_Click(object sender, EventArgs e)
        {
            if ((txt直購姓名.Text != "") && (txt直購電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();

                string strSQL = "insert into GuestOrder values (@NewName,@NewPhone);";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@NewName", txt直購姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt直購電話.Text);

                cmd.ExecuteNonQuery();

                GlobalVar.使用者名稱 = txt直購姓名.Text;

                string strSQL2 = "select * from GuestOrder";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    GlobalVar.登入者ID = (int)reader["id"];
                }

                GlobalVar.登入帳號 = "";
                GlobalVar.使用者身分 = "B";
                GlobalVar.使用者電話 = txt直購電話.Text;

                CustomerMenu formCustomer = new CustomerMenu();
                GlobalVar.formCustomer = formCustomer;
                formCustomer.Show();
                GlobalVar.formMain.Hide();

                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名及電話", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            產生驗證碼();
        }
    }
}
