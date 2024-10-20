namespace Resturant_Management_System
{
    partial class drinkitemsContainer
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
            this.drinkItemcontainerpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // drinkItemcontainerpnl
            // 
            this.drinkItemcontainerpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkItemcontainerpnl.Location = new System.Drawing.Point(0, 0);
            this.drinkItemcontainerpnl.Name = "drinkItemcontainerpnl";
            this.drinkItemcontainerpnl.Size = new System.Drawing.Size(942, 688);
            this.drinkItemcontainerpnl.TabIndex = 0;
            // 
            // drinkitemsContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.drinkItemcontainerpnl);
            this.Name = "drinkitemsContainer";
            this.Size = new System.Drawing.Size(942, 688);
            this.Load += new System.EventHandler(this.drinkitemsContainer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel drinkItemcontainerpnl;
    }
}
