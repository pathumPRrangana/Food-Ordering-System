namespace Resturant_Management_System
{
    partial class adminitemcard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picpnl = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnpnl = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.itemname = new System.Windows.Forms.Label();
            this.availabilitylbl = new System.Windows.Forms.Label();
            this.largepricelbl = new System.Windows.Forms.Label();
            this.regularpricelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Regularlbl = new System.Windows.Forms.Label();
            this.picpnl.SuspendLayout();
            this.btnpnl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picpnl
            // 
            this.picpnl.Controls.Add(this.tableLayoutPanel1);
            this.picpnl.Controls.Add(this.availabilitylbl);
            this.picpnl.Controls.Add(this.largepricelbl);
            this.picpnl.Controls.Add(this.regularpricelbl);
            this.picpnl.Controls.Add(this.label1);
            this.picpnl.Controls.Add(this.Regularlbl);
            this.picpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.picpnl.Location = new System.Drawing.Point(0, 0);
            this.picpnl.Name = "picpnl";
            this.picpnl.Size = new System.Drawing.Size(219, 207);
            this.picpnl.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(77)))), ((int)(((byte)(39)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(26, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(165, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "EDIT";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnpnl
            // 
            this.btnpnl.Controls.Add(this.guna2Button1);
            this.btnpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnpnl.Location = new System.Drawing.Point(0, 207);
            this.btnpnl.Name = "btnpnl";
            this.btnpnl.Size = new System.Drawing.Size(219, 51);
            this.btnpnl.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.itemname, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 41);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Location = new System.Drawing.Point(3, 0);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(210, 41);
            this.itemname.TabIndex = 0;
            this.itemname.Text = "label1";
            this.itemname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availabilitylbl
            // 
            this.availabilitylbl.AutoSize = true;
            this.availabilitylbl.Location = new System.Drawing.Point(80, 177);
            this.availabilitylbl.Name = "availabilitylbl";
            this.availabilitylbl.Size = new System.Drawing.Size(44, 16);
            this.availabilitylbl.TabIndex = 11;
            this.availabilitylbl.Text = "label2";
            // 
            // largepricelbl
            // 
            this.largepricelbl.AutoSize = true;
            this.largepricelbl.Location = new System.Drawing.Point(115, 128);
            this.largepricelbl.Name = "largepricelbl";
            this.largepricelbl.Size = new System.Drawing.Size(44, 16);
            this.largepricelbl.TabIndex = 10;
            this.largepricelbl.Text = "label2";
            // 
            // regularpricelbl
            // 
            this.regularpricelbl.AutoSize = true;
            this.regularpricelbl.Location = new System.Drawing.Point(115, 90);
            this.regularpricelbl.Name = "regularpricelbl";
            this.regularpricelbl.Size = new System.Drawing.Size(44, 16);
            this.regularpricelbl.TabIndex = 9;
            this.regularpricelbl.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Large";
            // 
            // Regularlbl
            // 
            this.Regularlbl.AutoSize = true;
            this.Regularlbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regularlbl.Location = new System.Drawing.Point(32, 87);
            this.Regularlbl.Name = "Regularlbl";
            this.Regularlbl.Size = new System.Drawing.Size(60, 20);
            this.Regularlbl.TabIndex = 7;
            this.Regularlbl.Text = "Regular";
            // 
            // adminitemcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.btnpnl);
            this.Controls.Add(this.picpnl);
            this.Name = "adminitemcard";
            this.Size = new System.Drawing.Size(219, 258);
            this.Load += new System.EventHandler(this.adminitemcard_Load);
            this.picpnl.ResumeLayout(false);
            this.picpnl.PerformLayout();
            this.btnpnl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel picpnl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel btnpnl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Label availabilitylbl;
        private System.Windows.Forms.Label largepricelbl;
        private System.Windows.Forms.Label regularpricelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Regularlbl;
    }
}
