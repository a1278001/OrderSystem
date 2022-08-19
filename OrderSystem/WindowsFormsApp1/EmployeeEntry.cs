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
    public partial class EmployeeEntry : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public EmployeeEntry()
        {
            InitializeComponent();
        }

        private void EmployeeEntry_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "";

            if (rbtn店員.Checked)
            {
                strSQL = "select * from EmployeeAccount where 帳號 = @NewAccount;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                string 密碼 = "";
                if (reader.Read())
                {
                    密碼 = (string)reader["密碼"];
                    GlobalVar.登入帳號 = (string)reader["帳號"];
                    if (txt密碼.Text == 密碼)
                    {
                        MessageBox.Show("登入成功");
                        EmployeeMenu formEmployee = new EmployeeMenu();
                        GlobalVar.formEmployee = formEmployee;
                        formEmployee.Show();
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
                    MessageBox.Show("查無此帳號", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (rbtn系統管理員.Checked)
            {
                strSQL = "select * from SystemAccount where 帳號 = @NewAccount;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                string 密碼 = "";
                if (reader.Read())
                {
                    密碼 = (string)reader["密碼"];
                    GlobalVar.登入帳號 = (string)reader["帳號"];
                    if (txt密碼.Text == 密碼)
                    {
                        GlobalVar.管理員判定 = true;
                        MessageBox.Show("登入成功");
                        EmployeeMenu formEmployee = new EmployeeMenu();
                        GlobalVar.formEmployee = formEmployee;
                        formEmployee.Show();
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
                    MessageBox.Show("查無此帳號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("請勾選身分", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt帳號.Clear();
            txt密碼.Clear();
        }
    }
}
