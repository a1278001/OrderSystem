
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl驗證碼 = new System.Windows.Forms.Label();
            this.btn重設 = new System.Windows.Forms.Button();
            this.btn登入 = new System.Windows.Forms.Button();
            this.txt驗證碼 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn直接訂購 = new System.Windows.Forms.Button();
            this.txt直購電話 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt直購姓名 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl驗證碼
            // 
            this.lbl驗證碼.BackColor = System.Drawing.Color.White;
            this.lbl驗證碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl驗證碼.ForeColor = System.Drawing.Color.Black;
            this.lbl驗證碼.Location = new System.Drawing.Point(539, 129);
            this.lbl驗證碼.Name = "lbl驗證碼";
            this.lbl驗證碼.Size = new System.Drawing.Size(219, 42);
            this.lbl驗證碼.TabIndex = 10;
            this.lbl驗證碼.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn重設
            // 
            this.btn重設.BackColor = System.Drawing.Color.Silver;
            this.btn重設.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重設.ForeColor = System.Drawing.Color.Black;
            this.btn重設.Location = new System.Drawing.Point(417, 224);
            this.btn重設.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn重設.Name = "btn重設";
            this.btn重設.Size = new System.Drawing.Size(131, 60);
            this.btn重設.TabIndex = 7;
            this.btn重設.Text = "清除";
            this.btn重設.UseVisualStyleBackColor = false;
            this.btn重設.Click += new System.EventHandler(this.btn重設_Click);
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.ForeColor = System.Drawing.Color.White;
            this.btn登入.Location = new System.Drawing.Point(241, 224);
            this.btn登入.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(131, 60);
            this.btn登入.TabIndex = 6;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // txt驗證碼
            // 
            this.txt驗證碼.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt驗證碼.Location = new System.Drawing.Point(539, 44);
            this.txt驗證碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt驗證碼.Name = "txt驗證碼";
            this.txt驗證碼.Size = new System.Drawing.Size(219, 43);
            this.txt驗證碼.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(411, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "驗證碼:";
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(151, 129);
            this.txt密碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(220, 43);
            this.txt密碼.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼:";
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(151, 44);
            this.txt帳號.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(220, 43);
            this.txt帳號.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // btn直接訂購
            // 
            this.btn直接訂購.BackColor = System.Drawing.Color.Orange;
            this.btn直接訂購.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn直接訂購.ForeColor = System.Drawing.Color.White;
            this.btn直接訂購.Location = new System.Drawing.Point(497, 82);
            this.btn直接訂購.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn直接訂購.Name = "btn直接訂購";
            this.btn直接訂購.Size = new System.Drawing.Size(160, 60);
            this.btn直接訂購.TabIndex = 10;
            this.btn直接訂購.Text = "直接訂購";
            this.btn直接訂購.UseVisualStyleBackColor = false;
            this.btn直接訂購.Click += new System.EventHandler(this.btn直接訂購_Click);
            // 
            // txt直購電話
            // 
            this.txt直購電話.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt直購電話.Location = new System.Drawing.Point(211, 129);
            this.txt直購電話.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt直購電話.Name = "txt直購電話";
            this.txt直購電話.Size = new System.Drawing.Size(220, 43);
            this.txt直購電話.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(112, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "手機:";
            // 
            // txt直購姓名
            // 
            this.txt直購姓名.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt直購姓名.Location = new System.Drawing.Point(212, 46);
            this.txt直購姓名.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt直購姓名.Name = "txt直購姓名";
            this.txt直購姓名.Size = new System.Drawing.Size(219, 43);
            this.txt直購姓名.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(112, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "姓名:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl驗證碼);
            this.groupBox1.Controls.Add(this.txt帳號);
            this.groupBox1.Controls.Add(this.btn重設);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn登入);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt驗證碼);
            this.groupBox1.Controls.Add(this.txt密碼);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(48, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(803, 311);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員登入";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn直接訂購);
            this.groupBox2.Controls.Add(this.txt直購電話);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt直購姓名);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(49, 368);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(803, 191);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "直接訂購";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "進入訂購";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn重設;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.TextBox txt驗證碼;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn直接訂購;
        private System.Windows.Forms.TextBox txt直購電話;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt直購姓名;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl驗證碼;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

