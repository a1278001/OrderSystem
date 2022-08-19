
namespace WindowsFormsApp1
{
    partial class MyRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyRecord));
            this.lbl未完成訂單 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvw未完成 = new System.Windows.Forms.ListView();
            this.lvw已完成 = new System.Windows.Forms.ListView();
            this.btn取消訂單 = new System.Windows.Forms.Button();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox搜尋欄位 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp結束訂購 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始訂購 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl未完成訂單
            // 
            this.lbl未完成訂單.AutoSize = true;
            this.lbl未完成訂單.BackColor = System.Drawing.Color.Transparent;
            this.lbl未完成訂單.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl未完成訂單.ForeColor = System.Drawing.Color.White;
            this.lbl未完成訂單.Location = new System.Drawing.Point(55, 53);
            this.lbl未完成訂單.Name = "lbl未完成訂單";
            this.lbl未完成訂單.Size = new System.Drawing.Size(167, 38);
            this.lbl未完成訂單.TabIndex = 8;
            this.lbl未完成訂單.Text = "未完成訂單";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "已完成訂單";
            // 
            // lvw未完成
            // 
            this.lvw未完成.HideSelection = false;
            this.lvw未完成.Location = new System.Drawing.Point(51, 114);
            this.lvw未完成.Name = "lvw未完成";
            this.lvw未完成.Size = new System.Drawing.Size(924, 178);
            this.lvw未完成.TabIndex = 10;
            this.lvw未完成.UseCompatibleStateImageBehavior = false;
            // 
            // lvw已完成
            // 
            this.lvw已完成.HideSelection = false;
            this.lvw已完成.Location = new System.Drawing.Point(51, 366);
            this.lvw已完成.Name = "lvw已完成";
            this.lvw已完成.Size = new System.Drawing.Size(924, 178);
            this.lvw已完成.TabIndex = 11;
            this.lvw已完成.UseCompatibleStateImageBehavior = false;
            // 
            // btn取消訂單
            // 
            this.btn取消訂單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn取消訂單.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消訂單.ForeColor = System.Drawing.Color.White;
            this.btn取消訂單.Location = new System.Drawing.Point(838, 40);
            this.btn取消訂單.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn取消訂單.Name = "btn取消訂單";
            this.btn取消訂單.Size = new System.Drawing.Size(137, 51);
            this.btn取消訂單.TabIndex = 76;
            this.btn取消訂單.Text = "取消訂單";
            this.btn取消訂單.UseVisualStyleBackColor = false;
            this.btn取消訂單.Click += new System.EventHandler(this.btn取消訂單_Click);
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.Olive;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.White;
            this.btn搜尋.Location = new System.Drawing.Point(721, 40);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(98, 50);
            this.btn搜尋.TabIndex = 88;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // cbox搜尋欄位
            // 
            this.cbox搜尋欄位.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox搜尋欄位.FormattingEnabled = true;
            this.cbox搜尋欄位.Location = new System.Drawing.Point(551, 48);
            this.cbox搜尋欄位.Name = "cbox搜尋欄位";
            this.cbox搜尋欄位.Size = new System.Drawing.Size(150, 37);
            this.cbox搜尋欄位.TabIndex = 87;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(372, 47);
            this.txt搜尋關鍵字.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(151, 38);
            this.txt搜尋關鍵字.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(691, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 36);
            this.label2.TabIndex = 98;
            this.label2.Text = "至";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 36);
            this.label3.TabIndex = 97;
            this.label3.Text = "從";
            // 
            // dtp結束訂購
            // 
            this.dtp結束訂購.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束訂購.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束訂購.Location = new System.Drawing.Point(741, 315);
            this.dtp結束訂購.Margin = new System.Windows.Forms.Padding(4);
            this.dtp結束訂購.Name = "dtp結束訂購";
            this.dtp結束訂購.Size = new System.Drawing.Size(234, 38);
            this.dtp結束訂購.TabIndex = 96;
            // 
            // dtp開始訂購
            // 
            this.dtp開始訂購.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始訂購.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始訂購.Location = new System.Drawing.Point(450, 315);
            this.dtp開始訂購.Margin = new System.Windows.Forms.Padding(4);
            this.dtp開始訂購.Name = "dtp開始訂購";
            this.dtp開始訂購.Size = new System.Drawing.Size(234, 38);
            this.dtp開始訂購.TabIndex = 95;
            this.dtp開始訂購.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // MyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp結束訂購);
            this.Controls.Add(this.dtp開始訂購);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox搜尋欄位);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.btn取消訂單);
            this.Controls.Add(this.lvw已完成);
            this.Controls.Add(this.lvw未完成);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl未完成訂單);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MyRecord";
            this.Text = "訂購紀錄";
            this.Load += new System.EventHandler(this.MyRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl未完成訂單;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvw未完成;
        private System.Windows.Forms.ListView lvw已完成;
        private System.Windows.Forms.Button btn取消訂單;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox搜尋欄位;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp結束訂購;
        private System.Windows.Forms.DateTimePicker dtp開始訂購;
    }
}