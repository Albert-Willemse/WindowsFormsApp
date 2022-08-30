
namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.ToolStripMenuItem toolStripSeparator1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDaxhboard = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thusaBasadiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.AutoSize = false;
            toolStripSeparator1.BackColor = System.Drawing.Color.White;
            toolStripSeparator1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Separator1px;
            toolStripSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            toolStripSeparator1.Enabled = false;
            toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            toolStripSeparator1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            toolStripSeparator1.Size = new System.Drawing.Size(181, 1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnContactUs);
            this.panel1.Controls.Add(this.btnManage);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 417);
            this.panel1.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 74);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 2;
            // 
            // btnContactUs
            // 
            this.btnContactUs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactUs.ForeColor = System.Drawing.Color.White;
            this.btnContactUs.Image = global::WindowsFormsApp1.Properties.Resources.settings;
            this.btnContactUs.Location = new System.Drawing.Point(0, 365);
            this.btnContactUs.Margin = new System.Windows.Forms.Padding(4);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(202, 52);
            this.btnContactUs.TabIndex = 1;
            this.btnContactUs.Text = " Contact Us";
            this.btnContactUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContactUs.UseVisualStyleBackColor = true;
            this.btnContactUs.Click += new System.EventHandler(this.btnContactUs_Click);
            this.btnContactUs.Leave += new System.EventHandler(this.btnContactUs_Leave);
            // 
            // btnManage
            // 
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Image = global::WindowsFormsApp1.Properties.Resources.diagram;
            this.btnManage.Location = new System.Drawing.Point(0, 118);
            this.btnManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(202, 52);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = " Manage";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            this.btnManage.Leave += new System.EventHandler(this.btnManage_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = global::WindowsFormsApp1.Properties.Resources.Conact;
            this.btnRegister.Location = new System.Drawing.Point(0, 66);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(202, 52);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = " Register";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.Leave += new System.EventHandler(this.btnRegister_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDaxhboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 66);
            this.panel2.TabIndex = 0;
            // 
            // btnDaxhboard
            // 
            this.btnDaxhboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDaxhboard.FlatAppearance.BorderSize = 0;
            this.btnDaxhboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaxhboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaxhboard.ForeColor = System.Drawing.Color.White;
            this.btnDaxhboard.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.btnDaxhboard.Location = new System.Drawing.Point(0, 14);
            this.btnDaxhboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDaxhboard.Name = "btnDaxhboard";
            this.btnDaxhboard.Size = new System.Drawing.Size(202, 52);
            this.btnDaxhboard.TabIndex = 1;
            this.btnDaxhboard.Text = " Dashboard";
            this.btnDaxhboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDaxhboard.UseVisualStyleBackColor = true;
            this.btnDaxhboard.Click += new System.EventHandler(this.btnDaxhboard_Click);
            this.btnDaxhboard.Leave += new System.EventHandler(this.btnDaxhboard_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thusaBasadiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thusaBasadiToolStripMenuItem
            // 
            this.thusaBasadiToolStripMenuItem.AccessibleDescription = "";
            this.thusaBasadiToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thusaBasadiToolStripMenuItem.AutoToolTip = true;
            this.thusaBasadiToolStripMenuItem.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_11;
            this.thusaBasadiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDetailsToolStripMenuItem,
            toolStripSeparator1,
            this.logOutToolStripMenuItem});
            this.thusaBasadiToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thusaBasadiToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_11;
            this.thusaBasadiToolStripMenuItem.Name = "thusaBasadiToolStripMenuItem";
            this.thusaBasadiToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.thusaBasadiToolStripMenuItem.Tag = "";
            this.thusaBasadiToolStripMenuItem.Text = "User Name   ";
            this.thusaBasadiToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.thusaBasadiToolStripMenuItem.ToolTipText = "Account Settings";
            // 
            // editDetailsToolStripMenuItem
            // 
            this.editDetailsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editDetailsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editDetailsToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDetailsToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.editDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editDetailsToolStripMenuItem.Name = "editDetailsToolStripMenuItem";
            this.editDetailsToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.editDetailsToolStripMenuItem.Text = "Edit details";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.log_out;
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDaxhboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem thusaBasadiToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}