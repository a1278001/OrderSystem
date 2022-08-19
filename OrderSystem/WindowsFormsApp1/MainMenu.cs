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
    public partial class MainMenu : Form
    {
        private Form activeForm;
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(), sender);
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
            GlobalVar.formMain = this;


        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn會員登入_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1(),sender);
        }

        private void btn帳號申請_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAccountCreate(), sender);
        }

        private void btn員工登入_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeEntry(), sender);
        }

        private void btn忘記密碼_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PasswordGetBack(), sender);
        }
    }
}
