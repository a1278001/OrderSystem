
namespace WindowsFormsApp1
{
    partial class CustomerInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInterface));
            this.label17 = new System.Windows.Forms.Label();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btn加入訂單 = new System.Windows.Forms.Button();
            this.lbl使用者名稱 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox品項名稱 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbox追加品項 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl商品介紹 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox硬度 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox湯頭 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbox蒜泥 = new System.Windows.Forms.ComboBox();
            this.btn加入最愛 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl庫存 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(380, 351);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 31);
            this.label17.TabIndex = 37;
            this.label17.Text = "數量";
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(386, 399);
            this.txt數量.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(65, 34);
            this.txt數量.TabIndex = 38;
            this.txt數量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt數量.TextChanged += new System.EventHandler(this.txt數量_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(458, 401);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 31);
            this.label18.TabIndex = 39;
            this.label18.Text = "份";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(389, 461);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 31);
            this.label19.TabIndex = 40;
            this.label19.Text = "單價";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(509, 461);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 31);
            this.label20.TabIndex = 41;
            this.label20.Text = "總價";
            // 
            // lbl單價
            // 
            this.lbl單價.BackColor = System.Drawing.Color.White;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.ForeColor = System.Drawing.Color.Black;
            this.lbl單價.Location = new System.Drawing.Point(389, 500);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(56, 29);
            this.lbl單價.TabIndex = 42;
            this.lbl單價.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(451, 500);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 31);
            this.label22.TabIndex = 43;
            this.label22.Text = "元";
            // 
            // lbl總價
            // 
            this.lbl總價.BackColor = System.Drawing.Color.White;
            this.lbl總價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.ForeColor = System.Drawing.Color.Black;
            this.lbl總價.Location = new System.Drawing.Point(515, 500);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(67, 29);
            this.lbl總價.TabIndex = 44;
            this.lbl總價.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(588, 500);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 31);
            this.label24.TabIndex = 45;
            this.label24.Text = "元";
            // 
            // btn加入訂單
            // 
            this.btn加入訂單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn加入訂單.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂單.ForeColor = System.Drawing.Color.White;
            this.btn加入訂單.Location = new System.Drawing.Point(647, 478);
            this.btn加入訂單.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn加入訂單.Name = "btn加入訂單";
            this.btn加入訂單.Size = new System.Drawing.Size(131, 51);
            this.btn加入訂單.TabIndex = 46;
            this.btn加入訂單.Text = "加入訂單";
            this.btn加入訂單.UseVisualStyleBackColor = false;
            this.btn加入訂單.Click += new System.EventHandler(this.btn加入訂單_Click);
            // 
            // lbl使用者名稱
            // 
            this.lbl使用者名稱.AutoSize = true;
            this.lbl使用者名稱.BackColor = System.Drawing.Color.Transparent;
            this.lbl使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl使用者名稱.ForeColor = System.Drawing.Color.White;
            this.lbl使用者名稱.Location = new System.Drawing.Point(63, 20);
            this.lbl使用者名稱.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl使用者名稱.Name = "lbl使用者名稱";
            this.lbl使用者名稱.Size = new System.Drawing.Size(212, 25);
            this.lbl使用者名稱.TabIndex = 52;
            this.lbl使用者名稱.Text = "使用者名稱，歡迎使用";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "拉麵品項";
            // 
            // lbox品項名稱
            // 
            this.lbox品項名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox品項名稱.FormattingEnabled = true;
            this.lbox品項名稱.ItemHeight = 25;
            this.lbox品項名稱.Location = new System.Drawing.Point(68, 140);
            this.lbox品項名稱.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox品項名稱.Name = "lbox品項名稱";
            this.lbox品項名稱.Size = new System.Drawing.Size(288, 129);
            this.lbox品項名稱.TabIndex = 62;
            this.lbox品項名稱.SelectedIndexChanged += new System.EventHandler(this.lbox品項名稱_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 63;
            this.label2.Text = "追加品項";
            // 
            // lbox追加品項
            // 
            this.lbox追加品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox追加品項.FormattingEnabled = true;
            this.lbox追加品項.ItemHeight = 25;
            this.lbox追加品項.Location = new System.Drawing.Point(67, 400);
            this.lbox追加品項.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox追加品項.Name = "lbox追加品項";
            this.lbox追加品項.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbox追加品項.Size = new System.Drawing.Size(288, 129);
            this.lbox追加品項.TabIndex = 64;
            this.lbox追加品項.SelectedIndexChanged += new System.EventHandler(this.lbox追加品項_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(742, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 65;
            this.label3.Text = "商品圖片";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(642, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(742, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 67;
            this.label5.Text = "商品介紹";
            // 
            // lbl商品介紹
            // 
            this.lbl商品介紹.BackColor = System.Drawing.Color.White;
            this.lbl商品介紹.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品介紹.ForeColor = System.Drawing.Color.Black;
            this.lbl商品介紹.Location = new System.Drawing.Point(642, 314);
            this.lbl商品介紹.Name = "lbl商品介紹";
            this.lbl商品介紹.Size = new System.Drawing.Size(307, 119);
            this.lbl商品介紹.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(390, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 69;
            this.label7.Text = "麵條硬度";
            // 
            // cbox硬度
            // 
            this.cbox硬度.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox硬度.FormattingEnabled = true;
            this.cbox硬度.Location = new System.Drawing.Point(386, 91);
            this.cbox硬度.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox硬度.Name = "cbox硬度";
            this.cbox硬度.Size = new System.Drawing.Size(127, 33);
            this.cbox硬度.TabIndex = 70;
            this.cbox硬度.SelectedIndexChanged += new System.EventHandler(this.cbox硬度_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(390, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 71;
            this.label8.Text = "湯頭濃度";
            // 
            // cbox湯頭
            // 
            this.cbox湯頭.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox湯頭.FormattingEnabled = true;
            this.cbox湯頭.Location = new System.Drawing.Point(386, 191);
            this.cbox湯頭.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox湯頭.Name = "cbox湯頭";
            this.cbox湯頭.Size = new System.Drawing.Size(127, 33);
            this.cbox湯頭.TabIndex = 72;
            this.cbox湯頭.SelectedIndexChanged += new System.EventHandler(this.cbox湯頭_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(414, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 31);
            this.label9.TabIndex = 73;
            this.label9.Text = "蒜泥";
            // 
            // cbox蒜泥
            // 
            this.cbox蒜泥.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox蒜泥.FormattingEnabled = true;
            this.cbox蒜泥.Location = new System.Drawing.Point(386, 287);
            this.cbox蒜泥.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox蒜泥.Name = "cbox蒜泥";
            this.cbox蒜泥.Size = new System.Drawing.Size(127, 33);
            this.cbox蒜泥.TabIndex = 74;
            this.cbox蒜泥.SelectedIndexChanged += new System.EventHandler(this.cbox蒜泥_SelectedIndexChanged);
            // 
            // btn加入最愛
            // 
            this.btn加入最愛.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn加入最愛.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入最愛.ForeColor = System.Drawing.Color.White;
            this.btn加入最愛.Location = new System.Drawing.Point(812, 478);
            this.btn加入最愛.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn加入最愛.Name = "btn加入最愛";
            this.btn加入最愛.Size = new System.Drawing.Size(137, 51);
            this.btn加入最愛.TabIndex = 75;
            this.btn加入最愛.Text = "加入最愛";
            this.btn加入最愛.UseVisualStyleBackColor = false;
            this.btn加入最愛.Click += new System.EventHandler(this.btn加入最愛_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 76;
            this.label4.Text = "庫存";
            // 
            // lbl庫存
            // 
            this.lbl庫存.BackColor = System.Drawing.Color.White;
            this.lbl庫存.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存.ForeColor = System.Drawing.Color.Black;
            this.lbl庫存.Location = new System.Drawing.Point(131, 290);
            this.lbl庫存.Name = "lbl庫存";
            this.lbl庫存.Size = new System.Drawing.Size(56, 29);
            this.lbl庫存.TabIndex = 77;
            this.lbl庫存.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(193, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 31);
            this.label10.TabIndex = 78;
            this.label10.Text = "份";
            // 
            // CustomerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl庫存);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn加入最愛);
            this.Controls.Add(this.cbox蒜泥);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbox湯頭);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbox硬度);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl商品介紹);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbox追加品項);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbox品項名稱);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl使用者名稱);
            this.Controls.Add(this.btn加入訂單);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.label17);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerInterface";
            this.Text = "拉麵訂購";
            this.Load += new System.EventHandler(this.CustomerInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btn加入訂單;
        private System.Windows.Forms.Label lbl使用者名稱;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox品項名稱;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbox追加品項;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl商品介紹;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox硬度;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbox湯頭;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbox蒜泥;
        private System.Windows.Forms.Button btn加入最愛;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl庫存;
        private System.Windows.Forms.Label label10;
    }
}