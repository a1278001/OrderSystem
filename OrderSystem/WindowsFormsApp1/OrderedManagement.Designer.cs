
namespace WindowsFormsApp1
{
    partial class OrderedManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderedManagement));
            this.lbl未完成訂單 = new System.Windows.Forms.Label();
            this.lvw未完成 = new System.Windows.Forms.ListView();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.cbox搜尋欄位 = new System.Windows.Forms.ComboBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.btn完成訂單 = new System.Windows.Forms.Button();
            this.btn取消訂單 = new System.Windows.Forms.Button();
            this.btn重新載入 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl未完成訂單
            // 
            this.lbl未完成訂單.AutoSize = true;
            this.lbl未完成訂單.BackColor = System.Drawing.Color.Transparent;
            this.lbl未完成訂單.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl未完成訂單.ForeColor = System.Drawing.Color.White;
            this.lbl未完成訂單.Location = new System.Drawing.Point(41, 36);
            this.lbl未完成訂單.Name = "lbl未完成訂單";
            this.lbl未完成訂單.Size = new System.Drawing.Size(167, 38);
            this.lbl未完成訂單.TabIndex = 9;
            this.lbl未完成訂單.Text = "未完成訂單";
            // 
            // lvw未完成
            // 
            this.lvw未完成.HideSelection = false;
            this.lvw未完成.Location = new System.Drawing.Point(48, 96);
            this.lvw未完成.Name = "lvw未完成";
            this.lvw未完成.Size = new System.Drawing.Size(843, 356);
            this.lvw未完成.TabIndex = 11;
            this.lvw未完成.UseCompatibleStateImageBehavior = false;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(478, 40);
            this.txt搜尋關鍵字.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(151, 38);
            this.txt搜尋關鍵字.TabIndex = 77;
            // 
            // cbox搜尋欄位
            // 
            this.cbox搜尋欄位.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox搜尋欄位.FormattingEnabled = true;
            this.cbox搜尋欄位.Location = new System.Drawing.Point(657, 41);
            this.cbox搜尋欄位.Name = "cbox搜尋欄位";
            this.cbox搜尋欄位.Size = new System.Drawing.Size(121, 37);
            this.cbox搜尋欄位.TabIndex = 78;
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.Olive;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.White;
            this.btn搜尋.Location = new System.Drawing.Point(793, 32);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(98, 50);
            this.btn搜尋.TabIndex = 85;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // btn完成訂單
            // 
            this.btn完成訂單.BackColor = System.Drawing.Color.Olive;
            this.btn完成訂單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn完成訂單.ForeColor = System.Drawing.Color.White;
            this.btn完成訂單.Location = new System.Drawing.Point(607, 474);
            this.btn完成訂單.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn完成訂單.Name = "btn完成訂單";
            this.btn完成訂單.Size = new System.Drawing.Size(131, 43);
            this.btn完成訂單.TabIndex = 86;
            this.btn完成訂單.Text = "完成訂單";
            this.btn完成訂單.UseVisualStyleBackColor = false;
            this.btn完成訂單.Click += new System.EventHandler(this.btn完成訂單_Click);
            // 
            // btn取消訂單
            // 
            this.btn取消訂單.BackColor = System.Drawing.Color.Red;
            this.btn取消訂單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消訂單.ForeColor = System.Drawing.Color.White;
            this.btn取消訂單.Location = new System.Drawing.Point(760, 474);
            this.btn取消訂單.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn取消訂單.Name = "btn取消訂單";
            this.btn取消訂單.Size = new System.Drawing.Size(131, 43);
            this.btn取消訂單.TabIndex = 87;
            this.btn取消訂單.Text = "取消訂單";
            this.btn取消訂單.UseVisualStyleBackColor = false;
            this.btn取消訂單.Click += new System.EventHandler(this.btn取消訂單_Click);
            // 
            // btn重新載入
            // 
            this.btn重新載入.BackColor = System.Drawing.Color.Olive;
            this.btn重新載入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新載入.ForeColor = System.Drawing.Color.White;
            this.btn重新載入.Location = new System.Drawing.Point(48, 474);
            this.btn重新載入.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn重新載入.Name = "btn重新載入";
            this.btn重新載入.Size = new System.Drawing.Size(131, 43);
            this.btn重新載入.TabIndex = 88;
            this.btn重新載入.Text = "重新載入";
            this.btn重新載入.UseVisualStyleBackColor = false;
            this.btn重新載入.Click += new System.EventHandler(this.btn重新載入_Click);
            // 
            // OrderedManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 565);
            this.Controls.Add(this.btn重新載入);
            this.Controls.Add(this.btn取消訂單);
            this.Controls.Add(this.btn完成訂單);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox搜尋欄位);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.lvw未完成);
            this.Controls.Add(this.lbl未完成訂單);
            this.Name = "OrderedManagement";
            this.Text = "訂單管理";
            this.Load += new System.EventHandler(this.OrderedManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl未完成訂單;
        private System.Windows.Forms.ListView lvw未完成;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.ComboBox cbox搜尋欄位;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Button btn完成訂單;
        private System.Windows.Forms.Button btn取消訂單;
        private System.Windows.Forms.Button btn重新載入;
    }
}