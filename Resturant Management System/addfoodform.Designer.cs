namespace Resturant_Management_System
{
    partial class addfoodform
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
            this.addfoodpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // addfoodpnl
            // 
            this.addfoodpnl.BackColor = System.Drawing.Color.Transparent;
            this.addfoodpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addfoodpnl.Location = new System.Drawing.Point(0, 0);
            this.addfoodpnl.Name = "addfoodpnl";
            this.addfoodpnl.Size = new System.Drawing.Size(1105, 790);
            this.addfoodpnl.TabIndex = 0;
            // 
            // addfoodform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.addfoodpnl);
            this.Name = "addfoodform";
            this.Size = new System.Drawing.Size(1105, 790);
            this.Load += new System.EventHandler(this.addfoodform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel addfoodpnl;
    }
}
