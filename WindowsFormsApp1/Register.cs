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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            pnlClothing.Hide();
            pnlEmployeeDetials.Hide();
            lblInfo.Text = "Please enter all of the following personal details.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
                lblSize.Show();
                lblSizeText.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                lblSize.Hide();
                lblSizeText.Enabled = false;
            }
        }

        private void btnNextPersonal_Click(object sender, EventArgs e)
        {
            pnlClothing.Show();
            lblInfo.Text = "Please indicate whether a clothing pack is needed.";
            pnlPersonalDetials.Hide();


        }

        private void btnNextClothing_Click(object sender, EventArgs e)
        {
            pnlEmployeeDetials.Show();
            lblInfo.Text = "Please choose the workers responsible.";
            pnlClothing.Hide();
        }

        private void btnBackPersonal_Click(object sender, EventArgs e)
        {
            pnlPersonalDetials.Show();
            lblInfo.Text = "Please enter all of the following personal details.";
            pnlClothing.Hide();
        }

        private void btnBackClothing_Click(object sender, EventArgs e)
        {
            pnlClothing.Show();
            lblInfo.Text = "Please indicate whether a clothing pack is needed.";
            pnlEmployeeDetials.Hide();
        }
    }
}
