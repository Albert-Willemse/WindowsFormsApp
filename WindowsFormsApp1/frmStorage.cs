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
    public partial class frmStorage : Form
    {
        frmStorageDashboard dashboard;
        frmBookOut bookOut;
        frmBookIn bookIn;
        Contact contact;
        public frmStorage()
        {
            InitializeComponent();
            pnlNav.Height = btnDaxhboard.Height;
            pnlNav.Top = btnDaxhboard.Top;
            pnlNav.Left = btnDaxhboard.Left;
            btnDaxhboard.BackColor = Color.FromArgb(46, 51, 73);

            dashboard = new frmStorageDashboard();
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
            btnDaxhboard.BackColor = Color.FromArgb(46, 51, 73); //37, 45, 55
            btnRecieveVisitor.BackColor = Color.FromArgb(37, 45, 55);
            btnManage.BackColor = Color.FromArgb(37, 45, 55);
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            dashboard = new frmStorageDashboard();
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.Dock = DockStyle.Fill;
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
            btnManage.BackColor = Color.FromArgb(37, 45, 55);
            btnDaxhboard.BackColor = Color.FromArgb(37, 45, 55);
            btnContactUs.BackColor = Color.FromArgb(37, 45, 55);

            bookOut = new frmBookOut();
            bookOut.MdiParent = this;
            bookOut.Show();
            bookOut.Dock = DockStyle.Fill;
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

            bookIn = new frmBookIn();
            bookIn.MdiParent = this;
            bookIn.Show();
            bookIn.Dock = DockStyle.Fill;
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
