
namespace WindowsFormsApp1
{
    partial class MyFavourite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFavourite));
            this.lvw我的最愛 = new System.Windows.Forms.ListView();
            this.lbl我的最愛列表 = new System.Windows.Forms.Label();
            this.btn全部下單 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.btn指定下單 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvw我的最愛
            // 
            this.lvw我的最愛.HideSelection = false;
            this.lvw我的最愛.Location = new System.Drawing.Point(60, 108);
            this.lvw我的最愛.Name = "lvw我的最愛";
            this.lvw我的最愛.Size = new System.Drawing.Size(907, 331);
            this.lvw我的最愛.TabIndex = 92;
            this.lvw我的最愛.UseCompatibleStateImageBehavior = false;
            this.lvw我的最愛.SelectedIndexChanged += new System.EventHandler(this.lvw我的最愛_SelectedIndexChanged);
            // 
            // lbl我的最愛列表
            // 
            this.lbl我的最愛列表.AutoSize = true;
            this.lbl我的最愛列表.BackColor = System.Drawing.Color.Transparent;
            this.lbl我的最愛列表.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl我的最愛列表.ForeColor = System.Drawing.Color.White;
            this.lbl我的最愛列表.Location = new System.Drawing.Point(61, 51);
            this.lbl我的最愛列表.Name = "lbl我的最愛列表";
            this.lbl我的最愛列表.Size = new System.Drawing.Size(197, 38);
            this.lbl我的最愛列表.TabIndex = 91;
            this.lbl我的最愛列表.Text = "我的最愛列表";
            // 
            // btn全部下單
            // 
            this.btn全部下單.BackColor = System.Drawing.Color.Red;
            this.btn全部下單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn全部下單.ForeColor = System.Drawing.Color.White;
            this.btn全部下單.Location = new System.Drawing.Point(769, 470);
            this.btn全部下單.Margin = new System.Windows.Forms.Padding(4);
            this.btn全部下單.Name = "btn全部下單";
            this.btn全部下單.Size = new System.Drawing.Size(200, 45);
            this.btn全部下單.TabIndex = 94;
            this.btn全部下單.Text = "全部下單";
            this.btn全部下單.UseVisualStyleBackColor = false;
            this.btn全部下單.Click += new System.EventHandler(this.btn全部下單_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.BackColor = System.Drawing.Color.Olive;
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.ForeColor = System.Drawing.Color.White;
            this.btn清除所有品項.Location = new System.Drawing.Point(353, 470);
            this.btn清除所有品項.Margin = new System.Windows.Forms.Padding(4);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(200, 45);
            this.btn清除所有品項.TabIndex = 93;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = false;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.BackColor = System.Drawing.Color.Olive;
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.ForeColor = System.Drawing.Color.White;
            this.btn移除所選品項.Location = new System.Drawing.Point(145, 470);
            this.btn移除所選品項.Margin = new System.Windows.Forms.Padding(4);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(200, 45);
            this.btn移除所選品項.TabIndex = 95;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = false;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn指定下單
            // 
            this.btn指定下單.BackColor = System.Drawing.Color.Red;
            this.btn指定下單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn指定下單.ForeColor = System.Drawing.Color.White;
            this.btn指定下單.Location = new System.Drawing.Point(561, 470);
            this.btn指定下單.Margin = new System.Windows.Forms.Padding(4);
            this.btn指定下單.Name = "btn指定下單";
            this.btn指定下單.Size = new System.Drawing.Size(200, 45);
            this.btn指定下單.TabIndex = 96;
            this.btn指定下單.Text = "指定下單";
            this.btn指定下單.UseVisualStyleBackColor = false;
            this.btn指定下單.Click += new System.EventHandler(this.btn指定下單_Click);
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.Location = new System.Drawing.Point(759, 58);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(208, 29);
            this.lbl訂單總價.TabIndex = 98;
            this.lbl訂單總價.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(688, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 97;
            this.label5.Text = "總價";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MyFavourite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 561);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn指定下單);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.btn全部下單);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.lvw我的最愛);
            this.Controls.Add(this.lbl我的最愛列表);
            this.Name = "MyFavourite";
            this.Text = "我的最愛";
            this.Load += new System.EventHandler(this.MyFavourite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvw我的最愛;
        private System.Windows.Forms.Label lbl我的最愛列表;
        private System.Windows.Forms.Button btn全部下單;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Button btn指定下單;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
    }
}