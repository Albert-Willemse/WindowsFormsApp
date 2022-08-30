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
    public partial class Form2 : Form
    {
        DashboardAdmin dashboard;
        Register register;
        AdminManage adminManage;
        Contact ContactForm;

        public Form2()
        {
            InitializeComponent();
            pnlNav.Height = btnDaxhboard.Height;
            pnlNav.Top = btnDaxhboard.Top;
            pnlNav.Left = btnDaxhboard.Left;
            btnDaxhboard.BackColor = Color.FromArgb(46, 51, 73);

            dashboard = new DashboardAdmin();
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.Dock = DockStyle.Fill;
            

        }

        Boolean logOut = false;

        private void btnDaxhboard_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            
            pnlNav.Height = btnDaxhboard.Height;
            pnlNav.Top = btnDaxhboard.Top;
            pnlNav.Left = btnDaxhboard.Left;
            btnDaxhboard.BackColor = Color.FromArgb(46, 51, 73);
            btnRegister.BackColor = Color.FromArgb(37, 45, 55);
            btnManage.BackColor = Color.FromArgb(37, 45, 55);
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            dashboard = new DashboardAdmin();
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.Dock = DockStyle.Fill;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            pnlNav.Height = btnRegister.Height;
            pnlNav.Top = btnRegister.Top;
            pnlNav.Left = btnRegister.Left;
            btnRegister.BackColor = Color.FromArgb(46, 51, 73);
            btnDaxhboard.BackColor = Color.FromArgb(37, 45, 55);
            btnManage.BackColor = Color.FromArgb(37, 45, 55);
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            register = new Register();
            register.MdiParent = this;
            register.Show();
            register.Dock = DockStyle.Fill;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            pnlNav.Height = btnManage.Height;
            pnlNav.Top = btnManage.Top;
            pnlNav.Left = btnManage.Left;
            btnManage.BackColor = Color.FromArgb(46, 51, 73);
            btnDaxhboard.BackColor = Color.FromArgb(37, 45, 55);
            btnRegister.BackColor = Color.FromArgb(37, 45, 55);
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            adminManage = new AdminManage();
            adminManage.MdiParent = this;
            adminManage.Show();
            adminManage.Dock = DockStyle.Fill;
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }

            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            pnlNav.Left = btnContactUs.Left;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);
            btnDaxhboard.BackColor = Color.FromArgb(37, 45, 55);
            btnRegister.BackColor = Color.FromArgb(37, 45, 55);
            btnManage.BackColor = Color.FromArgb(37, 45, 55);

            ContactForm = new Contact();
            ContactForm.MdiParent = this;
            ContactForm.Show();
            ContactForm.Dock = DockStyle.Fill;
        }

        private void btnDaxhboard_Leave(object sender, EventArgs e)
        {
            btnDaxhboard.BackColor = Color.FromArgb(37, 45, 55);
        }

        private void btnRegister_Leave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(37, 45, 55);
        }

        private void btnManage_Leave(object sender, EventArgs e)
        {
            btnManage.BackColor = Color.FromArgb(37, 45, 55);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOut = true;
            Form1 Login = new Form1();
            Login.Show();
            this.Close();
        }
    }
}
