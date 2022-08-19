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
    public partial class CustomerInterface : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listId = new List<int>();
        List<string> listAdd = new List<string>();
        List<int> listAddPrice = new List<int>();

        int 品項份數 = 0;
        int 單價 = 0;
        int 加料單價 = 0;
        int 品項總價 = 0;
        string 品名 = "";
        string 加料 = "";
        string 麵條 = "";
        string 湯頭 = "";
        string 蒜泥 = "";
        int 加料價格 = 0;
        string image = "";
        string image_dir = @"image\";
        string image_name = "";

        public CustomerInterface()
        {
            InitializeComponent();
        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            lbl使用者名稱.Text = GlobalVar.使用者名稱 + "，歡迎使用";

            讀取商品資訊();
            讀取配料資訊();


            string[] 麵條 = new string[] { "超硬", "硬", "普通", "軟", "超軟" };
            cbox硬度.Items.AddRange(麵條);
            cbox硬度.SelectedIndex = 2;
            
            string[] 湯頭 = new string[] { "超清淡", "清淡", "普通", "濃郁", "超濃郁" };
            cbox湯頭.Items.AddRange(湯頭);
            cbox湯頭.SelectedIndex = 2;

            string[] 蒜泥 = new string[] { "無", "少許", "普通", "1/2份", "1份" };
            cbox蒜泥.Items.AddRange(蒜泥);
            cbox蒜泥.SelectedIndex = 2;

            txt數量.Text = "1";
            品項份數 = 1;

            if(GlobalVar.登入判定 == false)
            {
                btn加入最愛.Enabled = false;
            }
        }

        void 讀取商品資訊()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Products where pstatic = '上架';";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listName.Add((string)reader["pname"]);
                listPrice.Add((int)reader["price"]);
                listId.Add((int)reader["id"]);
                lbox品項名稱.Items.Add((string)reader["pname"] + " " + (int)reader["price"] + "元");
            }
            reader.Close();
            con.Close();
        }

        void 讀取配料資訊()
        {
            SqlConnection con2 = new SqlConnection(myDBConnectionString);
            con2.Open();
            string strSQL2 = "select * from AddOrder;";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                lbox追加品項.Items.Add((string)reader2["pname"] + " " + (int)reader2["price"] + "元");
                listAdd.Add((string)reader2["pname"]);
                listAddPrice.Add((int)reader2["price"]);
            }
            reader2.Close();
            con2.Close();
        }

        void 顯示商品資訊()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Products where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", lbox品項名稱.SelectedIndex + 1);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                image_name = reader["pimage"].ToString();
                lbl商品介紹.Text = reader["pdesc"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir + image_name);
                image = string.Format("{0}{1}",image_dir,image_name);
                lbl庫存.Text = reader["pstock"].ToString();
                i += 1;
            }
            reader.Close();
            con.Close();
        }

        private void lbox品項名稱_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbox追加品項.SelectedItems.Clear();
            int selIndex = lbox品項名稱.SelectedIndex;
            品名 = listName[selIndex];
            單價 = listPrice[selIndex];
            顯示商品資訊();
            計算單價及總價();
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            bool sucess = int.TryParse(txt數量.Text, out int result);
            if (txt數量.Text != "")
            {
                if (sucess == true)
                {
                    品項份數 = Convert.ToInt32(txt數量.Text);
                    計算單價及總價();
                }
                else
                {
                    MessageBox.Show("請輸入整數", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt數量.Text = "1";
                    品項份數 = 1;
                }
            }
        }

        void 計算單價及總價()
        {
            品項總價 = 單價 * 品項份數;
            lbl單價.Text = 單價.ToString();
            lbl總價.Text = 品項總價.ToString();
            加料單價 = 單價 + 加料價格;
            if ((加料單價 != 0) && (加料單價 != 單價))
            {
                品項總價 = 加料單價 * 品項份數;
                lbl單價.Text = 加料單價.ToString();
                lbl總價.Text = 品項總價.ToString();
            }
        }

        private void lbox追加品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            加料 = "";
            加料價格 = 0;
            foreach(int index in lbox追加品項.SelectedIndices)
            {
                加料 += listAdd[index] + " ";
                加料價格 += listAddPrice[index];
            }
            計算單價及總價();
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            int ProductStock = 0;
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Products where id = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", lbox品項名稱.SelectedIndex + 1);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ProductStock = (int)reader["pstock"];
            }

            if((ProductStock - 品項份數) >= 0)
            {
                Order order1 = new Order();
                order1.品名 = 品名;
                order1.單價 = 單價;
                order1.加料單價 = 加料單價;
                order1.品項份數 = 品項份數;
                order1.品項總價 = 品項總價;
                order1.麵條 = 麵條;
                order1.湯頭 = 湯頭;
                order1.蒜泥 = 蒜泥;
                order1.加料 = 加料;
                order1.加料價格 = 加料價格;
                order1.image = image;
                GlobalVar.OrderList.Add(order1);
                MessageBox.Show("已加入訂單", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("很抱歉，庫存不足", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btn查看訂單_Click(object sender, EventArgs e)
        {
            GlobalVar.form點餐畫面 = this;
            CustomerOrder form訂單資訊 = new CustomerOrder();
            GlobalVar.form訂單資訊 = form訂單資訊;
            form訂單資訊.Show();
            this.Hide();
        }

        private void btn加入最愛_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "insert into MyFavourite values (@NewCustomerID,@New品名,@New單價,@New加料,@New加料價格,@New加料單價,@New品項份數,@New品項總價,@New麵條,@New湯頭,@New蒜泥,@NewImage);";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@NewCustomerID", GlobalVar.登入者ID);
            cmd.Parameters.AddWithValue("@New品名", 品名);
            cmd.Parameters.AddWithValue("@New單價", 單價);
            cmd.Parameters.AddWithValue("@New加料", 加料);
            cmd.Parameters.AddWithValue("@New加料價格", 加料價格);
            cmd.Parameters.AddWithValue("@New加料單價", 加料單價);
            cmd.Parameters.AddWithValue("@New品項份數", 品項份數);
            cmd.Parameters.AddWithValue("@New品項總價", 品項總價);
            cmd.Parameters.AddWithValue("@New麵條", 麵條);
            cmd.Parameters.AddWithValue("@New湯頭", 湯頭);
            cmd.Parameters.AddWithValue("@New蒜泥", 蒜泥);
            cmd.Parameters.AddWithValue("@NewImage", image_name);

            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("已加入我的最愛", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbox硬度_SelectedIndexChanged(object sender, EventArgs e)
        {
            麵條 = cbox硬度.SelectedItem.ToString();
        }

        private void cbox湯頭_SelectedIndexChanged(object sender, EventArgs e)
        {
            湯頭 = cbox湯頭.SelectedItem.ToString();
        }

        private void cbox蒜泥_SelectedIndexChanged(object sender, EventArgs e)
        {
            蒜泥 = cbox蒜泥.SelectedItem.ToString();
        }
    }
}
