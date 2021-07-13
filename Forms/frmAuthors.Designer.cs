﻿
namespace SeniceroDAngelo_ScreenDesign.Forms
{
    partial class frmAuthors
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
            this.lblFill2 = new System.Windows.Forms.Label();
            this.mnuAuthors = new System.Windows.Forms.MenuStrip();
            this.mnuAuthorsItemAddAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthorsItemAuthorsList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthorsItemEditAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthorsItemDeleteAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(676, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 50);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFill
            // 
            this.lblFill.BackColor = System.Drawing.Color.White;
            this.lblFill.Location = new System.Drawing.Point(0, 0);
            this.lblFill.Margin = new System.Windows.Forms.Padding(0);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(125, 50);
            this.lblFill.TabIndex = 4;
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
            this.mnuMainBooks.Location = new System.Drawing.Point(125, 0);
            this.mnuMainBooks.Name = "mnuMainBooks";
            this.mnuMainBooks.Padding = new System.Windows.Forms.Padding(0);
            this.mnuMainBooks.Size = new System.Drawing.Size(551, 50);
            this.mnuMainBooks.TabIndex = 3;
            this.mnuMainBooks.Text = "mnuMainBooks";
            // 
            // lblFill2
            // 
            this.lblFill2.BackColor = System.Drawing.Color.White;
            this.lblFill2.Location = new System.Drawing.Point(0, 0);
            this.lblFill2.Margin = new System.Windows.Forms.Padding(0);
            this.lblFill2.Name = "lblFill2";
            this.lblFill2.Size = new System.Drawing.Size(125, 50);
            this.lblFill2.TabIndex = 4;
            this.lblFill2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuAuthors
            // 
            this.mnuAuthors.AllowMerge = false;
            this.mnuAuthors.AutoSize = false;
            this.mnuAuthors.BackColor = System.Drawing.SystemColors.Control;
            this.mnuAuthors.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuAuthors.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAuthors.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnuAuthors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAuthorsItemAddAuthors,
            this.mnuAuthorsItemAuthorsList,
            this.mnuAuthorsItemEditAuthors,
            this.mnuAuthorsItemDeleteAuthors});
            this.mnuAuthors.Location = new System.Drawing.Point(125, 0);
            this.mnuAuthors.Name = "mnuAuthors";
            this.mnuAuthors.Padding = new System.Windows.Forms.Padding(0);
            this.mnuAuthors.Size = new System.Drawing.Size(551, 50);
            this.mnuAuthors.TabIndex = 6;
            this.mnuAuthors.Text = "menuStrip1";
            // 
            // mnuAuthorsItemAddAuthors
            // 
            this.mnuAuthorsItemAddAuthors.Name = "mnuAuthorsItemAddAuthors";
            this.mnuAuthorsItemAddAuthors.Padding = new System.Windows.Forms.Padding(14, 0, 4, 0);
            this.mnuAuthorsItemAddAuthors.Size = new System.Drawing.Size(142, 50);
            this.mnuAuthorsItemAddAuthors.Text = "&Add Authors";
            this.mnuAuthorsItemAddAuthors.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuAuthorsItemAddAuthors.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuAuthorsItemAuthorsList
            // 
            this.mnuAuthorsItemAuthorsList.Name = "mnuAuthorsItemAuthorsList";
            this.mnuAuthorsItemAuthorsList.Size = new System.Drawing.Size(126, 50);
            this.mnuAuthorsItemAuthorsList.Text = "&Authors List";
            this.mnuAuthorsItemAuthorsList.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuAuthorsItemAuthorsList.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuAuthorsItemEditAuthors
            // 
            this.mnuAuthorsItemEditAuthors.Name = "mnuAuthorsItemEditAuthors";
            this.mnuAuthorsItemEditAuthors.Size = new System.Drawing.Size(130, 50);
            this.mnuAuthorsItemEditAuthors.Text = "&Edit Authors";
            this.mnuAuthorsItemEditAuthors.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuAuthorsItemEditAuthors.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuAuthorsItemDeleteAuthors
            // 
            this.mnuAuthorsItemDeleteAuthors.Name = "mnuAuthorsItemDeleteAuthors";
            this.mnuAuthorsItemDeleteAuthors.Size = new System.Drawing.Size(153, 50);
            this.mnuAuthorsItemDeleteAuthors.Text = "&Delete Authors";
            this.mnuAuthorsItemDeleteAuthors.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuAuthorsItemDeleteAuthors.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // frmAuthors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.mnuAuthors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFill);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.mnuAuthors.ResumeLayout(false);
            this.mnuAuthors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.MenuStrip mnuMainBooks;
        private System.Windows.Forms.Label lblFill2;
        private System.Windows.Forms.MenuStrip mnuAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthorsItemAddAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthorsItemAuthorsList;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthorsItemEditAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthorsItemDeleteAuthors;
    }
}