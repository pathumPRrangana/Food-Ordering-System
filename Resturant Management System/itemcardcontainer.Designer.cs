namespace Resturant_Management_System
{
    partial class itemcardcontainer
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
            this.containerpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // containerpanel
            // 
            this.containerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerpanel.Location = new System.Drawing.Point(0, 0);
            this.containerpanel.Name = "containerpanel";
            this.containerpanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.containerpanel.Size = new System.Drawing.Size(942, 688);
            this.containerpanel.TabIndex = 0;
            this.containerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.containerpanel_Paint);
            // 
            // itemcardcontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.containerpanel);
            this.Name = "itemcardcontainer";
            this.Size = new System.Drawing.Size(942, 688);
            this.Load += new System.EventHandler(this.itemcardcontainer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel containerpanel;
    }
}
