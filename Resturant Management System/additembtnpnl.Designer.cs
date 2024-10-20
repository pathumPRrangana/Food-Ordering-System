namespace Resturant_Management_System
{
    partial class additembtnpnl
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
            this.additembtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // additembtn
            // 
            this.additembtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.additembtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.additembtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.additembtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.additembtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additembtn.FillColor = System.Drawing.Color.Silver;
            this.additembtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additembtn.ForeColor = System.Drawing.Color.Black;
            this.additembtn.Location = new System.Drawing.Point(0, 0);
            this.additembtn.Name = "additembtn";
            this.additembtn.Size = new System.Drawing.Size(219, 258);
            this.additembtn.TabIndex = 0;
            this.additembtn.Text = "ADD";
            this.additembtn.Click += new System.EventHandler(this.additembtn_Click);
            // 
            // additembtnpnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.additembtn);
            this.Name = "additembtnpnl";
            this.Size = new System.Drawing.Size(219, 258);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button additembtn;
    }
}
