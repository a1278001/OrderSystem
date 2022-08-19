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
    public partial class EmployeeAccountManagement : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> listID = new List<int>();
        List<string> listNum = new List<string>();
        List<string> listAccount = new List<string>();

        public EmployeeAccountManagement()
        {
            InitializeComponent();
        }

        private void EmployeeAccountManagement_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            cbox搜尋欄位.Items.Add("員工編號");
            cbox搜尋欄位.Items.Add("帳號");
            cbox搜尋欄位.SelectedIndex = 0;

            讀取員工資料();
            lvw員工資料顯示();
        }

        void 讀取員工資料()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from EmployeeAccount";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listID.Add((int)reader["Id"]);
                listNum.Add((string)reader["員工編號"]);
                listAccount.Add((string)reader["帳號"]);
            }
            reader.Close();
            con.Close();
        }

        void lvw員工資料顯示()
        {
            lvw員工資料.View = View.Details;
            lvw員工資料.Columns.Add("Id", 60);
            lvw員工資料.Columns.Add("員工編號", 80);
            lvw員工資料.Columns.Add("員工帳號", 100);
            lvw員工資料.FullRowSelect = true;

            for (int i = 0; i < listID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listID[i].ToString();
                item.SubItems.Add(listNum[i]);
                item.SubItems.Add(listAccount[i]);
                lvw員工資料.Items.Add(item);
            }
        }

        void 清除List()
        {
            listID.Clear();
            listNum.Clear();
            listAccount.Clear();
        }

        private void btn建立_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt密碼.Text != "") && (txt員工編號.Text != ""))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into EmployeeAccount values (@NewNum,@NewAccount,@NewPassword)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewNum", txt員工編號.Text);
                cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                清除List();
                lvw員工資料.Clear();
                讀取員工資料();
                lvw員工資料顯示();
                txt員工編號.Clear();
                txt帳號.Clear();
                txt密碼.Clear();
                MessageBox.Show("帳號建立成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("所有欄位必填","提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn移除帳號_Click(object sender, EventArgs e)
        {
            if(lvw員工資料.SelectedItems.Count > 0)
            {
                DialogResult R = MessageBox.Show("確認要移除帳號嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(R == DialogResult.OK)
                {
                    int selIndex = lvw員工資料.SelectedItems[0].Index;
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "delete from EmployeeAccount where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", listID[selIndex]);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    清除List();
                    lvw員工資料.Clear();
                    讀取員工資料();
                    lvw員工資料顯示();
                    lbl員工編號.Text = "";
                    lbl帳號.Text = "";
                    txt員工密碼.Clear();
                }
            }
            else
            {
                MessageBox.Show("請選擇帳號", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lvw員工資料_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw員工資料.SelectedItems.Count > 0)
            {
                顯示指定員工資料();
            }
        }

        void 顯示指定員工資料()
        {
            if (lvw員工資料.SelectedItems.Count > 0)
            {
                int selIndex = lvw員工資料.SelectedItems[0].Index;
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from EmployeeAccount where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", listID[selIndex]);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbl員工編號.Text = reader["員工編號"].ToString();
                    lbl帳號.Text = reader["帳號"].ToString();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn變更密碼_Click(object sender, EventArgs e)
        {
            if (lvw員工資料.SelectedItems.Count > 0)
            {
                
                if(txt員工密碼.Text != "")
                {
                    int selIndex = lvw員工資料.SelectedItems[0].Index;
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update EmployeeAccount set 密碼 = @NewPassword where id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", listID[selIndex]);
                    cmd.Parameters.AddWithValue("@NewPassword", txt員工密碼.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("密碼已變更", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("請輸入變更密碼", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("請選擇帳號", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            清除List();
            lvw員工資料.Items.Clear();
            讀取搜尋員工資料();
            lvw員工資料顯示搜尋資料();
        }

        void 讀取搜尋員工資料()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from EmployeeAccount where "+ cbox搜尋欄位.SelectedItem + " like @Search";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Search", "%" + txt搜尋關鍵字.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listID.Add((int)reader["Id"]);
                listNum.Add((string)reader["員工編號"]);
                listAccount.Add((string)reader["帳號"]);
            }
            reader.Close();
            con.Close();
        }

        void lvw員工資料顯示搜尋資料()
        {
            lvw員工資料.View = View.Details;
            lvw員工資料.Columns.Add("Id", 60);
            lvw員工資料.Columns.Add("員工編號", 80);
            lvw員工資料.Columns.Add("員工帳號", 100);
            lvw員工資料.FullRowSelect = true;

            for (int i = 0; i < listID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listID[i].ToString();
                item.SubItems.Add(listNum[i]);
                item.SubItems.Add(listAccount[i]);
                lvw員工資料.Items.Add(item);
            }
        }

    }
}
