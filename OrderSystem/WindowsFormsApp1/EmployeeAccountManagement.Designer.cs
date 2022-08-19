
namespace WindowsFormsApp1
{
    partial class EmployeeAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAccountManagement));
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox搜尋欄位 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.lvw員工資料 = new System.Windows.Forms.ListView();
            this.lbl員工帳號列表 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn重置 = new System.Windows.Forms.Button();
            this.btn建立 = new System.Windows.Forms.Button();
            this.txt員工編號 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn移除帳號 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt員工密碼 = new System.Windows.Forms.TextBox();
            this.lbl帳號 = new System.Windows.Forms.Label();
            this.lbl員工編號 = new System.Windows.Forms.Label();
            this.btn變更密碼 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.Olive;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.White;
            this.btn搜尋.Location = new System.Drawing.Point(818, 27);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(98, 50);
            this.btn搜尋.TabIndex = 93;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // cbox搜尋欄位
            // 
            this.cbox搜尋欄位.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox搜尋欄位.FormattingEnabled = true;
            this.cbox搜尋欄位.Location = new System.Drawing.Point(631, 36);
            this.cbox搜尋欄位.Name = "cbox搜尋欄位";
            this.cbox搜尋欄位.Size = new System.Drawing.Size(160, 37);
            this.cbox搜尋欄位.TabIndex = 92;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(457, 35);
            this.txt搜尋關鍵字.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(151, 38);
            this.txt搜尋關鍵字.TabIndex = 91;
            // 
            // lvw員工資料
            // 
            this.lvw員工資料.HideSelection = false;
            this.lvw員工資料.Location = new System.Drawing.Point(51, 96);
            this.lvw員工資料.Name = "lvw員工資料";
            this.lvw員工資料.Size = new System.Drawing.Size(374, 241);
            this.lvw員工資料.TabIndex = 90;
            this.lvw員工資料.UseCompatibleStateImageBehavior = false;
            this.lvw員工資料.SelectedIndexChanged += new System.EventHandler(this.lvw員工資料_SelectedIndexChanged);
            // 
            // lbl員工帳號列表
            // 
            this.lbl員工帳號列表.AutoSize = true;
            this.lbl員工帳號列表.BackColor = System.Drawing.Color.Transparent;
            this.lbl員工帳號列表.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl員工帳號列表.ForeColor = System.Drawing.Color.White;
            this.lbl員工帳號列表.Location = new System.Drawing.Point(52, 39);
            this.lbl員工帳號列表.Name = "lbl員工帳號列表";
            this.lbl員工帳號列表.Size = new System.Drawing.Size(197, 38);
            this.lbl員工帳號列表.TabIndex = 89;
            this.lbl員工帳號列表.Text = "員工帳號列表";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn重置);
            this.groupBox1.Controls.Add(this.btn建立);
            this.groupBox1.Controls.Add(this.txt員工編號);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt密碼);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt帳號);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(51, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 200);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新建員工帳號";
            // 
            // btn重置
            // 
            this.btn重置.BackColor = System.Drawing.Color.Silver;
            this.btn重置.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重置.ForeColor = System.Drawing.Color.Black;
            this.btn重置.Location = new System.Drawing.Point(603, 137);
            this.btn重置.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn重置.Name = "btn重置";
            this.btn重置.Size = new System.Drawing.Size(137, 43);
            this.btn重置.TabIndex = 96;
            this.btn重置.Text = "重置";
            this.btn重置.UseVisualStyleBackColor = false;
            // 
            // btn建立
            // 
            this.btn建立.BackColor = System.Drawing.Color.Olive;
            this.btn建立.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn建立.ForeColor = System.Drawing.Color.White;
            this.btn建立.Location = new System.Drawing.Point(421, 137);
            this.btn建立.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn建立.Name = "btn建立";
            this.btn建立.Size = new System.Drawing.Size(137, 43);
            this.btn建立.TabIndex = 95;
            this.btn建立.Text = "建立";
            this.btn建立.UseVisualStyleBackColor = false;
            this.btn建立.Click += new System.EventHandler(this.btn建立_Click);
            // 
            // txt員工編號
            // 
            this.txt員工編號.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt員工編號.Location = new System.Drawing.Point(580, 59);
            this.txt員工編號.Name = "txt員工編號";
            this.txt員工編號.Size = new System.Drawing.Size(160, 43);
            this.txt員工編號.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(424, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "員工編號:";
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(191, 134);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(160, 43);
            this.txt密碼.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(107, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼:";
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(191, 59);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(160, 43);
            this.txt帳號.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(107, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // btn移除帳號
            // 
            this.btn移除帳號.BackColor = System.Drawing.Color.Red;
            this.btn移除帳號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除帳號.ForeColor = System.Drawing.Color.White;
            this.btn移除帳號.Location = new System.Drawing.Point(345, 49);
            this.btn移除帳號.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn移除帳號.Name = "btn移除帳號";
            this.btn移除帳號.Size = new System.Drawing.Size(132, 61);
            this.btn移除帳號.TabIndex = 95;
            this.btn移除帳號.Text = "移除帳號";
            this.btn移除帳號.UseVisualStyleBackColor = false;
            this.btn移除帳號.Click += new System.EventHandler(this.btn移除帳號_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 36);
            this.label4.TabIndex = 97;
            this.label4.Text = "員工編號:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 36);
            this.label5.TabIndex = 98;
            this.label5.Text = "帳號:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 36);
            this.label6.TabIndex = 99;
            this.label6.Text = "密碼:";
            // 
            // txt員工密碼
            // 
            this.txt員工密碼.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt員工密碼.Location = new System.Drawing.Point(152, 188);
            this.txt員工密碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt員工密碼.Name = "txt員工密碼";
            this.txt員工密碼.PasswordChar = '*';
            this.txt員工密碼.Size = new System.Drawing.Size(151, 38);
            this.txt員工密碼.TabIndex = 100;
            // 
            // lbl帳號
            // 
            this.lbl帳號.BackColor = System.Drawing.Color.White;
            this.lbl帳號.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl帳號.ForeColor = System.Drawing.Color.Black;
            this.lbl帳號.Location = new System.Drawing.Point(152, 120);
            this.lbl帳號.Name = "lbl帳號";
            this.lbl帳號.Size = new System.Drawing.Size(151, 38);
            this.lbl帳號.TabIndex = 101;
            // 
            // lbl員工編號
            // 
            this.lbl員工編號.BackColor = System.Drawing.Color.White;
            this.lbl員工編號.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl員工編號.ForeColor = System.Drawing.Color.Black;
            this.lbl員工編號.Location = new System.Drawing.Point(152, 49);
            this.lbl員工編號.Name = "lbl員工編號";
            this.lbl員工編號.Size = new System.Drawing.Size(151, 38);
            this.lbl員工編號.TabIndex = 102;
            // 
            // btn變更密碼
            // 
            this.btn變更密碼.BackColor = System.Drawing.Color.Olive;
            this.btn變更密碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn變更密碼.ForeColor = System.Drawing.Color.White;
            this.btn變更密碼.Location = new System.Drawing.Point(345, 165);
            this.btn變更密碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn變更密碼.Name = "btn變更密碼";
            this.btn變更密碼.Size = new System.Drawing.Size(132, 61);
            this.btn變更密碼.TabIndex = 103;
            this.btn變更密碼.Text = "變更密碼";
            this.btn變更密碼.UseVisualStyleBackColor = false;
            this.btn變更密碼.Click += new System.EventHandler(this.btn變更密碼_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn變更密碼);
            this.groupBox2.Controls.Add(this.lbl員工編號);
            this.groupBox2.Controls.Add(this.lbl帳號);
            this.groupBox2.Controls.Add(this.txt員工密碼);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn移除帳號);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(439, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 253);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料變更";
            // 
            // EmployeeAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.cbox搜尋欄位);
            this.Controls.Add(this.txt搜尋關鍵字);
            this.Controls.Add(this.lvw員工資料);
            this.Controls.Add(this.lbl員工帳號列表);
            this.Name = "EmployeeAccountManagement";
            this.Text = "員工管理";
            this.Load += new System.EventHandler(this.EmployeeAccountManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox搜尋欄位;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.ListView lvw員工資料;
        private System.Windows.Forms.Label lbl員工帳號列表;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn重置;
        private System.Windows.Forms.Button btn建立;
        private System.Windows.Forms.TextBox txt員工編號;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn移除帳號;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt員工密碼;
        private System.Windows.Forms.Label lbl帳號;
        private System.Windows.Forms.Label lbl員工編號;
        private System.Windows.Forms.Button btn變更密碼;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}