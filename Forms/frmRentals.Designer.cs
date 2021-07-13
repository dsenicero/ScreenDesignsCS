
namespace SeniceroDAngelo_ScreenDesign.Forms
{
    partial class frmRentals
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
            if(disposing && (components != null))
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFill = new System.Windows.Forms.Label();
            this.mnuRentals = new System.Windows.Forms.MenuStrip();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentals.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(527, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 50);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFill
            // 
            this.lblFill.BackColor = System.Drawing.Color.White;
            this.lblFill.Location = new System.Drawing.Point(0, 0);
            this.lblFill.Margin = new System.Windows.Forms.Padding(0);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(273, 50);
            this.lblFill.TabIndex = 7;
            this.lblFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuRentals
            // 
            this.mnuRentals.AllowMerge = false;
            this.mnuRentals.AutoSize = false;
            this.mnuRentals.BackColor = System.Drawing.Color.White;
            this.mnuRentals.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuRentals.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuRentals.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuRentals.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBooksToolStripMenuItem,
            this.booksListToolStripMenuItem});
            this.mnuRentals.Location = new System.Drawing.Point(273, 0);
            this.mnuRentals.Name = "mnuRentals";
            this.mnuRentals.Padding = new System.Windows.Forms.Padding(0);
            this.mnuRentals.Size = new System.Drawing.Size(254, 50);
            this.mnuRentals.TabIndex = 6;
            this.mnuRentals.Text = "mnuMainBooks";
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Padding = new System.Windows.Forms.Padding(14, 0, 4, 0);
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(125, 50);
            this.addBooksToolStripMenuItem.Text = "&Issue Book";
            this.addBooksToolStripMenuItem.MouseEnter += new System.EventHandler(this.addBooksToolStripMenuItem_MouseEnter);
            this.addBooksToolStripMenuItem.MouseLeave += new System.EventHandler(this.addBooksToolStripMenuItem_MouseLeave);
            // 
            // booksListToolStripMenuItem
            // 
            this.booksListToolStripMenuItem.Name = "booksListToolStripMenuItem";
            this.booksListToolStripMenuItem.Size = new System.Drawing.Size(129, 50);
            this.booksListToolStripMenuItem.Text = "&Return Book";
            // 
            // frmRentals
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFill);
            this.Controls.Add(this.mnuRentals);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRentals";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentals";
            this.mnuRentals.ResumeLayout(false);
            this.mnuRentals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.MenuStrip mnuRentals;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksListToolStripMenuItem;
    }
}