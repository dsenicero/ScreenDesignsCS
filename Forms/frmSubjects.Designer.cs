
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
            this.mnuSubjectsItemAddSubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubjectsItemSubjectsList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubjectsEditSubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubjectsItemDeleteSubjects = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuSubjectsItemAddSubjects,
            this.mnuSubjectsItemSubjectsList,
            this.mnuSubjectsEditSubjects,
            this.mnuSubjectsItemDeleteSubjects});
            this.mnuSubjects.Location = new System.Drawing.Point(119, 0);
            this.mnuSubjects.Name = "mnuSubjects";
            this.mnuSubjects.Padding = new System.Windows.Forms.Padding(0);
            this.mnuSubjects.Size = new System.Drawing.Size(563, 50);
            this.mnuSubjects.TabIndex = 9;
            this.mnuSubjects.Text = "menuStrip1";
            // 
            // mnuSubjectsItemAddSubjects
            // 
            this.mnuSubjectsItemAddSubjects.Name = "mnuSubjectsItemAddSubjects";
            this.mnuSubjectsItemAddSubjects.Padding = new System.Windows.Forms.Padding(14, 0, 4, 0);
            this.mnuSubjectsItemAddSubjects.Size = new System.Drawing.Size(145, 50);
            this.mnuSubjectsItemAddSubjects.Text = "&Add Subjects";
            this.mnuSubjectsItemAddSubjects.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuSubjectsItemAddSubjects.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuSubjectsItemSubjectsList
            // 
            this.mnuSubjectsItemSubjectsList.Name = "mnuSubjectsItemSubjectsList";
            this.mnuSubjectsItemSubjectsList.Size = new System.Drawing.Size(129, 50);
            this.mnuSubjectsItemSubjectsList.Text = "&Subjects List";
            this.mnuSubjectsItemSubjectsList.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuSubjectsItemSubjectsList.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuSubjectsEditSubjects
            // 
            this.mnuSubjectsEditSubjects.Name = "mnuSubjectsEditSubjects";
            this.mnuSubjectsEditSubjects.Size = new System.Drawing.Size(133, 50);
            this.mnuSubjectsEditSubjects.Text = "&Edit Subjects";
            this.mnuSubjectsEditSubjects.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuSubjectsEditSubjects.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // mnuSubjectsItemDeleteSubjects
            // 
            this.mnuSubjectsItemDeleteSubjects.Name = "mnuSubjectsItemDeleteSubjects";
            this.mnuSubjectsItemDeleteSubjects.Size = new System.Drawing.Size(156, 50);
            this.mnuSubjectsItemDeleteSubjects.Text = "&Delete Subjects";
            this.mnuSubjectsItemDeleteSubjects.MouseEnter += new System.EventHandler(this.myToolStripMenuItem_MouseEnter);
            this.mnuSubjectsItemDeleteSubjects.MouseLeave += new System.EventHandler(this.myToolStripMenuItem_MouseLeave);
            // 
            // frmSubjects
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.ToolStripMenuItem mnuSubjectsItemAddSubjects;
        private System.Windows.Forms.ToolStripMenuItem mnuSubjectsItemSubjectsList;
        private System.Windows.Forms.ToolStripMenuItem mnuSubjectsEditSubjects;
        private System.Windows.Forms.ToolStripMenuItem mnuSubjectsItemDeleteSubjects;
    }
}