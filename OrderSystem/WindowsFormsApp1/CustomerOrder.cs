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
    public partial class CustomerOrder : Form
    {
        double total = 0;
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public CustomerOrder()
        {
            InitializeComponent();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            lbl訂單編號.Text = GlobalVar.使用者身分.ToString() + DateTime.Now.ToString("yyMMddHHmm") + GlobalVar.登入者ID.ToString() + DateTime.Now.ToString("ss");

            lbl訂購人資訊.Text = GlobalVar.使用者名稱 + " " + GlobalVar.使用者電話;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            計算訂單總價();
            listView圖片資訊顯示();

            timer1.Start();
        }

        void listView圖片資訊顯示()
        {
            listView1.Clear();
            listView1.View = View.SmallIcon;
            imageList1.ImageSize = new Size(80, 80);
            listView1.SmallImageList = imageList1;

            for (int i = 0; i < GlobalVar.OrderList.Count; i += 1)
            {
                Order order1 = GlobalVar.OrderList[i];
                string str訂單資訊 = string.Format("品名:{0} 單價:{1}元 加點:{2} 加點價格:{3}元 數量:{4}份 共:{5}元 麵條:{6} 湯頭:{7} 蒜泥:{8}", order1.品名, order1.單價, order1.加料, order1.加料價格, order1.品項份數, order1.品項總價, order1.麵條, order1.湯頭, order1.蒜泥);

                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = str訂單資訊;
                imageList1.Images.Add(Image.FromFile(order1.image));
                listView1.Items.Add(item);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl訂購時間.Text = DateTime.Now.ToString("yyyy/MM/dd ddd HH:mm");
        }

        void 計算訂單總價()
        {
            total = 0;
            
            foreach(Order order1 in GlobalVar.OrderList)
            {
                total += order1.品項總價;
            }
            lbl訂單總價.Text = total.ToString() + "元";
        }

        private void btn下單_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確認要下單嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(R == DialogResult.OK)
            {
                if (listView1.Items.Count > 0)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    int 目前庫存 = 0;
                    bool 庫存足夠判定 = true;
                    for (int i = 0; i < GlobalVar.OrderList.Count; i += 1)
                    {
                        Order order1 = GlobalVar.OrderList[i];

                        string strSQL2 = "select * from Products where pname = @NewName";
                        SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                        cmd2.Parameters.AddWithValue("NewName", order1.品名);
                        SqlDataReader reader = cmd2.ExecuteReader();
                        if (reader.Read())
                        {
                            目前庫存 = (int)reader["pstock"];
                        }
                        reader.Close();

                        if (目前庫存 > order1.品項份數)
                        {

                        }
                        else
                        {
                            庫存足夠判定 = false;
                        }
                    }

                    if (庫存足夠判定 == true)
                    {
                        for (int i = 0; i < GlobalVar.OrderList.Count; i += 1)
                        {
                            Order order1 = GlobalVar.OrderList[i];

                            string strSQL2 = "select * from Products where pname = @NewName";
                            SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                            cmd2.Parameters.AddWithValue("NewName", order1.品名);
                            SqlDataReader reader = cmd2.ExecuteReader();
                            if (reader.Read())
                            {
                                目前庫存 = (int)reader["pstock"];
                            }
                            reader.Close();

                            int 剩餘庫存 = 目前庫存 - order1.品項份數;
                            string strSQL3 = "update Products set pstock = @NewStock where pname = @SearchName";
                            SqlCommand cmd3 = new SqlCommand(strSQL3, con);
                            cmd3.Parameters.AddWithValue("@SearchName", order1.品名);
                            cmd3.Parameters.AddWithValue("@NewStock", 剩餘庫存);
                            cmd3.ExecuteNonQuery();

                            if (GlobalVar.登入帳號 != "")
                            {
                                string strSQL = "insert into OrderedList values (@NewCustomerID, NULL,@NewOrderNum,@NewOrderDate,@NewName,@NewUnitPrice,@NewAdd,@NewAddPrice,@NewAddUnitPrice,@NewNum,@NewTotalPrice,@NewNoodle,@NewSoup,@NewGarlic,'未完成');";
                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@NewCustomerID", GlobalVar.登入者ID);
                                cmd.Parameters.AddWithValue("@NewOrderNum", lbl訂單編號.Text);
                                cmd.Parameters.AddWithValue("@NewOrderDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@NewName", order1.品名);
                                cmd.Parameters.AddWithValue("@NewUnitPrice", order1.單價);
                                cmd.Parameters.AddWithValue("@NewAdd", order1.加料);
                                cmd.Parameters.AddWithValue("@NewAddPrice", order1.加料價格);
                                cmd.Parameters.AddWithValue("@NewAddUnitPrice", order1.加料單價);
                                cmd.Parameters.AddWithValue("@NewNum", order1.品項份數);
                                cmd.Parameters.AddWithValue("@NewTotalPrice", order1.品項總價);
                                cmd.Parameters.AddWithValue("@NewNoodle", order1.麵條);
                                cmd.Parameters.AddWithValue("@NewSoup", order1.蒜泥);
                                cmd.Parameters.AddWithValue("@NewGarlic", order1.蒜泥);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                string strSQL = "insert into OrderedList values (NULL, @NewGuestID,@NewOrderNum,@NewOrderDate,@NewName,@NewUnitPrice,@NewAdd,@NewAddPrice,@NewAddUnitPrice,@NewNum,@NewTotalPrice,@NewNoodle,@NewSoup,@NewGarlic,'未完成');";
                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@NewGuestID", GlobalVar.登入者ID);
                                cmd.Parameters.AddWithValue("@NewOrderNum", lbl訂單編號.Text);
                                cmd.Parameters.AddWithValue("@NewOrderDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@NewName", order1.品名);
                                cmd.Parameters.AddWithValue("@NewUnitPrice", order1.單價);
                                cmd.Parameters.AddWithValue("@NewAdd", order1.加料);
                                cmd.Parameters.AddWithValue("@NewAddPrice", order1.加料價格);
                                cmd.Parameters.AddWithValue("@NewAddUnitPrice", order1.加料單價);
                                cmd.Parameters.AddWithValue("@NewNum", order1.品項份數);
                                cmd.Parameters.AddWithValue("@NewTotalPrice", order1.品項總價);
                                cmd.Parameters.AddWithValue("@NewNoodle", order1.麵條);
                                cmd.Parameters.AddWithValue("@NewSoup", order1.蒜泥);
                                cmd.Parameters.AddWithValue("@NewGarlic", order1.蒜泥);
                                cmd.ExecuteNonQuery();
                            }

                        }
                        MessageBox.Show("訂單已送出，感謝您的訂購", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl訂單編號.Text = GlobalVar.使用者身分.ToString() + DateTime.Now.ToString("yyMMddHHmm") + GlobalVar.登入者ID.ToString() + DateTime.Now.ToString("ss");

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

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count > 0)
            {
                int selIndex = listView1.SelectedItems[0].Index;
                listView1.Items.RemoveAt(selIndex);
                GlobalVar.OrderList.RemoveAt(selIndex);
            }
            計算訂單總價();
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確認要清空嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if(R == DialogResult.OK)
            {
                listView1.Items.Clear();
                GlobalVar.OrderList.Clear();
                計算訂單總價();
            }

        }
    }
}
