namespace Resturant_Management_System
{
    partial class addDessertsForm
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
            this.addDessertpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // addDessertpnl
            // 
            this.addDessertpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDessertpnl.Location = new System.Drawing.Point(0, 0);
            this.addDessertpnl.Name = "addDessertpnl";
            this.addDessertpnl.Size = new System.Drawing.Size(1105, 790);
            this.addDessertpnl.TabIndex = 0;
            // 
            // addDessertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.addDessertpnl);
            this.Name = "addDessertsForm";
            this.Size = new System.Drawing.Size(1105, 790);
            this.Load += new System.EventHandler(this.addDessertsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel addDessertpnl;
    }
}
