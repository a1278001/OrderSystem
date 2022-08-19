
namespace WindowsFormsApp1
{
    partial class EmployeeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbl標題 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn訂單紀錄 = new System.Windows.Forms.Button();
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn員工管理 = new System.Windows.Forms.Button();
            this.btn會員管理 = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 100);
            this.panel1.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelDesktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktop.BackgroundImage")));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(150, 100);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(958, 612);
            this.panelDesktop.TabIndex = 5;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Olive;
            this.panelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTitle.BackgroundImage")));
            this.panelTitle.Controls.Add(this.lbl標題);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(150, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(958, 100);
            this.panelTitle.TabIndex = 4;
            // 
            // lbl標題
            // 
            this.lbl標題.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl標題.AutoSize = true;
            this.lbl標題.BackColor = System.Drawing.Color.Transparent;
            this.lbl標題.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl標題.ForeColor = System.Drawing.Color.White;
            this.lbl標題.Location = new System.Drawing.Point(392, 25);
            this.lbl標題.Name = "lbl標題";
            this.lbl標題.Size = new System.Drawing.Size(182, 50);
            this.lbl標題.TabIndex = 0;
            this.lbl標題.Text = "員工介面";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Olive;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.Controls.Add(this.btn會員管理);
            this.panelMenu.Controls.Add(this.btn員工管理);
            this.panelMenu.Controls.Add(this.btn訂單紀錄);
            this.panelMenu.Controls.Add(this.btn商品管理);
            this.panelMenu.Controls.Add(this.btn訂單管理);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 712);
            this.panelMenu.TabIndex = 3;
            // 
            // btn訂單紀錄
            // 
            this.btn訂單紀錄.BackColor = System.Drawing.Color.Transparent;
            this.btn訂單紀錄.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn訂單紀錄.FlatAppearance.BorderSize = 0;
            this.btn訂單紀錄.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn訂單紀錄.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單紀錄.ForeColor = System.Drawing.Color.White;
            this.btn訂單紀錄.Location = new System.Drawing.Point(0, 300);
            this.btn訂單紀錄.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn訂單紀錄.Name = "btn訂單紀錄";
            this.btn訂單紀錄.Size = new System.Drawing.Size(150, 100);
            this.btn訂單紀錄.TabIndex = 5;
            this.btn訂單紀錄.Text = "訂單紀錄";
            this.btn訂單紀錄.UseVisualStyleBackColor = false;
            this.btn訂單紀錄.Click += new System.EventHandler(this.btn訂單紀錄_Click);
            // 
            // btn商品管理
            // 
            this.btn商品管理.BackColor = System.Drawing.Color.Transparent;
            this.btn商品管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn商品管理.FlatAppearance.BorderSize = 0;
            this.btn商品管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn商品管理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理.ForeColor = System.Drawing.Color.White;
            this.btn商品管理.Location = new System.Drawing.Point(0, 200);
            this.btn商品管理.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(150, 100);
            this.btn商品管理.TabIndex = 4;
            this.btn商品管理.Text = "商品管理";
            this.btn商品管理.UseVisualStyleBackColor = false;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.BackColor = System.Drawing.Color.Transparent;
            this.btn訂單管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn訂單管理.FlatAppearance.BorderSize = 0;
            this.btn訂單管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.ForeColor = System.Drawing.Color.White;
            this.btn訂單管理.Location = new System.Drawing.Point(0, 100);
            this.btn訂單管理.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(150, 100);
            this.btn訂單管理.TabIndex = 2;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = false;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn員工管理
            // 
            this.btn員工管理.BackColor = System.Drawing.Color.Transparent;
            this.btn員工管理.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn員工管理.FlatAppearance.BorderSize = 0;
            this.btn員工管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn員工管理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn員工管理.ForeColor = System.Drawing.Color.White;
            this.btn員工管理.Location = new System.Drawing.Point(0, 612);
            this.btn員工管理.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn員工管理.Name = "btn員工管理";
            this.btn員工管理.Size = new System.Drawing.Size(150, 100);
            this.btn員工管理.TabIndex = 6;
            this.btn員工管理.Text = "員工管理";
            this.btn員工管理.UseVisualStyleBackColor = false;
            this.btn員工管理.Click += new System.EventHandler(this.btn員工管理_Click);
            // 
            // btn會員管理
            // 
            this.btn會員管理.BackColor = System.Drawing.Color.Transparent;
            this.btn會員管理.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn會員管理.FlatAppearance.BorderSize = 0;
            this.btn會員管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn會員管理.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員管理.ForeColor = System.Drawing.Color.White;
            this.btn會員管理.Location = new System.Drawing.Point(0, 512);
            this.btn會員管理.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn會員管理.Name = "btn會員管理";
            this.btn會員管理.Size = new System.Drawing.Size(150, 100);
            this.btn會員管理.TabIndex = 7;
            this.btn會員管理.Text = "會員管理";
            this.btn會員管理.UseVisualStyleBackColor = false;
            this.btn會員管理.Click += new System.EventHandler(this.btn會員管理_Click);
            // 
            // EmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 712);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeMenu_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeMenu_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbl標題;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn商品管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn訂單紀錄;
        private System.Windows.Forms.Button btn會員管理;
        private System.Windows.Forms.Button btn員工管理;
    }
}