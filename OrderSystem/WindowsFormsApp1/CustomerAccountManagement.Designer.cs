
namespace WindowsFormsApp1
{
    partial class CustomerAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAccountManagement));
            this.lbl會員資料列表 = new System.Windows.Forms.Label();
            this.lvw會員資料 = new System.Windows.Forms.ListView();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox搜尋欄位 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.btn停權 = new System.Windows.Forms.Button();
            this.btn黑名單 = new System.Windows.Forms.Button();
            this.dtp結束生日 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始生日 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn解除黑名單 = new System.Windows.Forms.Button();
            this.btn解除停權 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl會員資料列表
            // 
            this.lbl會員資料列表.AutoSize = true;
            this.lbl會員資料列表.BackColor = System.Drawing.Color.Transparent;
            this.lbl會員資料列表.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員資料列表.ForeColor = System.Drawing.Color.White;
            this.lbl會員資料列表.Location = new System.Drawing.Point(50, 47);
            this.lbl會員資料列表.Name = "lbl會員資料列表";
            this.lbl會員資料列表.Size = new System.Drawing.Size(197, 38);
            this.lbl會員資料列表.TabIndex = 10;
            this.lbl會員資料列表.Text = "會員資料列表";
            // 
            // lvw會員資料
            // 
            this.lvw會員資料.HideSelection = false;
            this.lvw會員資料.Location = new System.Drawing.Point(49, 170);
            this.lvw會員資料.Name = "lvw會員資料";
            this.lvw會員資料.Size = new System.Drawing.Size(843, 290);
            this.lvw會員資料.TabIndex = 12;
            this.lvw會員資料.UseCompatibleStateImageBehavior = false;
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.Olive;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.White;
            this.btn搜尋.Location = new System.Drawing.Point(794, 43);
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
            this.cbox搜尋欄位.Location = new System.Drawing.Point(658, 51);
            this.cbox搜尋欄位.Name = "cbox搜尋欄位";
            this.cbox搜尋欄位.Size = new System.Drawing.Size(130, 37);
            this.cbox搜尋欄位.TabIndex = 87;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(367, 50);
            this.txt搜尋關鍵字.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(270, 38);
            this.txt搜尋關鍵字.TabIndex = 86;
            // 
            // btn停權
            // 
            this.btn停權.BackColor = System.Drawing.Color.Red;
            this.btn停權.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn停權.ForeColor = System.Drawing.Color.White;
            this.btn停權.Location = new System.Drawing.Point(624, 481);
            this.btn停權.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn停權.Name = "btn停權";
            this.btn停權.Size = new System.Drawing.Size(131, 43);
            this.btn停權.TabIndex = 90;
            this.btn停權.Text = "停權";
            this.btn停權.UseVisualStyleBackColor = false;
            this.btn停權.Click += new System.EventHandler(this.btn停權_Click);
            // 
            // btn黑名單
            // 
            this.btn黑名單.BackColor = System.Drawing.Color.Olive;
            this.btn黑名單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn黑名單.ForeColor = System.Drawing.Color.White;
            this.btn黑名單.Location = new System.Drawing.Point(49, 481);
            this.btn黑名單.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn黑名單.Name = "btn黑名單";
            this.btn黑名單.Size = new System.Drawing.Size(131, 43);
            this.btn黑名單.TabIndex = 89;
            this.btn黑名單.Text = "黑名單";
            this.btn黑名單.UseVisualStyleBackColor = false;
            this.btn黑名單.Click += new System.EventHandler(this.btn黑名單_Click);
            // 
            // dtp結束生日
            // 
            this.dtp結束生日.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束生日.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束生日.Location = new System.Drawing.Point(658, 109);
            this.dtp結束生日.Margin = new System.Windows.Forms.Padding(4);
            this.dtp結束生日.Name = "dtp結束生日";
            this.dtp結束生日.Size = new System.Drawing.Size(234, 38);
            this.dtp結束生日.TabIndex = 92;
            // 
            // dtp開始生日
            // 
            this.dtp開始生日.CalendarFont = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始生日.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始生日.Location = new System.Drawing.Point(367, 109);
            this.dtp開始生日.Margin = new System.Windows.Forms.Padding(4);
            this.dtp開始生日.Name = "dtp開始生日";
            this.dtp開始生日.Size = new System.Drawing.Size(234, 38);
            this.dtp開始生日.TabIndex = 91;
            this.dtp開始生日.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 36);
            this.label1.TabIndex = 93;
            this.label1.Text = "從";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(608, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 36);
            this.label2.TabIndex = 94;
            this.label2.Text = "至";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(240, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 95;
            this.label3.Text = "生日";
            // 
            // btn解除黑名單
            // 
            this.btn解除黑名單.BackColor = System.Drawing.Color.Olive;
            this.btn解除黑名單.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn解除黑名單.ForeColor = System.Drawing.Color.White;
            this.btn解除黑名單.Location = new System.Drawing.Point(186, 481);
            this.btn解除黑名單.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn解除黑名單.Name = "btn解除黑名單";
            this.btn解除黑名單.Size = new System.Drawing.Size(131, 43);
            this.btn解除黑名單.TabIndex = 96;
            this.btn解除黑名單.Text = "解除";
            this.btn解除黑名單.UseVisualStyleBackColor = false;
            this.btn解除黑名單.Click += new System.EventHandler(this.btn解除黑名單_Click);
            // 
            // btn解除停權
            // 
            this.btn解除停權.BackColor = System.Drawing.Color.Red;
            this.btn解除停權.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn解除停權.ForeColor = System.Drawing.Color.White;
            this.btn解除停權.Location = new System.Drawing.Point(761, 481);
            this.btn解除停權.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn解除停權.Name = "btn解除停權";
            this.btn解除停權.Size = new System.Drawing.Size(131, 43);
            this.btn解除停權.TabIndex = 97;
            this.btn解除停權.Text = "復權";
            this.btn解除停權.UseVisualStyleBackColor = false;
            this.btn解除停權.Click += new System.EventHandler(this.btn解除停權_Click);
            // 
            // CustomerAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 565);
            this.Controls.Add(this.btn解除停權);
            this.Controls.Add(this.btn解除黑名單);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp結束生日);
            this.Controls.Add(this.dtp開始生日);
            this.Controls.Add(this.btn停權);
            this.Controls.Add(this.btn黑名單);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox搜尋欄位);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.lvw會員資料);
            this.Controls.Add(this.lbl會員資料列表);
            this.Name = "CustomerAccountManagement";
            this.Text = "會員管理";
            this.Load += new System.EventHandler(this.CustomerAccountManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl會員資料列表;
        private System.Windows.Forms.ListView lvw會員資料;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox搜尋欄位;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.Button btn停權;
        private System.Windows.Forms.Button btn黑名單;
        private System.Windows.Forms.DateTimePicker dtp結束生日;
        private System.Windows.Forms.DateTimePicker dtp開始生日;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn解除黑名單;
        private System.Windows.Forms.Button btn解除停權;
    }
}