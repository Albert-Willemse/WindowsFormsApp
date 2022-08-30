
namespace WindowsFormsApp1
{
    partial class frmBookIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEmployeeDetials = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlEmployeeDetials.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book in";
            // 
            // pnlEmployeeDetials
            // 
            this.pnlEmployeeDetials.BackColor = System.Drawing.Color.White;
            this.pnlEmployeeDetials.Controls.Add(this.textBox1);
            this.pnlEmployeeDetials.Controls.Add(this.comboBox1);
            this.pnlEmployeeDetials.Controls.Add(this.btnRegister);
            this.pnlEmployeeDetials.Controls.Add(this.label18);
            this.pnlEmployeeDetials.Controls.Add(this.label6);
            this.pnlEmployeeDetials.Controls.Add(this.label9);
            this.pnlEmployeeDetials.Controls.Add(this.label8);
            this.pnlEmployeeDetials.Location = new System.Drawing.Point(50, 137);
            this.pnlEmployeeDetials.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmployeeDetials.Name = "pnlEmployeeDetials";
            this.pnlEmployeeDetials.Size = new System.Drawing.Size(478, 213);
            this.pnlEmployeeDetials.TabIndex = 18;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(192)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(169, 151);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(198, 32);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Book in";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(90, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 19);
            this.label18.TabIndex = 9;
            this.label18.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(118, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Amount:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(50, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 57);
            this.panel1.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(231, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Required items marked with ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(32, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(245, 19);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Please enter all of the following details.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Xtra Large"});
            this.comboBox1.Location = new System.Drawing.Point(169, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 11;
            // 
            // frmBookIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 417);
            this.Controls.Add(this.pnlEmployeeDetials);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookIn";
            this.Text = "Book In";
            this.pnlEmployeeDetials.ResumeLayout(false);
            this.pnlEmployeeDetials.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEmployeeDetials;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}