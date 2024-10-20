namespace Resturant_Management_System
{
    partial class dessertsItemsContainer
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
            this.dessertItempnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dessertItempnl
            // 
            this.dessertItempnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dessertItempnl.Location = new System.Drawing.Point(0, 0);
            this.dessertItempnl.Name = "dessertItempnl";
            this.dessertItempnl.Size = new System.Drawing.Size(942, 688);
            this.dessertItempnl.TabIndex = 0;
            // 
            // dessertsItemsContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dessertItempnl);
            this.Name = "dessertsItemsContainer";
            this.Size = new System.Drawing.Size(942, 688);
            this.Load += new System.EventHandler(this.dessertsItemsContainer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dessertItempnl;
    }
}
