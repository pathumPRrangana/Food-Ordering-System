namespace Resturant_Management_System
{
    partial class itemcard
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.itemname = new System.Windows.Forms.Label();
            this.Regularlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regularpricelbl = new System.Windows.Forms.Label();
            this.largepricelbl = new System.Windows.Forms.Label();
            this.availabilitylbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel1.Controls.Add(this.availabilitylbl);
            this.guna2Panel1.Controls.Add(this.largepricelbl);
            this.guna2Panel1.Controls.Add(this.regularpricelbl);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.Regularlbl);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(219, 207);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 207);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(219, 51);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(77)))), ((int)(((byte)(39)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(28, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(165, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "ADD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            // Regularlbl
            // 
            this.Regularlbl.AutoSize = true;
            this.Regularlbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regularlbl.Location = new System.Drawing.Point(34, 88);
            this.Regularlbl.Name = "Regularlbl";
            this.Regularlbl.Size = new System.Drawing.Size(60, 20);
            this.Regularlbl.TabIndex = 1;
            this.Regularlbl.Text = "Regular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Large";
            // 
            // regularpricelbl
            // 
            this.regularpricelbl.AutoSize = true;
            this.regularpricelbl.Location = new System.Drawing.Point(117, 91);
            this.regularpricelbl.Name = "regularpricelbl";
            this.regularpricelbl.Size = new System.Drawing.Size(44, 16);
            this.regularpricelbl.TabIndex = 3;
            this.regularpricelbl.Text = "label2";
            // 
            // largepricelbl
            // 
            this.largepricelbl.AutoSize = true;
            this.largepricelbl.Location = new System.Drawing.Point(117, 129);
            this.largepricelbl.Name = "largepricelbl";
            this.largepricelbl.Size = new System.Drawing.Size(44, 16);
            this.largepricelbl.TabIndex = 4;
            this.largepricelbl.Text = "label2";
            // 
            // availabilitylbl
            // 
            this.availabilitylbl.AutoSize = true;
            this.availabilitylbl.Location = new System.Drawing.Point(82, 178);
            this.availabilitylbl.Name = "availabilitylbl";
            this.availabilitylbl.Size = new System.Drawing.Size(44, 16);
            this.availabilitylbl.TabIndex = 5;
            this.availabilitylbl.Text = "label2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.itemname, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 41);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // itemcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "itemcard";
            this.Size = new System.Drawing.Size(219, 258);
            this.Load += new System.EventHandler(this.itemcard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Regularlbl;
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Label regularpricelbl;
        private System.Windows.Forms.Label availabilitylbl;
        private System.Windows.Forms.Label largepricelbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
