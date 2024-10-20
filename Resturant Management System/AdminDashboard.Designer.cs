namespace Resturant_Management_System
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.menupanel = new System.Windows.Forms.Panel();
            this.orderhistorybtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.dessertsaddbtn = new Guna.UI2.WinForms.Guna2Button();
            this.drinksaddbtn = new Guna.UI2.WinForms.Guna2Button();
            this.foodsaddbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AdminItempnl = new Guna.UI2.WinForms.Guna2Panel();
            this.menupanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1060, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1009, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 45);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.Transparent;
            this.menupanel.Controls.Add(this.orderhistorybtn);
            this.menupanel.Controls.Add(this.label1);
            this.menupanel.Controls.Add(this.logoutbtn);
            this.menupanel.Controls.Add(this.dessertsaddbtn);
            this.menupanel.Controls.Add(this.drinksaddbtn);
            this.menupanel.Controls.Add(this.foodsaddbtn);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(317, 844);
            this.menupanel.TabIndex = 2;
            this.menupanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menupanel_Paint);
            // 
            // orderhistorybtn
            // 
            this.orderhistorybtn.Animated = true;
            this.orderhistorybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderhistorybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderhistorybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderhistorybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderhistorybtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.orderhistorybtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.orderhistorybtn.ForeColor = System.Drawing.Color.Black;
            this.orderhistorybtn.Location = new System.Drawing.Point(0, 146);
            this.orderhistorybtn.Name = "orderhistorybtn";
            this.orderhistorybtn.Size = new System.Drawing.Size(317, 80);
            this.orderhistorybtn.TabIndex = 5;
            this.orderhistorybtn.Text = "Order History";
            this.orderhistorybtn.Click += new System.EventHandler(this.orderhistorybtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "GALLEdn PUB";
            // 
            // logoutbtn
            // 
            this.logoutbtn.Animated = true;
            this.logoutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logoutbtn.ForeColor = System.Drawing.Color.Black;
            this.logoutbtn.Location = new System.Drawing.Point(0, 763);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(317, 80);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Log out";
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // dessertsaddbtn
            // 
            this.dessertsaddbtn.Animated = true;
            this.dessertsaddbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dessertsaddbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dessertsaddbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dessertsaddbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dessertsaddbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.dessertsaddbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dessertsaddbtn.ForeColor = System.Drawing.Color.Black;
            this.dessertsaddbtn.Location = new System.Drawing.Point(0, 390);
            this.dessertsaddbtn.Name = "dessertsaddbtn";
            this.dessertsaddbtn.Size = new System.Drawing.Size(317, 80);
            this.dessertsaddbtn.TabIndex = 2;
            this.dessertsaddbtn.Text = "Desserts";
            this.dessertsaddbtn.Click += new System.EventHandler(this.dessertsaddbtn_Click);
            // 
            // drinksaddbtn
            // 
            this.drinksaddbtn.Animated = true;
            this.drinksaddbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.drinksaddbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.drinksaddbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.drinksaddbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.drinksaddbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.drinksaddbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.drinksaddbtn.ForeColor = System.Drawing.Color.Black;
            this.drinksaddbtn.Location = new System.Drawing.Point(0, 309);
            this.drinksaddbtn.Name = "drinksaddbtn";
            this.drinksaddbtn.Size = new System.Drawing.Size(317, 80);
            this.drinksaddbtn.TabIndex = 1;
            this.drinksaddbtn.Text = "Drinks";
            this.drinksaddbtn.Click += new System.EventHandler(this.drinksaddbtn_Click);
            // 
            // foodsaddbtn
            // 
            this.foodsaddbtn.Animated = true;
            this.foodsaddbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.foodsaddbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.foodsaddbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.foodsaddbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.foodsaddbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.foodsaddbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.foodsaddbtn.ForeColor = System.Drawing.Color.Black;
            this.foodsaddbtn.Location = new System.Drawing.Point(0, 228);
            this.foodsaddbtn.Name = "foodsaddbtn";
            this.foodsaddbtn.Size = new System.Drawing.Size(317, 80);
            this.foodsaddbtn.TabIndex = 0;
            this.foodsaddbtn.Text = "Foods";
            this.foodsaddbtn.Click += new System.EventHandler(this.foodsaddbtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(317, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1105, 54);
            this.guna2Panel1.TabIndex = 4;
            // 
            // AdminItempnl
            // 
            this.AdminItempnl.BackColor = System.Drawing.Color.White;
            this.AdminItempnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminItempnl.Location = new System.Drawing.Point(317, 54);
            this.AdminItempnl.Name = "AdminItempnl";
            this.AdminItempnl.Size = new System.Drawing.Size(1105, 790);
            this.AdminItempnl.TabIndex = 5;
            this.AdminItempnl.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminItempnl_Paint);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1422, 844);
            this.Controls.Add(this.AdminItempnl);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.menupanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Panel menupanel;
        private Guna.UI2.WinForms.Guna2Button dessertsaddbtn;
        private Guna.UI2.WinForms.Guna2Button drinksaddbtn;
        private Guna.UI2.WinForms.Guna2Button foodsaddbtn;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button orderhistorybtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2Panel AdminItempnl;
    }
}