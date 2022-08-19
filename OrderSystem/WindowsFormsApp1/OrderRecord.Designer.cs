
namespace WindowsFormsApp1
{
    partial class OrderRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRecord));
            this.lvw已取消 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lvw已完成 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox搜尋欄位 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp結束訂購 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始訂購 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lvw已取消
            // 
            this.lvw已取消.HideSelection = false;
            this.lvw已取消.Location = new System.Drawing.Point(52, 348);
            this.lvw已取消.Name = "lvw已取消";
            this.lvw已取消.Size = new System.Drawing.Size(843, 204);
            this.lvw已取消.TabIndex = 95;
            this.lvw已取消.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 94;
            this.label2.Text = "已取消訂單";
            // 
            // lvw已完成
            // 
            this.lvw已完成.HideSelection = false;
            this.lvw已完成.Location = new System.Drawing.Point(52, 84);
            this.lvw已完成.Name = "lvw已完成";
            this.lvw已完成.Size = new System.Drawing.Size(843, 200);
            this.lvw已完成.TabIndex = 93;
            this.lvw已完成.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 92;
            this.label1.Text = "已完成訂單";
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.Olive;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.White;
            this.btn搜尋.Location = new System.Drawing.Point(797, 23);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(98, 50);
            this.btn搜尋.TabIndex = 98;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // cbox搜尋欄位
            // 
            this.cbox搜尋欄位.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox搜尋欄位.FormattingEnabled = true;
            this.cbox搜尋欄位.Location = new System.Drawing.Point(661, 32);
            this.cbox搜尋欄位.Name = "cbox搜尋欄位";
            this.cbox搜尋欄位.Size = new System.Drawing.Size(121, 37);
            this.cbox搜尋欄位.TabIndex = 97;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(482, 31);
            this.txt搜尋關鍵字.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(151, 38);
            this.txt搜尋關鍵字.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(611, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 36);
            this.label3.TabIndex = 102;
            this.label3.Text = "至";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 36);
            this.label4.TabIndex = 101;
            this.label4.Text = "從";
            // 
            // dtp結束訂購
            // 
            this.dtp結束訂購.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束訂購.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束訂購.Location = new System.Drawing.Point(661, 299);
            this.dtp結束訂購.Margin = new System.Windows.Forms.Padding(4);
            this.dtp結束訂購.Name = "dtp結束訂購";
            this.dtp結束訂購.Size = new System.Drawing.Size(234, 38);
            this.dtp結束訂購.TabIndex = 100;
            // 
            // dtp開始訂購
            // 
            this.dtp開始訂購.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始訂購.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始訂購.Location = new System.Drawing.Point(370, 299);
            this.dtp開始訂購.Margin = new System.Windows.Forms.Padding(4);
            this.dtp開始訂購.Name = "dtp開始訂購";
            this.dtp開始訂購.Size = new System.Drawing.Size(234, 38);
            this.dtp開始訂購.TabIndex = 99;
            this.dtp開始訂購.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // OrderRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp結束訂購);
            this.Controls.Add(this.dtp開始訂購);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox搜尋欄位);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.lvw已取消);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvw已完成);
            this.Controls.Add(this.label1);
            this.Name = "OrderRecord";
            this.Text = "訂單紀錄";
            this.Load += new System.EventHandler(this.OrderRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvw已取消;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvw已完成;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox搜尋欄位;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp結束訂購;
        private System.Windows.Forms.DateTimePicker dtp開始訂購;
    }
}