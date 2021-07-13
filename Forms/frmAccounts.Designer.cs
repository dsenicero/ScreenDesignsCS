
namespace SeniceroDAngelo_ScreenDesign.Forms
{
    partial class frmAccounts
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
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccounts = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(675, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 50);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFill
            // 
            this.lblFill.BackColor = System.Drawing.Color.White;
            this.lblFill.Location = new System.Drawing.Point(-1, 0);
            this.lblFill.Margin = new System.Windows.Forms.Padding(0);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(125, 50);
            this.lblFill.TabIndex = 7;
            this.lblFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Padding = new System.Windows.Forms.Padding(14, 0, 4, 0);
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(142, 50);
            this.addBooksToolStripMenuItem.Text = "&Add Authors";
            // 
            // booksListToolStripMenuItem
            // 
            this.booksListToolStripMenuItem.Name = "booksListToolStripMenuItem";
            this.booksListToolStripMenuItem.Size = new System.Drawing.Size(126, 50);
            this.booksListToolStripMenuItem.Text = "&Authors List";
            // 
            // editBooksToolStripMenuItem
            // 
            this.editBooksToolStripMenuItem.Name = "editBooksToolStripMenuItem";
            this.editBooksToolStripMenuItem.Size = new System.Drawing.Size(130, 50);
            this.editBooksToolStripMenuItem.Text = "&Edit Authors";
            // 
            // deleteBooksToolStripMenuItem
            // 
            this.deleteBooksToolStripMenuItem.Name = "deleteBooksToolStripMenuItem";
            this.deleteBooksToolStripMenuItem.Size = new System.Drawing.Size(153, 50);
            this.deleteBooksToolStripMenuItem.Text = "&Delete Authors";
            // 
            // mnuAccounts
            // 
            this.mnuAccounts.AllowMerge = false;
            this.mnuAccounts.AutoSize = false;
            this.mnuAccounts.BackColor = System.Drawing.Color.White;
            this.mnuAccounts.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAccounts.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.mnuAccounts.Location = new System.Drawing.Point(159, 0);
            this.mnuAccounts.Name = "mnuAccounts";
            this.mnuAccounts.Padding = new System.Windows.Forms.Padding(0);
            this.mnuAccounts.Size = new System.Drawing.Size(483, 50);
            this.mnuAccounts.TabIndex = 9;
            this.mnuAccounts.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(14, 0, 4, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 50);
            this.toolStripMenuItem1.Text = "&Add Books";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 50);
            this.toolStripMenuItem2.Text = "&Books List";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 50);
            this.toolStripMenuItem3.Text = "&Edit Books";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(136, 50);
            this.toolStripMenuItem4.Text = "&Delete Books";
            // 
            // frmAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.mnuAccounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFill);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccounts";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.mnuAccounts.ResumeLayout(false);
            this.mnuAccounts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBooksToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuAccounts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}