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
    public partial class EmployeeMenu : Form
    {
        private Form activeForm;

        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void EmployeeMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new OrderedManagement(), sender);
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

            if(GlobalVar.管理員判定 == false)
            {
                btn員工管理.Enabled = false;
                btn會員管理.Enabled = false;
            }
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderedManagement(), sender);
        }

        private void EmployeeMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.管理員判定 = false;
            GlobalVar.formMain.Show();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductManagement(), sender);
        }

        private void btn訂單紀錄_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderRecord(), sender);
        }

        private void btn會員管理_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerAccountManagement(), sender);
        }

        private void btn員工管理_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeAccountManagement(), sender);

        }
    }
}
