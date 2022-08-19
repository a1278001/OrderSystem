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
    public partial class MyFavourite : Form
    {
        double total = 0;
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        string image_dir = @"image\";
        string image_name = "";
        List<int> SearchIDs = new List<int>();
        string 產生訂單編號 = "";

        List<string> 品名List = new List<string>();
        List<int> 單價List = new List<int>();
        List<string> 加料List = new List<string>();
        List<int> 加料價格List = new List<int>();
        List<int> 加料單價List = new List<int>();
        List<int> 品項份數List = new List<int>();
        List<int> 品項總價List = new List<int>();
        List<string> 麵條List = new List<string>();
        List<string> 湯頭List = new List<string>();
        List<string> 蒜泥List = new List<string>();

        public MyFavourite()
        {
            InitializeComponent();
        }

        private void MyFavourite_Load(object sender, EventArgs e)
        {
            產生訂單編號 = GlobalVar.使用者身分.ToString() + DateTime.Now.ToString("yyMMddHHmm") + GlobalVar.登入者ID.ToString() + DateTime.Now.ToString("ss");

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            讀取最愛資料();
            lbl訂單總價.Text = total + "元";
        }

        void 讀取最愛資料()
        {
            SearchIDs.Clear();
            lvw我的最愛.Clear();
            lvw我的最愛.View = View.SmallIcon;
            imageList1.ImageSize = new Size(80, 80);
            lvw我的最愛.SmallImageList = imageList1;

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Myfavourite where CustomerID = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.登入者ID);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                string str最愛資訊 = string.Format("品名:{0} 單價:{1}元 加點:{2} 加點價格:{3}元 數量:{4}份 共:{5}元 麵條:{6} 湯頭:{7} 蒜泥:{8}", reader["品名"].ToString(), reader["單價"].ToString(), reader["加料"].ToString(), reader["加料價格"].ToString(), reader["品項份數"].ToString(), reader["品項總價"].ToString(), reader["麵條"].ToString(), reader["湯頭"].ToString(), reader["蒜泥"].ToString());
                image_name = reader["pimage"].ToString();
                SearchIDs.Add((int)reader["id"]);
                total += (int)reader["品項總價"];
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = str最愛資訊;
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                lvw我的最愛.Items.Add(item);

                
                品名List.Add((string)reader["品名"]);
                單價List.Add((int)reader["單價"]);
                加料List.Add((string)reader["加料"]);
                加料價格List.Add((int)reader["加料價格"]);
                加料單價List.Add((int)reader["加料單價"]);
                品項份數List.Add((int)reader["品項份數"]);
                品項總價List.Add((int)reader["品項總價"]);
                麵條List.Add((string)reader["麵條"]);
                湯頭List.Add((string)reader["湯頭"]);
                蒜泥List.Add((string)reader["蒜泥"]);

                i += 1;
            }
            reader.Close();
            con.Close();
        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if(lvw我的最愛.SelectedItems.Count > 0)
            {
                int selindex = lvw我的最愛.SelectedItems[0].Index;
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from Myfavourite where id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", SearchIDs[selindex]);
                cmd.ExecuteNonQuery();
                con.Close();
                lvw我的最愛.Items.RemoveAt(selindex);

                total -= 品項總價List[selindex];

                品名List.RemoveAt(selindex);
                單價List.RemoveAt(selindex);
                加料List.RemoveAt(selindex);
                加料價格List.RemoveAt(selindex);
                加料單價List.RemoveAt(selindex);
                品項份數List.RemoveAt(selindex);
                品項總價List.RemoveAt(selindex);
                麵條List.RemoveAt(selindex);
                湯頭List.RemoveAt(selindex);
                蒜泥List.RemoveAt(selindex);

            }
            else
            {
                MessageBox.Show("請選擇移除項目", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            lbl訂單總價.Text = total.ToString() + "元";
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確認要清空我的最愛嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(R == DialogResult.OK)
            {
                lvw我的最愛.Clear();
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from Myfavourite where CustomerID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", GlobalVar.登入者ID);
                cmd.ExecuteNonQuery();
                con.Close();
                lbl訂單總價.Text = "0元";
            }

        }

        private void btn指定下單_Click(object sender, EventArgs e)
        {
            
            if (lvw我的最愛.SelectedItems.Count > 0)
            {
                string 品名 = "";
                int 單價 = 0;
                string 加料 = "";
                int 加料價格 = 0;
                int 加料單價 = 0;
                int 品項份數 = 0;
                int 品項總價 = 0;
                string 麵條 = "";
                string 湯頭 = "";
                string 蒜泥 = "";

                int selindex = lvw我的最愛.SelectedItems[0].Index;
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from Myfavourite where CustomerID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", GlobalVar.登入者ID);
                SqlDataReader reader = cmd.ExecuteReader();
                for (int i = 0; i <= selindex; i += 1)
                {
                    if (reader.Read())
                    {
                        品名 = (string)reader["品名"];
                        單價 = (int)reader["單價"];
                        加料 = (string)reader["加料"];
                        加料價格 = (int)reader["加料價格"];
                        加料單價 = (int)reader["加料單價"];
                        品項份數 = (int)reader["品項份數"];
                        品項總價 = (int)reader["品項總價"];
                        麵條 = (string)reader["麵條"];
                        湯頭 = (string)reader["湯頭"];
                        蒜泥 = (string)reader["蒜泥"];
                    }
                }
                reader.Close();

                int 目前庫存 = 0;
                string strSQL2 = "select * from Products where pname = @NewName";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("NewName", 品名);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    目前庫存 = (int)reader2["pstock"];
                }
                reader2.Close();

                if (目前庫存 > 品項份數)
                {
                    int 剩餘庫存 = 目前庫存 - 品項份數;
                    string strSQL3 = "update Products set pstock = @NewStock where pname = @SearchName";
                    SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                    cmd3.Parameters.AddWithValue("@SearchName", 品名);
                    cmd3.Parameters.AddWithValue("@NewStock", 剩餘庫存);
                    cmd3.ExecuteNonQuery();

                    string strSQL4 = "insert into OrderedList values (@NewCustomerID, NULL,@NewOrderNum,@NewOrderDate,@NewName,@NewUnitPrice,@NewAdd,@NewAddPrice,@NewAddUnitPrice,@NewNum,@NewTotalPrice,@NewNoodle,@NewSoup,@NewGarlic,'未完成');";
                    SqlCommand cmd4 = new SqlCommand(strSQL4, con);
                    cmd4.Parameters.AddWithValue("@NewCustomerID", GlobalVar.登入者ID);
                    cmd4.Parameters.AddWithValue("@NewOrderNum", 產生訂單編號);
                    cmd4.Parameters.AddWithValue("@NewOrderDate", DateTime.Now);
                    cmd4.Parameters.AddWithValue("@NewName", 品名);
                    cmd4.Parameters.AddWithValue("@NewUnitPrice", 單價);
                    cmd4.Parameters.AddWithValue("@NewAdd", 加料);
                    cmd4.Parameters.AddWithValue("@NewAddPrice", 加料價格);
                    cmd4.Parameters.AddWithValue("@NewAddUnitPrice", 加料單價);
                    cmd4.Parameters.AddWithValue("@NewNum", 品項份數);
                    cmd4.Parameters.AddWithValue("@NewTotalPrice", 品項總價);
                    cmd4.Parameters.AddWithValue("@NewNoodle", 麵條);
                    cmd4.Parameters.AddWithValue("@NewSoup", 湯頭);
                    cmd4.Parameters.AddWithValue("@NewGarlic", 蒜泥);
                    cmd4.ExecuteNonQuery();
                    MessageBox.Show("訂單已送出，感謝您的訂購", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("庫存不足，請重新選購", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
                產生訂單編號 = GlobalVar.使用者身分.ToString() + DateTime.Now.ToString("yyMMddHHmm") + GlobalVar.登入者ID.ToString() + DateTime.Now.ToString("ss");
            }
            else
            {
                MessageBox.Show("請選擇訂購項目", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn全部下單_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確認要全部下單嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (R == DialogResult.OK)
            {
                if (lvw我的最愛.Items.Count > 0)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    int 目前庫存 = 0;
                    bool 庫存足夠判定 = true;
                    for (int i = 0; i < 品名List.Count; i += 1)
                    {
                        string strSQL2 = "select * from Products where pname = @NewName";
                        SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                        cmd2.Parameters.AddWithValue("NewName", 品名List[i]);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        if (reader.Read())
                        {
                            目前庫存 = (int)reader["pstock"];
                        }
                        reader.Close();

                        if (目前庫存 > 品項份數List[i])
                        {

                        }
                        else
                        {
                            庫存足夠判定 = false;
                        }
                    }

                    if (庫存足夠判定 == true)
                    {
                        for (int i = 0; i < 品名List.Count; i += 1)
                        {
                            string strSQL2 = "select * from Products where pname = @NewName";
                            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                            cmd2.Parameters.AddWithValue("NewName", 品名List[i]);
                            SqlDataReader reader = cmd2.ExecuteReader();
                            if (reader.Read())
                            {
                                目前庫存 = (int)reader["pstock"];
                            }
                            reader.Close();

                            int 剩餘庫存 = 目前庫存 - 品項份數List[i];
                            string strSQL3 = "update Products set pstock = @NewStock where pname = @SearchName";
                            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                            cmd3.Parameters.AddWithValue("@SearchName", 品名List[i]);
                            cmd3.Parameters.AddWithValue("@NewStock", 剩餘庫存);
                            cmd3.ExecuteNonQuery();

                            string strSQL = "insert into OrderedList values (@NewCustomerID, NULL,@NewOrderNum,@NewOrderDate,@NewName,@NewUnitPrice,@NewAdd,@NewAddPrice,@NewAddUnitPrice,@NewNum,@NewTotalPrice,@NewNoodle,@NewSoup,@NewGarlic,'未完成');";
                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewCustomerID", GlobalVar.登入者ID);
                            cmd.Parameters.AddWithValue("@NewOrderNum", 產生訂單編號);
                            cmd.Parameters.AddWithValue("@NewOrderDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@NewName", 品名List[i]);
                            cmd.Parameters.AddWithValue("@NewUnitPrice", 單價List[i]);
                            cmd.Parameters.AddWithValue("@NewAdd", 加料List[i]);
                            cmd.Parameters.AddWithValue("@NewAddPrice", 加料價格List[i]);
                            cmd.Parameters.AddWithValue("@NewAddUnitPrice", 加料單價List[i]);
                            cmd.Parameters.AddWithValue("@NewNum", 品項份數List[i]);
                            cmd.Parameters.AddWithValue("@NewTotalPrice", 品項總價List[i]);
                            cmd.Parameters.AddWithValue("@NewNoodle", 麵條List[i]);
                            cmd.Parameters.AddWithValue("@NewSoup", 湯頭List[i]);
                            cmd.Parameters.AddWithValue("@NewGarlic", 蒜泥List[i]);
                            cmd.ExecuteNonQuery();

                        }
                        MessageBox.Show("訂單已送出，感謝您的訂購", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        產生訂單編號 = GlobalVar.使用者身分.ToString() + DateTime.Now.ToString("yyMMddHHmm") + GlobalVar.登入者ID.ToString() + DateTime.Now.ToString("ss");
                    }
                    else
                    {
                        MessageBox.Show("訂單內有商品庫存不足，請重新選購", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("無訂購餐點", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            
        }

        private void lvw我的最愛_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw我的最愛.SelectedItems.Count > 0)
            {
                int 品項總價 = 0;
                int selindex = lvw我的最愛.SelectedItems[0].Index;
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from Myfavourite where CustomerID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", GlobalVar.登入者ID);
                SqlDataReader reader = cmd.ExecuteReader();
                for (int i = 0; i <= selindex; i += 1)
                {
                    if (reader.Read())
                    {
                        品項總價 = (int)reader["品項總價"];
                    }
                }
                reader.Close();
                con.Close();
                lbl訂單總價.Text = 品項總價.ToString() + "元";
            }
        }
    }
}
