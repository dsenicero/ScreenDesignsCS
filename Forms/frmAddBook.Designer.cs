
namespace SeniceroDAngelo_ScreenDesign.Forms
{
    partial class frmAddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBook));
            this.pnlForms = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbxSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbxAccountID = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.tbxSecurityAnswer = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxUserID = new System.Windows.Forms.TextBox();
            this.lblSecurityPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.mskISBN = new System.Windows.Forms.MaskedTextBox();
            this.pnlForms.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.White;
            this.pnlForms.Controls.Add(this.mskISBN);
            this.pnlForms.Controls.Add(this.lblISBN);
            this.pnlForms.Controls.Add(this.btnCancel);
            this.pnlForms.Controls.Add(this.btnClear);
            this.pnlForms.Controls.Add(this.btnAdd);
            this.pnlForms.Controls.Add(this.checkBox1);
            this.pnlForms.Controls.Add(this.cbxSecurityQuestion);
            this.pnlForms.Controls.Add(this.tbxConfirmPassword);
            this.pnlForms.Controls.Add(this.lblConfirmPassword);
            this.pnlForms.Controls.Add(this.tbxAccountID);
            this.pnlForms.Controls.Add(this.lblAccountID);
            this.pnlForms.Controls.Add(this.tbxSecurityAnswer);
            this.pnlForms.Controls.Add(this.tbxPassword);
            this.pnlForms.Controls.Add(this.tbxUsername);
            this.pnlForms.Controls.Add(this.tbxUserID);
            this.pnlForms.Controls.Add(this.lblSecurityPassword);
            this.pnlForms.Controls.Add(this.lblUsername);
            this.pnlForms.Controls.Add(this.lblPassword);
            this.pnlForms.Controls.Add(this.lblSecurityQuestion);
            this.pnlForms.Controls.Add(this.lblUserID);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlForms.ForeColor = System.Drawing.Color.Black;
            this.pnlForms.Location = new System.Drawing.Point(0, 154);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(665, 396);
            this.pnlForms.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(190, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(29, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(210, 28);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Administrator";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbxSecurityQuestion
            // 
            this.cbxSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSecurityQuestion.FormattingEnabled = true;
            this.cbxSecurityQuestion.Location = new System.Drawing.Point(214, 210);
            this.cbxSecurityQuestion.Name = "cbxSecurityQuestion";
            this.cbxSecurityQuestion.Size = new System.Drawing.Size(237, 32);
            this.cbxSecurityQuestion.TabIndex = 14;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(214, 173);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(237, 29);
            this.tbxConfirmPassword.TabIndex = 13;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(29, 175);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(162, 24);
            this.lblConfirmPassword.TabIndex = 12;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // tbxAccountID
            // 
            this.tbxAccountID.Location = new System.Drawing.Point(214, 25);
            this.tbxAccountID.Name = "tbxAccountID";
            this.tbxAccountID.Size = new System.Drawing.Size(383, 29);
            this.tbxAccountID.TabIndex = 11;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(29, 27);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(102, 24);
            this.lblAccountID.TabIndex = 10;
            this.lblAccountID.Text = "Account ID";
            // 
            // tbxSecurityAnswer
            // 
            this.tbxSecurityAnswer.Location = new System.Drawing.Point(214, 250);
            this.tbxSecurityAnswer.Name = "tbxSecurityAnswer";
            this.tbxSecurityAnswer.Size = new System.Drawing.Size(237, 29);
            this.tbxSecurityAnswer.TabIndex = 8;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(214, 136);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(237, 29);
            this.tbxPassword.TabIndex = 7;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(214, 99);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(237, 29);
            this.tbxUsername.TabIndex = 6;
            // 
            // tbxUserID
            // 
            this.tbxUserID.Location = new System.Drawing.Point(214, 62);
            this.tbxUserID.Name = "tbxUserID";
            this.tbxUserID.Size = new System.Drawing.Size(108, 29);
            this.tbxUserID.TabIndex = 5;
            // 
            // lblSecurityPassword
            // 
            this.lblSecurityPassword.AutoSize = true;
            this.lblSecurityPassword.Location = new System.Drawing.Point(29, 252);
            this.lblSecurityPassword.Name = "lblSecurityPassword";
            this.lblSecurityPassword.Size = new System.Drawing.Size(146, 24);
            this.lblSecurityPassword.TabIndex = 4;
            this.lblSecurityPassword.Text = "Security Answer";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(29, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(29, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(29, 214);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(158, 24);
            this.lblSecurityQuestion.TabIndex = 1;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(29, 64);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(138, 24);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "Year Published";
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.White;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 125);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(665, 29);
            this.mnuMain.TabIndex = 12;
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
            this.pnlTitle.Size = new System.Drawing.Size(665, 125);
            this.pnlTitle.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenuName
            // 
            this.lblMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.ForeColor = System.Drawing.Color.White;
            this.lblMenuName.Location = new System.Drawing.Point(124, 12);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(415, 37);
            this.lblMenuName.TabIndex = 4;
            this.lblMenuName.Text = " Admin D\'Angelo Senicero";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(336, 64);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(52, 24);
            this.lblISBN.TabIndex = 20;
            this.lblISBN.Text = "ISBN";
            // 
            // mskISBN
            // 
            this.mskISBN.Location = new System.Drawing.Point(394, 64);
            this.mskISBN.Name = "mskISBN";
            this.mskISBN.Size = new System.Drawing.Size(203, 29);
            this.mskISBN.TabIndex = 21;
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 550);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Library Program - Add Book";
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbxSecurityQuestion;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbxAccountID;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.TextBox tbxSecurityAnswer;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxUserID;
        private System.Windows.Forms.Label lblSecurityPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.MaskedTextBox mskISBN;
    }
}