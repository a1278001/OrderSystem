﻿using System;
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
    public partial class MyRecord : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<int> searchIDs = new List<int>();

        public MyRecord()
        {
            InitializeComponent();
        }

        private void MyRecord_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            cbox搜尋欄位.Items.Add("訂單編號");
            cbox搜尋欄位.Items.Add("品名");
            cbox搜尋欄位.SelectedIndex = 0;

            讀取訂單();
        }

        void 讀取訂單()
        {
            searchIDs.Clear();
            lvw已完成.Clear();
            lvw未完成.Clear();

            lvw未完成.View = View.Details;
            lvw未完成.Columns.Add("訂單編號", 190);
            lvw未完成.Columns.Add("訂購日期", 230);
            lvw未完成.Columns.Add("品名", 150);
            lvw未完成.Columns.Add("單價", 80);
            lvw未完成.Columns.Add("加料", 150);
            lvw未完成.Columns.Add("品項份數", 80);
            lvw未完成.Columns.Add("總價", 80);
            lvw未完成.Columns.Add("麵條", 80);
            lvw未完成.Columns.Add("湯頭", 80);
            lvw未完成.Columns.Add("蒜泥", 80);
            lvw未完成.FullRowSelect = true;

            lvw已完成.View = View.Details;
            lvw已完成.Columns.Add("訂單編號", 190);
            lvw已完成.Columns.Add("訂購日期", 230);
            lvw已完成.Columns.Add("品名", 150);
            lvw已完成.Columns.Add("單價", 80);
            lvw已完成.Columns.Add("加料", 150);
            lvw已完成.Columns.Add("品項份數", 80);
            lvw已完成.Columns.Add("總價", 80);
            lvw已完成.Columns.Add("麵條", 80);
            lvw已完成.Columns.Add("湯頭", 80);
            lvw已完成.Columns.Add("蒜泥", 80);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList where CustomerID = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID",GlobalVar.登入者ID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["訂單狀態"].ToString() == "未完成")
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
                    searchIDs.Add((int)reader["id"]);
                    lvw未完成.Items.Add(item);
                }
                if(reader["訂單狀態"].ToString() == "已完成")
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
                    item.Tag = reader["id"].ToString();
                    lvw已完成.Items.Add(item);
                }

            }
            reader.Close();
            con.Close();
        }

        private void btn取消訂單_Click(object sender, EventArgs e)
        {

            if (lvw未完成.SelectedItems.Count > 0)
            {
                DialogResult R = MessageBox.Show("確認要取消訂單嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "update OrderedList set 訂單狀態 = '已取消' where id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", searchIDs[lvw未完成.SelectedItems[0].Index]);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("訂單已取消", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    讀取訂單();
                }

            }
            else
            {
                MessageBox.Show("請選擇訂單", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            讀取指定訂單();
        }

        void 讀取指定訂單()
        {
            lvw未完成.Clear();
            lvw已完成.Clear();
            searchIDs.Clear();

            lvw未完成.View = View.Details;
            lvw未完成.Columns.Add("訂單編號", 190);
            lvw未完成.Columns.Add("訂購日期", 230);
            lvw未完成.Columns.Add("品名", 150);
            lvw未完成.Columns.Add("單價", 80);
            lvw未完成.Columns.Add("加料", 150);
            lvw未完成.Columns.Add("品項份數", 80);
            lvw未完成.Columns.Add("總價", 80);
            lvw未完成.Columns.Add("麵條", 80);
            lvw未完成.Columns.Add("湯頭", 80);
            lvw未完成.Columns.Add("蒜泥", 80);
            lvw未完成.FullRowSelect = true;

            lvw已完成.View = View.Details;
            lvw已完成.Columns.Add("訂單編號", 190);
            lvw已完成.Columns.Add("訂購日期", 230);
            lvw已完成.Columns.Add("品名", 150);
            lvw已完成.Columns.Add("單價", 80);
            lvw已完成.Columns.Add("加料", 150);
            lvw已完成.Columns.Add("品項份數", 80);
            lvw已完成.Columns.Add("總價", 80);
            lvw已完成.Columns.Add("麵條", 80);
            lvw已完成.Columns.Add("湯頭", 80);
            lvw已完成.Columns.Add("蒜泥", 80);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from OrderedList where CustomerID = @SearchID and " + cbox搜尋欄位.SelectedItem + " like @Search and (訂購日期 >= @StartDate and 訂購日期 <= @EndDate)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.登入者ID);
            cmd.Parameters.AddWithValue("@Search", "%" + txt搜尋關鍵字.Text + "%");
            cmd.Parameters.AddWithValue("@StartDate", dtp開始訂購.Value);
            cmd.Parameters.AddWithValue("@EndDate", dtp結束訂購.Value);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["訂單狀態"].ToString() == "未完成")
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
                    searchIDs.Add((int)reader["id"]);
                    lvw未完成.Items.Add(item);
                }
                if (reader["訂單狀態"].ToString() == "已完成")
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
                    item.Tag = reader["id"].ToString();
                    lvw已完成.Items.Add(item);
                }

            }
            reader.Close();
            con.Close();
        }
    }
}
