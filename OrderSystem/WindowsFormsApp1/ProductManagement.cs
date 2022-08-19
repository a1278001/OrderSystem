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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ProductManagement : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        string image_dir = @"image\";
        string image_name = "";
        bool is已修改圖檔 = false;
        List<int> SearchIDs = new List<int>();

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "OrderSystem";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            讀取商品資訊();

            btn商品儲存.Enabled = false;
        }

        void 讀取商品資訊()
        {
            lbox訂單列表.Items.Clear();
            SearchIDs.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbox訂單列表.Items.Add(reader["pname"].ToString());
                SearchIDs.Add((int)reader["id"]);
            }
            lbox訂單列表.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        private void lbox訂單列表_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Products where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", SearchIDs[lbox訂單列表.SelectedIndex]);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txt商品名稱.Text = reader["pname"].ToString();
                txt商品價格.Text = reader["price"].ToString();
                txt商品庫存.Text = reader["pstock"].ToString();
                txt商品介紹.Text = reader["pdesc"].ToString();
                image_name = reader["pimage"].ToString();
                pictureBox1.Image = Image.FromFile(image_dir+image_name);
            }
            reader.Close();
            con.Close();
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            if(lbox訂單列表.SelectedIndex > 0)
            {
                DialogResult R = MessageBox.Show("確認要修改資料嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    Console.WriteLine(image_name);
                    if (is已修改圖檔 == true)
                    {
                        pictureBox1.Image.Save(image_dir + image_name);
                        is已修改圖檔 = false;

                    }

                    string strSQL = "update Products set pname = @NewName, price = @NewPrice, pdesc = @NewDesc, pimage = @NewImage, pstock = @NewStock where id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", SearchIDs[lbox訂單列表.SelectedIndex]);
                    cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                    int intPrice = 0;
                    Int32.TryParse(txt商品價格.Text, out intPrice);
                    cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                    cmd.Parameters.AddWithValue("@NewDesc", txt商品介紹.Text);
                    cmd.Parameters.AddWithValue("@NewImage", image_name);
                    cmd.Parameters.AddWithValue("@NewStock", txt商品庫存.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("資料修改完成", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("請選擇修改商品", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn選擇照片_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                string fileExt = Path.GetExtension(f.SafeFileName);
                Random myRnd = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + fileExt;
                is已修改圖檔 = true;
            }
            
        }

        private void btn移除項目_Click(object sender, EventArgs e)
        {

            if (lbox訂單列表.SelectedIndex > 0)
            {
                DialogResult R = MessageBox.Show("確認要刪除嗎?", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();

                    string strSQL = "delete from Products where id = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", SearchIDs[lbox訂單列表.SelectedIndex]);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    txt商品名稱.Text = "";
                    txt商品價格.Text = "";
                    txt商品介紹.Text = "";
                    txt商品庫存.Text = "";
                    pictureBox1.Image = null;
                    MessageBox.Show("所選商品已移除", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    讀取商品資訊();
                }

            }
            else
            {
                MessageBox.Show("請選擇刪除商品", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn商品儲存_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品庫存.Text != "") && (txt商品介紹.Text != "") && (pictureBox1.Image != null))
            {

                if (is已修改圖檔 == true)
                {
                    pictureBox1.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }


                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into Products values (@NewName , @NewPrice ,  @NewDesc ,  @NewImage , @NewStock, '上架')";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                cmd.Parameters.AddWithValue("@NewDesc", txt商品介紹.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_name);
                cmd.Parameters.AddWithValue("@NewStock", txt商品庫存.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("商品新增完成", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn商品儲存.Enabled = false;
                讀取商品資訊();
            }
            else
            {
                MessageBox.Show("所有欄位必填及圖片必選", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            txt商品名稱.Text = "";
            txt商品價格.Text = "";
            txt商品介紹.Text = "";
            txt商品庫存.Text = "";
            pictureBox1.Image = null;
            btn商品儲存.Enabled = true;
        }

        private void btn上架_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "update Products set pstatic = '上架' where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", SearchIDs[lbox訂單列表.SelectedIndex]);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("商品上架完成", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn下架_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "update Products set pstatic = '下架' where id = @SearchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", SearchIDs[lbox訂單列表.SelectedIndex]);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("商品下架完成", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
