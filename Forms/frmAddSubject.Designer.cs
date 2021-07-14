
namespace SeniceroDAngelo_ScreenDesign.Forms
{
    partial class frmAddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSubject));
            this.pnlForms = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.cbxComboBoxGeneralCategory = new System.Windows.Forms.ComboBox();
            this.tbxSpecificCategory = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbxComments = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblDecimalID = new System.Windows.Forms.Label();
            this.tbxGeneralCategory = new System.Windows.Forms.Label();
            this.pnlForms.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.White;
            this.pnlForms.Controls.Add(this.cbxComboBoxGeneralCategory);
            this.pnlForms.Controls.Add(this.tbxSpecificCategory);
            this.pnlForms.Controls.Add(this.lblConfirmPassword);
            this.pnlForms.Controls.Add(this.tbxComments);
            this.pnlForms.Controls.Add(this.tbxPassword);
            this.pnlForms.Controls.Add(this.lblComments);
            this.pnlForms.Controls.Add(this.lblDecimalID);
            this.pnlForms.Controls.Add(this.tbxGeneralCategory);
            this.pnlForms.Controls.Add(this.btnCancel);
            this.pnlForms.Controls.Add(this.btnClear);
            this.pnlForms.Controls.Add(this.btnAdd);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlForms.ForeColor = System.Drawing.Color.Black;
            this.pnlForms.Location = new System.Drawing.Point(0, 154);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(508, 232);
            this.pnlForms.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(204, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.White;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 125);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(508, 29);
            this.mnuMain.TabIndex = 1;
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
            this.pnlTitle.Size = new System.Drawing.Size(508, 125);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Subject";
            // 
            // lblMenuName
            // 
            this.lblMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.ForeColor = System.Drawing.Color.White;
            this.lblMenuName.Location = new System.Drawing.Point(46, 12);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(415, 37);
            this.lblMenuName.TabIndex = 0;
            this.lblMenuName.Text = " Admin D\'Angelo Senicero";
            // 
            // cbxComboBoxGeneralCategory
            // 
            this.cbxComboBoxGeneralCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComboBoxGeneralCategory.FormattingEnabled = true;
            this.cbxComboBoxGeneralCategory.Location = new System.Drawing.Point(225, 96);
            this.cbxComboBoxGeneralCategory.Name = "cbxComboBoxGeneralCategory";
            this.cbxComboBoxGeneralCategory.Size = new System.Drawing.Size(237, 32);
            this.cbxComboBoxGeneralCategory.TabIndex = 5;
            // 
            // tbxSpecificCategory
            // 
            this.tbxSpecificCategory.Location = new System.Drawing.Point(225, 59);
            this.tbxSpecificCategory.Name = "tbxSpecificCategory";
            this.tbxSpecificCategory.PasswordChar = '*';
            this.tbxSpecificCategory.Size = new System.Drawing.Size(237, 29);
            this.tbxSpecificCategory.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(40, 63);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(85, 24);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Category";
            // 
            // tbxComments
            // 
            this.tbxComments.Location = new System.Drawing.Point(225, 136);
            this.tbxComments.Name = "tbxComments";
            this.tbxComments.Size = new System.Drawing.Size(237, 29);
            this.tbxComments.TabIndex = 7;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(225, 22);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(237, 29);
            this.tbxPassword.TabIndex = 1;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(40, 138);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(146, 24);
            this.lblComments.TabIndex = 6;
            this.lblComments.Text = "Security Answer";
            // 
            // lblDecimalID
            // 
            this.lblDecimalID.AutoSize = true;
            this.lblDecimalID.Location = new System.Drawing.Point(40, 24);
            this.lblDecimalID.Name = "lblDecimalID";
            this.lblDecimalID.Size = new System.Drawing.Size(100, 24);
            this.lblDecimalID.TabIndex = 0;
            this.lblDecimalID.Text = "Decimal ID";
            // 
            // tbxGeneralCategory
            // 
            this.tbxGeneralCategory.AutoSize = true;
            this.tbxGeneralCategory.Location = new System.Drawing.Point(40, 101);
            this.tbxGeneralCategory.Name = "tbxGeneralCategory";
            this.tbxGeneralCategory.Size = new System.Drawing.Size(158, 24);
            this.tbxGeneralCategory.TabIndex = 4;
            this.tbxGeneralCategory.Text = "Security Question";
            // 
            // frmAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 386);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Library Program - Add Subject";
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
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.ComboBox cbxComboBoxGeneralCategory;
        private System.Windows.Forms.TextBox tbxSpecificCategory;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbxComments;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblDecimalID;
        private System.Windows.Forms.Label tbxGeneralCategory;
    }
}