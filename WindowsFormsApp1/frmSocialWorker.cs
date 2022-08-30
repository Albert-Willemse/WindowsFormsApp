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
    public partial class frmSocialWorker : Form
    {
        frmSocialDashboard dashboard;
        frmRecieveVisitor recieveVisitor;
        frmReleaseForm ReleaseForm;
        Contact contact;
        Boolean logOut = false;

        public frmSocialWorker()
        {
            InitializeComponent();
            pnlNav.Height = btnDaxhboard.Height;
            pnlNav.Top = btnDaxhboard.Top;
            pnlNav.Left = btnDaxhboard.Left;
            btnDaxhboard.BackColor = Color.FromArgb(46, 51, 73);

            dashboard = new frmSocialDashboard();
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.Dock = DockStyle.Fill;
        }

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
            btnRecieveVisitor.BackColor = Color.FromArgb(37, 45, 55);
            btnManage.BackColor = Color.FromArgb(37, 45, 55);
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            dashboard = new frmSocialDashboard();
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.Dock = DockStyle.Fill;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOut = true;
            Form1 Login = new Form1();
            Login.Show();
            this.Close();
        }

        private void frmSocialWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }

        private void frmSocialWorker_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRecieveVisitor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].Close();
            }


            pnlNav.Height = btnRecieveVisitor.Height;
            pnlNav.Top = btnRecieveVisitor.Top;
            pnlNav.Left = btnRecieveVisitor.Left;
            btnRecieveVisitor.BackColor = Color.FromArgb(46, 51, 73);
            btnDaxhboard.BackColor = Color.FromArgb(37, 45, 55);
            btnManage.BackColor = Color.FromArgb(37, 45, 55);
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            recieveVisitor = new frmRecieveVisitor();
            recieveVisitor.MdiParent = this;
            recieveVisitor.Show();
            recieveVisitor.Dock = DockStyle.Fill;
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
            btnRecieveVisitor.BackColor = Color.FromArgb(37, 45, 55);
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            ReleaseForm = new frmReleaseForm();
            ReleaseForm.MdiParent = this;
            ReleaseForm.Show();
            ReleaseForm.Dock = DockStyle.Fill;
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
            btnRecieveVisitor.BackColor = Color.FromArgb(37, 45, 55);
            btnManage.BackColor = Color.FromArgb(37, 45, 55);

            contact = new Contact();
            contact.MdiParent = this;
            contact.Show();
            contact.Dock = DockStyle.Fill;
        }
    }
}
