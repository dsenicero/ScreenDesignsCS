
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
            this.mnuAccountsItemAddAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccountsItemAccountsList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccountsItemEditAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccountsItemDeleteAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(698, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 50);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFill
            // 
            this.lblFill.BackColor = System.Drawing.Color.White;
            this.lblFill.Location = new System.Drawing.Point(-1, 0);
            this.lblFill.Margin = new System.Windows.Forms.Padding(0);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(103, 50);
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
            this.mnuAccounts.BackColor = System.Drawing.SystemColors.Control;
            this.mnuAccounts.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAccounts.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAccountsItemAddAccounts,
            this.mnuAccountsItemAccountsList,
            this.mnuAccountsItemEditAccounts,
            this.mnuAccountsItemDeleteAccounts});
            this.mnuAccounts.Location = new System.Drawing.Point(102, 0);
            this.mnuAccounts.Name = "mnuAccounts";
            this.mnuAccounts.Padding = new System.Windows.Forms.Padding(0);
            this.mnuAccounts.Size = new System.Drawing.Size(596, 50);
            this.mnuAccounts.TabIndex = 9;
            this.mnuAccounts.Text = "menuStrip1";
            // 
            // mnuAccountsItemAddAccounts
            // 
            this.mnuAccountsItemAddAccounts.Name = "mnuAccountsItemAddAccounts";
            this.mnuAccountsItemAddAccounts.Padding = new System.Windows.Forms.Padding(14, 0, 4, 0);
            this.mnuAccountsItemAddAccounts.Size = new System.Drawing.Size(153, 50);
            this.mnuAccountsItemAddAccounts.Text = "&Add Accounts";
            this.mnuAccountsItemAddAccounts.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuAccountsItemAddAccounts.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuAccountsItemAccountsList
            // 
            this.mnuAccountsItemAccountsList.Name = "mnuAccountsItemAccountsList";
            this.mnuAccountsItemAccountsList.Size = new System.Drawing.Size(137, 50);
            this.mnuAccountsItemAccountsList.Text = "&Accounts List";
            this.mnuAccountsItemAccountsList.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuAccountsItemAccountsList.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuAccountsItemEditAccounts
            // 
            this.mnuAccountsItemEditAccounts.Name = "mnuAccountsItemEditAccounts";
            this.mnuAccountsItemEditAccounts.Size = new System.Drawing.Size(141, 50);
            this.mnuAccountsItemEditAccounts.Text = "&Edit Accounts";
            this.mnuAccountsItemEditAccounts.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuAccountsItemEditAccounts.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuAccountsItemDeleteAccounts
            // 
            this.mnuAccountsItemDeleteAccounts.Name = "mnuAccountsItemDeleteAccounts";
            this.mnuAccountsItemDeleteAccounts.Size = new System.Drawing.Size(164, 50);
            this.mnuAccountsItemDeleteAccounts.Text = "&Delete Accounts";
            this.mnuAccountsItemDeleteAccounts.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuAccountsItemDeleteAccounts.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // frmAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.ToolStripMenuItem mnuAccountsItemAddAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnuAccountsItemAccountsList;
        private System.Windows.Forms.ToolStripMenuItem mnuAccountsItemEditAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnuAccountsItemDeleteAccounts;
    }
}