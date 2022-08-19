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
    public partial class OrderRecord : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> SearchIDs = new List<int>();

        public OrderRecord()
        {
            InitializeComponent();
        }

        private void OrderRecord_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            cbox搜尋欄位.Items.Add("姓名");
            cbox搜尋欄位.Items.Add("手機號碼");
            cbox搜尋欄位.SelectedIndex = 0;

            讀取會員訂單();
            讀取訪客訂單();
        }

        void 讀取會員訂單()
        {

            lvw已完成.View = View.Details;
            lvw已完成.Columns.Add("訂單編號", 200);
            lvw已完成.Columns.Add("訂單日期", 250);
            lvw已完成.Columns.Add("品名", 150);
            lvw已完成.Columns.Add("單價", 80);
            lvw已完成.Columns.Add("加料", 150);
            lvw已完成.Columns.Add("品項份數", 80);
            lvw已完成.Columns.Add("總價", 80);
            lvw已完成.Columns.Add("麵條", 80);
            lvw已完成.Columns.Add("湯頭", 80);
            lvw已完成.Columns.Add("蒜泥", 80);
            lvw已完成.Columns.Add("訂購人姓名", 100);
            lvw已完成.Columns.Add("訂購人電話", 150);

            lvw已取消.View = View.Details;
            lvw已取消.Columns.Add("訂單編號", 200);
            lvw已取消.Columns.Add("訂單日期", 250);
            lvw已取消.Columns.Add("品名", 150);
            lvw已取消.Columns.Add("單價", 80);
            lvw已取消.Columns.Add("加料", 150);
            lvw已取消.Columns.Add("品項份數", 80);
            lvw已取消.Columns.Add("總價", 80);
            lvw已取消.Columns.Add("麵條", 80);
            lvw已取消.Columns.Add("湯頭", 80);
            lvw已取消.Columns.Add("蒜泥", 80);
            lvw已取消.Columns.Add("訂購人姓名", 100);
            lvw已取消.Columns.Add("訂購人電話", 150);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList as ol join CustomerAccount as ca on ol.CustomerID = ca.Id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((string)reader["訂單狀態"] == "已完成")
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
                    lvw已完成.Items.Add(item);
                }
                if ((string)reader["訂單狀態"] == "已取消")
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
                    lvw已取消.Items.Add(item);
                }
            }
            reader.Close();
            con.Close();
        }

        void 讀取訪客訂單()
        {

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList as ol join GuestOrder as ga on ol.GuestID = ga.Id";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((string)reader["訂單狀態"] == "已完成")
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
                    lvw已完成.Items.Add(item);
                }
                if ((string)reader["訂單狀態"] == "已取消")
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
                    lvw已取消.Items.Add(item);
                }
            }
            reader.Close();
            con.Close();
        }

        void 讀取搜尋會員訂單()
        {
            lvw已完成.View = View.Details;
            lvw已完成.Columns.Add("訂單編號", 200);
            lvw已完成.Columns.Add("訂單日期", 250);
            lvw已完成.Columns.Add("品名", 150);
            lvw已完成.Columns.Add("單價", 80);
            lvw已完成.Columns.Add("加料", 150);
            lvw已完成.Columns.Add("品項份數", 80);
            lvw已完成.Columns.Add("總價", 80);
            lvw已完成.Columns.Add("麵條", 80);
            lvw已完成.Columns.Add("湯頭", 80);
            lvw已完成.Columns.Add("蒜泥", 80);
            lvw已完成.Columns.Add("訂購人姓名", 100);
            lvw已完成.Columns.Add("訂購人電話", 150);

            lvw已取消.View = View.Details;
            lvw已取消.Columns.Add("訂單編號", 200);
            lvw已取消.Columns.Add("訂單日期", 250);
            lvw已取消.Columns.Add("品名", 150);
            lvw已取消.Columns.Add("單價", 80);
            lvw已取消.Columns.Add("加料", 150);
            lvw已取消.Columns.Add("品項份數", 80);
            lvw已取消.Columns.Add("總價", 80);
            lvw已取消.Columns.Add("麵條", 80);
            lvw已取消.Columns.Add("湯頭", 80);
            lvw已取消.Columns.Add("蒜泥", 80);
            lvw已取消.Columns.Add("訂購人姓名", 100);
            lvw已取消.Columns.Add("訂購人電話", 150);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList as ol join CustomerAccount as ca on ol.CustomerID = ca.Id where ca." + cbox搜尋欄位.SelectedItem + " like @Search and (訂購日期 >= @StartDate and 訂購日期 <= @EndDate)";

            Console.WriteLine(strSQL);

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Search", "%" + txt搜尋關鍵字.Text + "%");
            cmd.Parameters.AddWithValue("@StartDate", dtp開始訂購.Value);
            cmd.Parameters.AddWithValue("@EndDate", dtp結束訂購.Value);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((string)reader["訂單狀態"] == "已完成")
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
                    lvw已完成.Items.Add(item);
                }
                if ((string)reader["訂單狀態"] == "已取消")
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
                    lvw已取消.Items.Add(item);
                }
            }
            reader.Close();
            con.Close();
        }

        void 讀取搜尋訪客訂單()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList as ol join GuestOrder as ga on ol.GuestID = ga.Id where ga." + cbox搜尋欄位.SelectedItem + " like @Search and (訂購日期 >= @StartDate and 訂購日期 <= @EndDate)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Search", "%" + txt搜尋關鍵字.Text + "%");
            cmd.Parameters.AddWithValue("@StartDate", dtp開始訂購.Value);
            cmd.Parameters.AddWithValue("@EndDate", dtp結束訂購.Value);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((string)reader["訂單狀態"] == "已完成")
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
                    lvw已完成.Items.Add(item);
                }
                if ((string)reader["訂單狀態"] == "已取消")
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
                    lvw已取消.Items.Add(item);
                }
            }
            reader.Close();
            con.Close();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            lvw已取消.Clear();
            lvw已完成.Clear();
            讀取搜尋會員訂單();
            讀取搜尋訪客訂單();
        }
    }
}
