
namespace SeniceroDAngelo_ScreenDesign.Forms
{
    partial class frmBooks
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
            this.mnuBooks = new System.Windows.Forms.MenuStrip();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBooks
            // 
            this.mnuBooks.AllowMerge = false;
            this.mnuBooks.AutoSize = false;
            this.mnuBooks.BackColor = System.Drawing.Color.White;
            this.mnuBooks.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBooks.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBooksToolStripMenuItem,
            this.booksListToolStripMenuItem,
            this.editBooksToolStripMenuItem,
            this.deleteBooksToolStripMenuItem});
            this.mnuBooks.Location = new System.Drawing.Point(159, 0);
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Padding = new System.Windows.Forms.Padding(0);
            this.mnuBooks.Size = new System.Drawing.Size(483, 50);
            this.mnuBooks.TabIndex = 0;
            this.mnuBooks.Text = "mnuMainBooks";
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Padding = new System.Windows.Forms.Padding(14, 0, 4, 0);
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(125, 50);
            this.addBooksToolStripMenuItem.Text = "&Add Books";
            // 
            // booksListToolStripMenuItem
            // 
            this.booksListToolStripMenuItem.Name = "booksListToolStripMenuItem";
            this.booksListToolStripMenuItem.Size = new System.Drawing.Size(109, 50);
            this.booksListToolStripMenuItem.Text = "&Books List";
            // 
            // editBooksToolStripMenuItem
            // 
            this.editBooksToolStripMenuItem.Name = "editBooksToolStripMenuItem";
            this.editBooksToolStripMenuItem.Size = new System.Drawing.Size(113, 50);
            this.editBooksToolStripMenuItem.Text = "&Edit Books";
            // 
            // deleteBooksToolStripMenuItem
            // 
            this.deleteBooksToolStripMenuItem.Name = "deleteBooksToolStripMenuItem";
            this.deleteBooksToolStripMenuItem.Size = new System.Drawing.Size(136, 50);
            this.deleteBooksToolStripMenuItem.Text = "&Delete Books";
            // 
            // lblFill
            // 
            this.lblFill.BackColor = System.Drawing.Color.White;
            this.lblFill.Location = new System.Drawing.Point(0, 0);
            this.lblFill.Margin = new System.Windows.Forms.Padding(0);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(159, 50);
            this.lblFill.TabIndex = 1;
            this.lblFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(642, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 50);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFill);
            this.Controls.Add(this.mnuBooks);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuBooks;
            this.MaximizeBox = false;
            this.Name = "frmBooks";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.mnuBooks.ResumeLayout(false);
            this.mnuBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBooks;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksListToolStripMenuItem;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.Label label1;
    }
}