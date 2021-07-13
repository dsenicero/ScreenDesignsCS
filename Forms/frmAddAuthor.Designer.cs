
namespace SeniceroDAngelo_ScreenDesign.Forms
{
    partial class frmAddAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAuthor));
            this.pnlForms = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxYearBorn = new System.Windows.Forms.TextBox();
            this.lblYearBorn = new System.Windows.Forms.Label();
            this.tbxAuthorID = new System.Windows.Forms.TextBox();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.pnlForms.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.White;
            this.pnlForms.Controls.Add(this.btnCancel);
            this.pnlForms.Controls.Add(this.btnClear);
            this.pnlForms.Controls.Add(this.btnAdd);
            this.pnlForms.Controls.Add(this.tbxYearBorn);
            this.pnlForms.Controls.Add(this.lblYearBorn);
            this.pnlForms.Controls.Add(this.tbxAuthorID);
            this.pnlForms.Controls.Add(this.lblAuthorID);
            this.pnlForms.Controls.Add(this.tbxFirstName);
            this.pnlForms.Controls.Add(this.tbxMiddleName);
            this.pnlForms.Controls.Add(this.tbxLastName);
            this.pnlForms.Controls.Add(this.lblMiddleName);
            this.pnlForms.Controls.Add(this.lblFirstName);
            this.pnlForms.Controls.Add(this.lblLastName);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlForms.ForeColor = System.Drawing.Color.Black;
            this.pnlForms.Location = new System.Drawing.Point(0, 154);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(476, 290);
            this.pnlForms.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbxYearBorn
            // 
            this.tbxYearBorn.Location = new System.Drawing.Point(212, 178);
            this.tbxYearBorn.Name = "tbxYearBorn";
            this.tbxYearBorn.Size = new System.Drawing.Size(125, 29);
            this.tbxYearBorn.TabIndex = 9;
            // 
            // lblYearBorn
            // 
            this.lblYearBorn.AutoSize = true;
            this.lblYearBorn.Location = new System.Drawing.Point(27, 180);
            this.lblYearBorn.Name = "lblYearBorn";
            this.lblYearBorn.Size = new System.Drawing.Size(94, 24);
            this.lblYearBorn.TabIndex = 8;
            this.lblYearBorn.Text = "Year Born";
            // 
            // tbxAuthorID
            // 
            this.tbxAuthorID.Location = new System.Drawing.Point(212, 30);
            this.tbxAuthorID.Name = "tbxAuthorID";
            this.tbxAuthorID.Size = new System.Drawing.Size(237, 29);
            this.tbxAuthorID.TabIndex = 1;
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(27, 32);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(88, 24);
            this.lblAuthorID.TabIndex = 0;
            this.lblAuthorID.Text = "Author ID";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(212, 141);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(237, 29);
            this.tbxFirstName.TabIndex = 7;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(212, 104);
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(237, 29);
            this.tbxMiddleName.TabIndex = 5;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(212, 67);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(237, 29);
            this.tbxLastName.TabIndex = 3;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(27, 106);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(123, 24);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(27, 143);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 24);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(27, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 24);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.White;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 125);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(476, 29);
            this.mnuMain.TabIndex = 4;
            this.mnuMain.Text = "mnuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.printToolStripMenuItem.Text = "&Exit";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Teal;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.lblMenuName);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(476, 125);
            this.pnlTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Author";
            // 
            // lblMenuName
            // 
            this.lblMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.ForeColor = System.Drawing.Color.White;
            this.lblMenuName.Location = new System.Drawing.Point(30, 12);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(415, 37);
            this.lblMenuName.TabIndex = 0;
            this.lblMenuName.Text = " Admin D\'Angelo Senicero";
            // 
            // frmAddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 444);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Library Program - Add Author";
            this.pnlForms.ResumeLayout(false);
            this.pnlForms.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxYearBorn;
        private System.Windows.Forms.Label lblYearBorn;
        private System.Windows.Forms.TextBox tbxAuthorID;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMenuName;
    }
}