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
    public partial class CustomerAccountManagement : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> listID = new List<int>();
        List<string> listAccount = new List<string>();
        List<string> listName = new List<string>();
        List<string> listPhone = new List<string>();
        List<string> listAddress = new List<string>();
        List<string> listEmail = new List<string>();
        List<DateTime> listBirthday = new List<DateTime>();
        List<int> listPoint = new List<int>();

        public CustomerAccountManagement()
        {
            InitializeComponent();
        }

        private void CustomerAccountManagement_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            cbox搜尋欄位.Items.Add("帳號");
            cbox搜尋欄位.Items.Add("姓名");
            cbox搜尋欄位.Items.Add("手機號碼");
            cbox搜尋欄位.Items.Add("地址");
            cbox搜尋欄位.Items.Add("Email");
            cbox搜尋欄位.Items.Add("點數");
            cbox搜尋欄位.SelectedIndex = 0;

            讀取會員資料();
            lvw會員資料顯示();
        }

        void 讀取會員資料()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from CustomerAccount";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listID.Add((int)reader["Id"]);
                listAccount.Add((string)reader["帳號"]);
                listName.Add((string)reader["姓名"]);
                listPhone.Add((string)reader["手機號碼"]);
                listAddress.Add((string)reader["地址"]);
                listEmail.Add((string)reader["Email"]);
                listBirthday.Add((DateTime)reader["生日"]);
                listPoint.Add((int)reader["點數"]);
            }
            reader.Close();
            con.Close();
        }

        void 讀取指定會員資料()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from CustomerAccount where " + cbox搜尋欄位.SelectedItem + " like @Search and (生日 >= @StartDate and 生日 <= @EndDate)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Search", "%" + txt搜尋關鍵字.Text + "%");
            cmd.Parameters.AddWithValue("@StartDate", dtp開始生日.Value);
            cmd.Parameters.AddWithValue("@EndDate", dtp結束生日.Value);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listID.Add((int)reader["Id"]);
                listAccount.Add((string)reader["帳號"]);
                listName.Add((string)reader["姓名"]);
                listPhone.Add((string)reader["手機號碼"]);
                listAddress.Add((string)reader["地址"]);
                listEmail.Add((string)reader["Email"]);
                listBirthday.Add((DateTime)reader["生日"]);
                listPoint.Add((int)reader["點數"]);
            }
            reader.Close();
            con.Close();
        }

        void lvw會員資料顯示()
        {
            lvw會員資料.View = View.Details;
            lvw會員資料.Columns.Add("會員Id", 60);
            lvw會員資料.Columns.Add("會員帳號", 120);
            lvw會員資料.Columns.Add("會員姓名", 80);
            lvw會員資料.Columns.Add("手機號碼", 150);
            lvw會員資料.Columns.Add("地址", 150);
            lvw會員資料.Columns.Add("Email", 200);
            lvw會員資料.Columns.Add("生日", 150);
            lvw會員資料.Columns.Add("點數", 80);
            lvw會員資料.FullRowSelect = true;

            for (int i = 0; i < listID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listID[i].ToString();
                item.SubItems.Add(listAccount[i]);
                item.SubItems.Add(listName[i]);
                item.SubItems.Add(listPhone[i]);
                item.SubItems.Add(listAddress[i]);
                item.SubItems.Add(listEmail[i]);
                item.SubItems.Add(listBirthday[i].ToString("yyyy/MM/dd"));
                item.SubItems.Add(listPoint[i].ToString());
                lvw會員資料.Items.Add(item);
            }
        }

        void 清除list()
        {
            listID.Clear();
            listAccount.Clear();
            listName.Clear();
            listPhone.Clear();
            listAddress.Clear();
            listEmail.Clear();
            listBirthday.Clear();
            listPoint.Clear();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            lvw會員資料.Items.Clear();
            清除list();
            讀取指定會員資料();
            lvw會員資料顯示();
        }

        private void btn停權_Click(object sender, EventArgs e)
        {
            if (lvw會員資料.SelectedItems.Count > 0)
            {
                DialogResult R = MessageBox.Show("確認要停權嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(R == DialogResult.OK)
                {
                    int selIndex = lvw會員資料.SelectedItems[0].Index;
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update CustomerAccount set 停權 = 1 where id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", listID[selIndex]);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("會員已停權", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("請選擇會員", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn黑名單_Click(object sender, EventArgs e)
        {
            if (lvw會員資料.SelectedItems.Count > 0)
            {
                DialogResult R = MessageBox.Show("確認要加入黑名單嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(R == DialogResult.OK)
                {
                    int selIndex = lvw會員資料.SelectedItems[0].Index;
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update CustomerAccount set 黑名單 = 1 where id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", listID[selIndex]);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("已加入黑名單", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("請選擇會員", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn解除黑名單_Click(object sender, EventArgs e)
        {
            if (lvw會員資料.SelectedItems.Count > 0)
            {
                int selIndex = lvw會員資料.SelectedItems[0].Index;
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update CustomerAccount set 黑名單 = 0 where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", listID[selIndex]);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("已解除黑名單", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("請選擇會員", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn解除停權_Click(object sender, EventArgs e)
        {
            if (lvw會員資料.SelectedItems.Count > 0)
            {
                int selIndex = lvw會員資料.SelectedItems[0].Index;
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update CustomerAccount set 停權 = 0 where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", listID[selIndex]);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("會員已復權", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("請選擇會員", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
