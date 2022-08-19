using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerMenu : Form
    {
        private Form activeForm;

        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerInterface(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl標題.Text = childForm.Text;

            if(GlobalVar.登入判定 == false)
            {
                btn會員資料.Enabled = false;
                btn訂購紀錄.Enabled = false;
                btn我的最愛.Enabled = false;
            }
        }

        private void btn拉麵訂購_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerInterface(), sender);
        }

        private void btn訂單查詢_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerOrder(), sender);
        }

        private void btn會員資料_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyAccount(), sender);
        }

        private void btn我的最愛_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyFavourite(), sender);
        }

        private void btn訂購紀錄_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyRecord(), sender);
        }

        private void CustomerMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.登入判定 = false;
            GlobalVar.formMain.Show();
        }
    }
}
