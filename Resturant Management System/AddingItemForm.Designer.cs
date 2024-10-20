namespace Resturant_Management_System
{
    partial class AddingItemForm
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
            this.titlelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regularsize = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Large = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regularprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.largeprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.yesavailability = new System.Windows.Forms.RadioButton();
            this.noavailability = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.White;
            this.titlelbl.Location = new System.Drawing.Point(205, 44);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(137, 31);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "ADD ITEMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name:";
            // 
            // itemname
            // 
            this.itemname.AutoRoundedCorners = true;
            this.itemname.BorderColor = System.Drawing.Color.White;
            this.itemname.BorderRadius = 23;
            this.itemname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemname.DefaultText = "";
            this.itemname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.itemname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itemname.ForeColor = System.Drawing.Color.White;
            this.itemname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemname.Location = new System.Drawing.Point(268, 108);
            this.itemname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemname.Name = "itemname";
            this.itemname.PasswordChar = '\0';
            this.itemname.PlaceholderText = "Item Name";
            this.itemname.SelectedText = "";
            this.itemname.Size = new System.Drawing.Size(229, 48);
            this.itemname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Sizes:";
            // 
            // regularsize
            // 
            this.regularsize.AutoSize = true;
            this.regularsize.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regularsize.CheckedState.BorderRadius = 0;
            this.regularsize.CheckedState.BorderThickness = 0;
            this.regularsize.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regularsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.regularsize.ForeColor = System.Drawing.Color.White;
            this.regularsize.Location = new System.Drawing.Point(113, 227);
            this.regularsize.Name = "regularsize";
            this.regularsize.Size = new System.Drawing.Size(77, 20);
            this.regularsize.TabIndex = 4;
            this.regularsize.Text = "Regular";
            this.regularsize.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.regularsize.UncheckedState.BorderRadius = 0;
            this.regularsize.UncheckedState.BorderThickness = 0;
            this.regularsize.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Large
            // 
            this.Large.AutoSize = true;
            this.Large.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Large.CheckedState.BorderRadius = 0;
            this.Large.CheckedState.BorderThickness = 0;
            this.Large.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Large.ForeColor = System.Drawing.Color.White;
            this.Large.Location = new System.Drawing.Point(379, 227);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(64, 20);
            this.Large.TabIndex = 5;
            this.Large.Text = "Large";
            this.Large.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Large.UncheckedState.BorderRadius = 0;
            this.Large.UncheckedState.BorderThickness = 0;
            this.Large.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(503, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Price:";
            // 
            // regularprice
            // 
            this.regularprice.AutoRoundedCorners = true;
            this.regularprice.BorderColor = System.Drawing.Color.White;
            this.regularprice.BorderRadius = 23;
            this.regularprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regularprice.DefaultText = "";
            this.regularprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regularprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regularprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regularprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regularprice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.regularprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regularprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regularprice.ForeColor = System.Drawing.Color.White;
            this.regularprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regularprice.Location = new System.Drawing.Point(56, 323);
            this.regularprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regularprice.Name = "regularprice";
            this.regularprice.PasswordChar = '\0';
            this.regularprice.PlaceholderText = "Regular Price";
            this.regularprice.SelectedText = "";
            this.regularprice.Size = new System.Drawing.Size(175, 48);
            this.regularprice.TabIndex = 8;
            // 
            // largeprice
            // 
            this.largeprice.AutoRoundedCorners = true;
            this.largeprice.BorderColor = System.Drawing.Color.White;
            this.largeprice.BorderRadius = 23;
            this.largeprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.largeprice.DefaultText = "";
            this.largeprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.largeprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.largeprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.largeprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.largeprice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.largeprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.largeprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.largeprice.ForeColor = System.Drawing.Color.White;
            this.largeprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.largeprice.Location = new System.Drawing.Point(322, 323);
            this.largeprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.largeprice.Name = "largeprice";
            this.largeprice.PasswordChar = '\0';
            this.largeprice.PlaceholderText = "Large Price";
            this.largeprice.SelectedText = "";
            this.largeprice.Size = new System.Drawing.Size(175, 48);
            this.largeprice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Regular Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(338, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Large Price";
            // 
            // addbtn
            // 
            this.addbtn.Animated = true;
            this.addbtn.AutoRoundedCorners = true;
            this.addbtn.BorderRadius = 29;
            this.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.Location = new System.Drawing.Point(176, 517);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(194, 60);
            this.addbtn.TabIndex = 15;
            this.addbtn.Text = "ADD";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(52, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Availability:";
            // 
            // yesavailability
            // 
            this.yesavailability.AutoSize = true;
            this.yesavailability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesavailability.ForeColor = System.Drawing.Color.White;
            this.yesavailability.Location = new System.Drawing.Point(128, 438);
            this.yesavailability.Name = "yesavailability";
            this.yesavailability.Size = new System.Drawing.Size(51, 24);
            this.yesavailability.TabIndex = 17;
            this.yesavailability.TabStop = true;
            this.yesavailability.Text = "Yes";
            this.yesavailability.UseVisualStyleBackColor = true;
            // 
            // noavailability
            // 
            this.noavailability.AutoSize = true;
            this.noavailability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noavailability.ForeColor = System.Drawing.Color.White;
            this.noavailability.Location = new System.Drawing.Point(379, 438);
            this.noavailability.Name = "noavailability";
            this.noavailability.Size = new System.Drawing.Size(50, 24);
            this.noavailability.TabIndex = 18;
            this.noavailability.TabStop = true;
            this.noavailability.Text = "No";
            this.noavailability.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddingItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(549, 586);
            this.Controls.Add(this.noavailability);
            this.Controls.Add(this.yesavailability);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.largeprice);
            this.Controls.Add(this.regularprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Large);
            this.Controls.Add(this.regularsize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titlelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddingItemForm";
            this.Load += new System.EventHandler(this.AddingItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox itemname;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox regularsize;
        private Guna.UI2.WinForms.Guna2CheckBox Large;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox regularprice;
        private Guna.UI2.WinForms.Guna2TextBox largeprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button addbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton yesavailability;
        private System.Windows.Forms.RadioButton noavailability;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}