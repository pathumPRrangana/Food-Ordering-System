namespace Resturant_Management_System
{
    partial class ItemOrderForm
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
            this.foodnametxt = new System.Windows.Forms.Label();
            this.foodsizetxt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.DomainUpDown();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addorderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regulerpriselbl = new System.Windows.Forms.Label();
            this.largepricelbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodnametxt
            // 
            this.foodnametxt.AutoSize = true;
            this.foodnametxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodnametxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodnametxt.Location = new System.Drawing.Point(3, 0);
            this.foodnametxt.Name = "foodnametxt";
            this.foodnametxt.Size = new System.Drawing.Size(652, 51);
            this.foodnametxt.TabIndex = 0;
            this.foodnametxt.Text = "Food Name";
            this.foodnametxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodsizetxt
            // 
            this.foodsizetxt.AutoRoundedCorners = true;
            this.foodsizetxt.BackColor = System.Drawing.Color.Transparent;
            this.foodsizetxt.BorderRadius = 17;
            this.foodsizetxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.foodsizetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodsizetxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.foodsizetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.foodsizetxt.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.foodsizetxt.ForeColor = System.Drawing.Color.Black;
            this.foodsizetxt.ItemHeight = 30;
            this.foodsizetxt.Items.AddRange(new object[] {
            "--No Selection--"});
            this.foodsizetxt.Location = new System.Drawing.Point(299, 262);
            this.foodsizetxt.Name = "foodsizetxt";
            this.foodsizetxt.Size = new System.Drawing.Size(277, 36);
            this.foodsizetxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Items.Add("1");
            this.quantity.Items.Add("2");
            this.quantity.Items.Add("3");
            this.quantity.Items.Add("4");
            this.quantity.Items.Add("5");
            this.quantity.Items.Add("6");
            this.quantity.Items.Add("7");
            this.quantity.Items.Add("8");
            this.quantity.Items.Add("9");
            this.quantity.Items.Add("10");
            this.quantity.Location = new System.Drawing.Point(299, 352);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 30);
            this.quantity.TabIndex = 4;
            this.quantity.Text = "Quantity";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(609, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.foodnametxt, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 51);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // addorderbtn
            // 
            this.addorderbtn.Animated = true;
            this.addorderbtn.AutoRoundedCorners = true;
            this.addorderbtn.BorderRadius = 21;
            this.addorderbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addorderbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addorderbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addorderbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addorderbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(48)))));
            this.addorderbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addorderbtn.ForeColor = System.Drawing.Color.White;
            this.addorderbtn.Location = new System.Drawing.Point(258, 427);
            this.addorderbtn.Name = "addorderbtn";
            this.addorderbtn.Size = new System.Drawing.Size(143, 45);
            this.addorderbtn.TabIndex = 7;
            this.addorderbtn.Text = "ADD";
            this.addorderbtn.Click += new System.EventHandler(this.addorderbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reguler Price (LKR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Large Price (LKR)";
            // 
            // regulerpriselbl
            // 
            this.regulerpriselbl.AutoSize = true;
            this.regulerpriselbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regulerpriselbl.Location = new System.Drawing.Point(104, 179);
            this.regulerpriselbl.Name = "regulerpriselbl";
            this.regulerpriselbl.Size = new System.Drawing.Size(55, 23);
            this.regulerpriselbl.TabIndex = 10;
            this.regulerpriselbl.Text = "label5";
            // 
            // largepricelbl
            // 
            this.largepricelbl.AutoEllipsis = true;
            this.largepricelbl.AutoSize = true;
            this.largepricelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largepricelbl.Location = new System.Drawing.Point(421, 179);
            this.largepricelbl.Name = "largepricelbl";
            this.largepricelbl.Size = new System.Drawing.Size(55, 23);
            this.largepricelbl.TabIndex = 11;
            this.largepricelbl.Text = "label5";
            // 
            // ItemOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(653, 528);
            this.Controls.Add(this.largepricelbl);
            this.Controls.Add(this.regulerpriselbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addorderbtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodsizetxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemOrderForm";
            this.Text = "ItemOrderForm";
            this.Load += new System.EventHandler(this.ItemOrderForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodnametxt;
        private Guna.UI2.WinForms.Guna2ComboBox foodsizetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown quantity;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button addorderbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label regulerpriselbl;
        private System.Windows.Forms.Label largepricelbl;
    }
}