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
    public partial class OrderedManagement : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> SearchIDs = new List<int>();

        public OrderedManagement()
        {
            InitializeComponent();
        }

        private void OrderedManagement_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            cbox搜尋欄位.Items.Add("姓名");
            cbox搜尋欄位.Items.Add("手機號碼");
            cbox搜尋欄位.SelectedIndex = 0;

            讀取訂單();
            讀取訪客訂單();

        }

        void 讀取訂單()
        {
            SearchIDs.Clear();

            lvw未完成.View = View.Details;
            lvw未完成.Columns.Add("訂單編號", 200);
            lvw未完成.Columns.Add("訂購日期", 250);
            lvw未完成.Columns.Add("品名", 150);
            lvw未完成.Columns.Add("單價", 80);
            lvw未完成.Columns.Add("加料", 150);
            lvw未完成.Columns.Add("品項份數", 80);
            lvw未完成.Columns.Add("總價", 80);
            lvw未完成.Columns.Add("麵條", 80);
            lvw未完成.Columns.Add("湯頭", 80);
            lvw未完成.Columns.Add("蒜泥", 80);
            lvw未完成.Columns.Add("訂購人姓名", 100);
            lvw未完成.Columns.Add("訂單人電話", 150);
            lvw未完成.FullRowSelect = true;


            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList as ol join CustomerAccount as ca on ol.CustomerID = ca.Id where 訂單狀態 = '未完成'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = reader["訂單編號"].ToString();
                item.SubItems.Add(reader["訂購日期"].ToString());
                item.SubItems.Add(reader["品名"].ToString());
                item.SubItems.Add(reader["單價"].ToString());
                item.SubItems.Add(reader["加料"].ToString());
                item.SubItems.Add(reader["品項份數"].ToString());
                item.SubItems.Add(reader["品項總價"].ToString());
                item.SubItems.Add(reader["麵條"].ToString());
                item.SubItems.Add(reader["湯頭"].ToString());
                item.SubItems.Add(reader["蒜泥"].ToString());
                item.SubItems.Add(reader["姓名"].ToString());
                item.SubItems.Add(reader["手機號碼"].ToString());
                SearchIDs.Add((int)reader["id"]);
                lvw未完成.Items.Add(item);

            }
            reader.Close();
            con.Close();
        }

        void 讀取訪客訂單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList as ol join GuestOrder as ga on ol.GuestID = ga.Id where 訂單狀態 = '未完成'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = reader["訂單編號"].ToString();
                item.SubItems.Add(reader["訂購日期"].ToString());
                item.SubItems.Add(reader["品名"].ToString());
                item.SubItems.Add(reader["單價"].ToString());
                item.SubItems.Add(reader["加料"].ToString());
                item.SubItems.Add(reader["品項份數"].ToString());
                item.SubItems.Add(reader["品項總價"].ToString());
                item.SubItems.Add(reader["麵條"].ToString());
                item.SubItems.Add(reader["湯頭"].ToString());
                item.SubItems.Add(reader["蒜泥"].ToString());
                item.SubItems.Add(reader["姓名"].ToString());
                item.SubItems.Add(reader["手機號碼"].ToString());
                SearchIDs.Add((int)reader["id"]);
                lvw未完成.Items.Add(item);

            }
            reader.Close();
            con.Close();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            SearchIDs.Clear();
            lvw未完成.Clear();
            lvw未完成.View = View.Details;
            lvw未完成.Columns.Add("訂單編號", 200);
            lvw未完成.Columns.Add("訂購日期", 250);
            lvw未完成.Columns.Add("品名", 150);
            lvw未完成.Columns.Add("單價", 80);
            lvw未完成.Columns.Add("加料", 150);
            lvw未完成.Columns.Add("品項份數", 80);
            lvw未完成.Columns.Add("總價", 80);
            lvw未完成.Columns.Add("麵條", 80);
            lvw未完成.Columns.Add("湯頭", 80);
            lvw未完成.Columns.Add("蒜泥", 80);
            lvw未完成.Columns.Add("訂購人姓名", 100);
            lvw未完成.Columns.Add("訂單人電話", 150);
            lvw未完成.FullRowSelect = true;
            讀取搜尋會員訂單();
            讀取搜尋訪客訂單();
        }

        void 讀取搜尋會員訂單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList as ol join CustomerAccount as ca on ol.CustomerID = ca.Id where ca." + cbox搜尋欄位.SelectedItem + " like @Search and 訂單狀態 = '未完成'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Search","%" + txt搜尋關鍵字.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = reader["訂單編號"].ToString();
                item.SubItems.Add(reader["訂購日期"].ToString());
                item.SubItems.Add(reader["品名"].ToString());
                item.SubItems.Add(reader["單價"].ToString());
                item.SubItems.Add(reader["加料"].ToString());
                item.SubItems.Add(reader["品項份數"].ToString());
                item.SubItems.Add(reader["品項總價"].ToString());
                item.SubItems.Add(reader["麵條"].ToString());
                item.SubItems.Add(reader["湯頭"].ToString());
                item.SubItems.Add(reader["蒜泥"].ToString());
                item.SubItems.Add(reader["姓名"].ToString());
                item.SubItems.Add(reader["手機號碼"].ToString());
                SearchIDs.Add((int)reader["id"]);
                lvw未完成.Items.Add(item);
            }
            reader.Close();
            con.Close();
        }

        void 讀取搜尋訪客訂單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList as ol join GuestOrder as ga on ol.GuestID = ga.Id where ga." + cbox搜尋欄位.SelectedItem + " like @Search and 訂單狀態 = '未完成'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Search", "%" + txt搜尋關鍵字.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = reader["訂單編號"].ToString();
                item.SubItems.Add(reader["訂購日期"].ToString());
                item.SubItems.Add(reader["品名"].ToString());
                item.SubItems.Add(reader["單價"].ToString());
                item.SubItems.Add(reader["加料"].ToString());
                item.SubItems.Add(reader["品項份數"].ToString());
                item.SubItems.Add(reader["品項總價"].ToString());
                item.SubItems.Add(reader["麵條"].ToString());
                item.SubItems.Add(reader["湯頭"].ToString());
                item.SubItems.Add(reader["蒜泥"].ToString());
                item.SubItems.Add(reader["姓名"].ToString());
                item.SubItems.Add(reader["手機號碼"].ToString());
                SearchIDs.Add((int)reader["id"]);
                lvw未完成.Items.Add(item);
            }
            reader.Close();
            con.Close();
        }

        private void btn完成訂單_Click(object sender, EventArgs e)
        {
            if (lvw未完成.SelectedItems.Count > 0)
            {
                DialogResult R = MessageBox.Show("訂單確認已完成嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update OrderedList set 訂單狀態 = '已完成' where id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", SearchIDs[lvw未完成.SelectedItems[0].Index]);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("訂單已完成", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvw未完成.Clear();
                    cbox搜尋欄位.SelectedIndex = 0;
                    txt搜尋關鍵字.Text = "";
                    讀取訂單();
                    讀取訪客訂單();
                }

            }
            else
            {
                MessageBox.Show("請選擇訂單", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn取消訂單_Click(object sender, EventArgs e)
        {
            if (lvw未完成.SelectedItems.Count > 0)
            {
                DialogResult R = MessageBox.Show("確認要取消訂單嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if(R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update OrderedList set 訂單狀態 = '已取消' where id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", SearchIDs[lvw未完成.SelectedItems[0].Index]);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("訂單已取消", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvw未完成.Clear();
                    cbox搜尋欄位.SelectedIndex = 0;
                    txt搜尋關鍵字.Text = "";
                    讀取訂單();
                    讀取訪客訂單();
                }

            }
            else
            {
                MessageBox.Show("請選擇訂單", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn重新載入_Click(object sender, EventArgs e)
        {
            lvw未完成.Clear();
            cbox搜尋欄位.SelectedIndex = 0;
            txt搜尋關鍵字.Text = "";
            讀取訂單();
            讀取訪客訂單();
        }
    }
}
