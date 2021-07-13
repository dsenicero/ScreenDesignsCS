
namespace SeniceroDAngelo_ScreenDesign.Forms
{
    partial class frmSubjects
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
            this.mnuMainBooks = new System.Windows.Forms.MenuStrip();
            this.mnuSubjects = new System.Windows.Forms.MenuStrip();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(682, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 50);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFill
            // 
            this.lblFill.BackColor = System.Drawing.Color.White;
            this.lblFill.Location = new System.Drawing.Point(0, 0);
            this.lblFill.Margin = new System.Windows.Forms.Padding(0);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(119, 50);
            this.lblFill.TabIndex = 7;
            this.lblFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuMainBooks
            // 
            this.mnuMainBooks.AllowMerge = false;
            this.mnuMainBooks.AutoSize = false;
            this.mnuMainBooks.BackColor = System.Drawing.Color.White;
            this.mnuMainBooks.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMainBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainBooks.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuMainBooks.Location = new System.Drawing.Point(119, 0);
            this.mnuMainBooks.Name = "mnuMainBooks";
            this.mnuMainBooks.Padding = new System.Windows.Forms.Padding(0);
            this.mnuMainBooks.Size = new System.Drawing.Size(563, 50);
            this.mnuMainBooks.TabIndex = 6;
            this.mnuMainBooks.Text = "mnuMainBooks";
            // 
            // mnuSubjects
            // 
            this.mnuSubjects.AllowMerge = false;
            this.mnuSubjects.AutoSize = false;
            this.mnuSubjects.BackColor = System.Drawing.Color.White;
            this.mnuSubjects.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuSubjects.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSubjects.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuSubjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBooksToolStripMenuItem,
            this.booksListToolStripMenuItem,
            this.editBooksToolStripMenuItem,
            this.deleteBooksToolStripMenuItem});
            this.mnuSubjects.Location = new System.Drawing.Point(159, 225);
            this.mnuSubjects.Name = "mnuSubjects";
            this.mnuSubjects.Padding = new System.Windows.Forms.Padding(0);
            this.mnuSubjects.Size = new System.Drawing.Size(483, 50);
            this.mnuSubjects.TabIndex = 9;
            this.mnuSubjects.Text = "menuStrip1";
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
            // frmSubjects
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.mnuSubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFill);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubjects";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects";
            this.mnuSubjects.ResumeLayout(false);
            this.mnuSubjects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.MenuStrip mnuMainBooks;
        private System.Windows.Forms.MenuStrip mnuSubjects;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBooksToolStripMenuItem;
    }
}