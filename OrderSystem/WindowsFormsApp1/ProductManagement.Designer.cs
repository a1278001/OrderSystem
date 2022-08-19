
namespace WindowsFormsApp1
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.lbl商品列表 = new System.Windows.Forms.Label();
            this.lbox訂單列表 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品庫存 = new System.Windows.Forms.TextBox();
            this.btn上架 = new System.Windows.Forms.Button();
            this.btn下架 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn商品儲存 = new System.Windows.Forms.Button();
            this.btn移除項目 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.txt商品介紹 = new System.Windows.Forms.TextBox();
            this.btn選擇照片 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl商品列表
            // 
            this.lbl商品列表.AutoSize = true;
            this.lbl商品列表.BackColor = System.Drawing.Color.Transparent;
            this.lbl商品列表.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品列表.ForeColor = System.Drawing.Color.White;
            this.lbl商品列表.Location = new System.Drawing.Point(93, 54);
            this.lbl商品列表.Name = "lbl商品列表";
            this.lbl商品列表.Size = new System.Drawing.Size(137, 38);
            this.lbl商品列表.TabIndex = 7;
            this.lbl商品列表.Text = "商品列表";
            // 
            // lbox訂單列表
            // 
            this.lbox訂單列表.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox訂單列表.FormattingEnabled = true;
            this.lbox訂單列表.ItemHeight = 25;
            this.lbox訂單列表.Location = new System.Drawing.Point(55, 116);
            this.lbox訂單列表.Margin = new System.Windows.Forms.Padding(4);
            this.lbox訂單列表.Name = "lbox訂單列表";
            this.lbox訂單列表.Size = new System.Drawing.Size(223, 429);
            this.lbox訂單列表.TabIndex = 6;
            this.lbox訂單列表.SelectedIndexChanged += new System.EventHandler(this.lbox訂單列表_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(663, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 71;
            this.label5.Text = "商品介紹";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(563, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(663, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 69;
            this.label3.Text = "商品圖片";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(365, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "商品名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(365, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 74;
            this.label2.Text = "商品價格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(365, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 75;
            this.label4.Text = "商品庫存";
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(343, 58);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(151, 38);
            this.txt商品名稱.TabIndex = 76;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品價格.Location = new System.Drawing.Point(343, 150);
            this.txt商品價格.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(151, 38);
            this.txt商品價格.TabIndex = 77;
            // 
            // txt商品庫存
            // 
            this.txt商品庫存.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品庫存.Location = new System.Drawing.Point(343, 242);
            this.txt商品庫存.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt商品庫存.Name = "txt商品庫存";
            this.txt商品庫存.Size = new System.Drawing.Size(151, 38);
            this.txt商品庫存.TabIndex = 78;
            // 
            // btn上架
            // 
            this.btn上架.BackColor = System.Drawing.Color.Olive;
            this.btn上架.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn上架.ForeColor = System.Drawing.Color.White;
            this.btn上架.Location = new System.Drawing.Point(313, 319);
            this.btn上架.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn上架.Name = "btn上架";
            this.btn上架.Size = new System.Drawing.Size(87, 54);
            this.btn上架.TabIndex = 79;
            this.btn上架.Text = "上架";
            this.btn上架.UseVisualStyleBackColor = false;
            this.btn上架.Click += new System.EventHandler(this.btn上架_Click);
            // 
            // btn下架
            // 
            this.btn下架.BackColor = System.Drawing.Color.Red;
            this.btn下架.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn下架.ForeColor = System.Drawing.Color.White;
            this.btn下架.Location = new System.Drawing.Point(429, 319);
            this.btn下架.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn下架.Name = "btn下架";
            this.btn下架.Size = new System.Drawing.Size(87, 54);
            this.btn下架.TabIndex = 80;
            this.btn下架.Text = "下架";
            this.btn下架.UseVisualStyleBackColor = false;
            this.btn下架.Click += new System.EventHandler(this.btn下架_Click);
            // 
            // btn資料修改
            // 
            this.btn資料修改.BackColor = System.Drawing.Color.Olive;
            this.btn資料修改.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料修改.ForeColor = System.Drawing.Color.White;
            this.btn資料修改.Location = new System.Drawing.Point(313, 411);
            this.btn資料修改.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(203, 50);
            this.btn資料修改.TabIndex = 81;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = false;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // btn商品儲存
            // 
            this.btn商品儲存.BackColor = System.Drawing.Color.Red;
            this.btn商品儲存.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品儲存.ForeColor = System.Drawing.Color.White;
            this.btn商品儲存.Location = new System.Drawing.Point(200, 31);
            this.btn商品儲存.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn商品儲存.Name = "btn商品儲存";
            this.btn商品儲存.Size = new System.Drawing.Size(155, 50);
            this.btn商品儲存.TabIndex = 82;
            this.btn商品儲存.Text = "商品儲存";
            this.btn商品儲存.UseVisualStyleBackColor = false;
            this.btn商品儲存.Click += new System.EventHandler(this.btn商品儲存_Click);
            // 
            // btn移除項目
            // 
            this.btn移除項目.BackColor = System.Drawing.Color.Red;
            this.btn移除項目.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除項目.ForeColor = System.Drawing.Color.White;
            this.btn移除項目.Location = new System.Drawing.Point(313, 489);
            this.btn移除項目.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn移除項目.Name = "btn移除項目";
            this.btn移除項目.Size = new System.Drawing.Size(203, 50);
            this.btn移除項目.TabIndex = 83;
            this.btn移除項目.Text = "移除項目";
            this.btn移除項目.UseVisualStyleBackColor = false;
            this.btn移除項目.Click += new System.EventHandler(this.btn移除項目_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.BackColor = System.Drawing.Color.Olive;
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.ForeColor = System.Drawing.Color.White;
            this.btn新增商品.Location = new System.Drawing.Point(19, 31);
            this.btn新增商品.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(155, 50);
            this.btn新增商品.TabIndex = 84;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = false;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // txt商品介紹
            // 
            this.txt商品介紹.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品介紹.Location = new System.Drawing.Point(563, 314);
            this.txt商品介紹.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt商品介紹.Multiline = true;
            this.txt商品介紹.Name = "txt商品介紹";
            this.txt商品介紹.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品介紹.Size = new System.Drawing.Size(305, 130);
            this.txt商品介紹.TabIndex = 85;
            // 
            // btn選擇照片
            // 
            this.btn選擇照片.BackColor = System.Drawing.Color.Red;
            this.btn選擇照片.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn選擇照片.ForeColor = System.Drawing.Color.White;
            this.btn選擇照片.Location = new System.Drawing.Point(781, 19);
            this.btn選擇照片.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn選擇照片.Name = "btn選擇照片";
            this.btn選擇照片.Size = new System.Drawing.Size(87, 41);
            this.btn選擇照片.TabIndex = 86;
            this.btn選擇照片.Text = "選擇照片";
            this.btn選擇照片.UseVisualStyleBackColor = false;
            this.btn選擇照片.Click += new System.EventHandler(this.btn選擇照片_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn新增商品);
            this.groupBox1.Controls.Add(this.btn商品儲存);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(531, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 96);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增商品";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn選擇照片);
            this.Controls.Add(this.txt商品介紹);
            this.Controls.Add(this.btn移除項目);
            this.Controls.Add(this.btn資料修改);
            this.Controls.Add(this.btn下架);
            this.Controls.Add(this.btn上架);
            this.Controls.Add(this.txt商品庫存);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl商品列表);
            this.Controls.Add(this.lbox訂單列表);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductManagement";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl商品列表;
        private System.Windows.Forms.ListBox lbox訂單列表;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品庫存;
        private System.Windows.Forms.Button btn上架;
        private System.Windows.Forms.Button btn下架;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn商品儲存;
        private System.Windows.Forms.Button btn移除項目;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.TextBox txt商品介紹;
        private System.Windows.Forms.Button btn選擇照片;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}