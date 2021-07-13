
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.tbxISBN = new System.Windows.Forms.MaskedTextBox();
            this.btnXAuthor2 = new System.Windows.Forms.Button();
            this.btnXAuthor1 = new System.Windows.Forms.Button();
            this.cbxAuthor2 = new System.Windows.Forms.ComboBox();
            this.lblAuthor2 = new System.Windows.Forms.Label();
            this.cbxAuthor1 = new System.Windows.Forms.ComboBox();
            this.lblAuthor1 = new System.Windows.Forms.Label();
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblPublishedDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.lblYearPub = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.cbxComboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbxReplacementPrice = new System.Windows.Forms.TextBox();
            this.lblReplacementPrice = new System.Windows.Forms.Label();
            this.pnlForms.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.White;
            this.pnlForms.Controls.Add(this.lblReplacementPrice);
            this.pnlForms.Controls.Add(this.textBox1);
            this.pnlForms.Controls.Add(this.lblComments);
            this.pnlForms.Controls.Add(this.cbxComboBoxLanguage);
            this.pnlForms.Controls.Add(this.cbxComboBoxCategory);
            this.pnlForms.Controls.Add(this.tbxISBN);
            this.pnlForms.Controls.Add(this.btnXAuthor2);
            this.pnlForms.Controls.Add(this.btnXAuthor1);
            this.pnlForms.Controls.Add(this.cbxAuthor2);
            this.pnlForms.Controls.Add(this.lblAuthor2);
            this.pnlForms.Controls.Add(this.cbxAuthor1);
            this.pnlForms.Controls.Add(this.lblAuthor1);
            this.pnlForms.Controls.Add(this.cbxPublisher);
            this.pnlForms.Controls.Add(this.lblPublisher);
            this.pnlForms.Controls.Add(this.tbxReplacementPrice);
            this.pnlForms.Controls.Add(this.lblLanguage);
            this.pnlForms.Controls.Add(this.lblPublishedDate);
            this.pnlForms.Controls.Add(this.lblCategory);
            this.pnlForms.Controls.Add(this.tbxDescription);
            this.pnlForms.Controls.Add(this.lblSummary);
            this.pnlForms.Controls.Add(this.lblISBN);
            this.pnlForms.Controls.Add(this.tbxYear);
            this.pnlForms.Controls.Add(this.lblYearPub);
            this.pnlForms.Controls.Add(this.tbxTitle);
            this.pnlForms.Controls.Add(this.lblTitle);
            this.pnlForms.Controls.Add(this.btnCancel);
            this.pnlForms.Controls.Add(this.btnClear);
            this.pnlForms.Controls.Add(this.btnAdd);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlForms.ForeColor = System.Drawing.Color.Black;
            this.pnlForms.Location = new System.Drawing.Point(0, 154);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(665, 449);
            this.pnlForms.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 17;
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
            this.mnuMain.Size = new System.Drawing.Size(665, 29);
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
            this.pnlTitle.Size = new System.Drawing.Size(665, 125);
            this.pnlTitle.TabIndex = 0;
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
            this.label1.TabIndex = 1;
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
            this.lblMenuName.TabIndex = 0;
            this.lblMenuName.Text = " Admin D\'Angelo Senicero";
            // 
            // tbxISBN
            // 
            this.tbxISBN.Location = new System.Drawing.Point(433, 63);
            this.tbxISBN.Mask = ">A-AAAAAAA-A-A";
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(200, 29);
            this.tbxISBN.TabIndex = 5;
            // 
            // btnXAuthor2
            // 
            this.btnXAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor2.Location = new System.Drawing.Point(612, 98);
            this.btnXAuthor2.Name = "btnXAuthor2";
            this.btnXAuthor2.Size = new System.Drawing.Size(21, 32);
            this.btnXAuthor2.TabIndex = 114;
            this.btnXAuthor2.TabStop = false;
            this.btnXAuthor2.Text = "X";
            this.btnXAuthor2.UseVisualStyleBackColor = true;
            // 
            // btnXAuthor1
            // 
            this.btnXAuthor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor1.Location = new System.Drawing.Point(346, 98);
            this.btnXAuthor1.Name = "btnXAuthor1";
            this.btnXAuthor1.Size = new System.Drawing.Size(21, 32);
            this.btnXAuthor1.TabIndex = 113;
            this.btnXAuthor1.TabStop = false;
            this.btnXAuthor1.Text = "X";
            this.btnXAuthor1.UseVisualStyleBackColor = true;
            // 
            // cbxAuthor2
            // 
            this.cbxAuthor2.BackColor = System.Drawing.Color.White;
            this.cbxAuthor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuthor2.FormattingEnabled = true;
            this.cbxAuthor2.Location = new System.Drawing.Point(433, 98);
            this.cbxAuthor2.Name = "cbxAuthor2";
            this.cbxAuthor2.Size = new System.Drawing.Size(173, 32);
            this.cbxAuthor2.TabIndex = 96;
            // 
            // lblAuthor2
            // 
            this.lblAuthor2.AutoSize = true;
            this.lblAuthor2.Location = new System.Drawing.Point(346, 102);
            this.lblAuthor2.Name = "lblAuthor2";
            this.lblAuthor2.Size = new System.Drawing.Size(81, 24);
            this.lblAuthor2.TabIndex = 110;
            this.lblAuthor2.Text = "Author 2";
            // 
            // cbxAuthor1
            // 
            this.cbxAuthor1.BackColor = System.Drawing.Color.White;
            this.cbxAuthor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuthor1.FormattingEnabled = true;
            this.cbxAuthor1.Items.AddRange(new object[] {
            "Darth Vader",
            "Jon Stark",
            "String Collection"});
            this.cbxAuthor1.Location = new System.Drawing.Point(205, 98);
            this.cbxAuthor1.Name = "cbxAuthor1";
            this.cbxAuthor1.Size = new System.Drawing.Size(135, 32);
            this.cbxAuthor1.TabIndex = 94;
            // 
            // lblAuthor1
            // 
            this.lblAuthor1.AutoSize = true;
            this.lblAuthor1.Location = new System.Drawing.Point(33, 101);
            this.lblAuthor1.Name = "lblAuthor1";
            this.lblAuthor1.Size = new System.Drawing.Size(81, 24);
            this.lblAuthor1.TabIndex = 109;
            this.lblAuthor1.Text = "Author 1";
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.BackColor = System.Drawing.Color.White;
            this.cbxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(205, 136);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(353, 32);
            this.cbxPublisher.TabIndex = 99;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(33, 140);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(89, 24);
            this.lblPublisher.TabIndex = 108;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(33, 245);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(101, 24);
            this.lblLanguage.TabIndex = 107;
            this.lblLanguage.Text = "Comments";
            // 
            // lblPublishedDate
            // 
            this.lblPublishedDate.AutoSize = true;
            this.lblPublishedDate.Location = new System.Drawing.Point(33, 219);
            this.lblPublishedDate.Name = "lblPublishedDate";
            this.lblPublishedDate.Size = new System.Drawing.Size(137, 24);
            this.lblPublishedDate.TabIndex = 106;
            this.lblPublishedDate.Text = "Published Date";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(33, 193);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 24);
            this.lblCategory.TabIndex = 105;
            this.lblCategory.Text = "Category";
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.Color.White;
            this.tbxDescription.Location = new System.Drawing.Point(205, 174);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(353, 29);
            this.tbxDescription.TabIndex = 100;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(33, 167);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(90, 24);
            this.lblSummary.TabIndex = 104;
            this.lblSummary.Text = "Summary";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(375, 65);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(52, 24);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN";
            // 
            // tbxYear
            // 
            this.tbxYear.BackColor = System.Drawing.Color.White;
            this.tbxYear.Location = new System.Drawing.Point(205, 65);
            this.tbxYear.MaxLength = 4;
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.ReadOnly = true;
            this.tbxYear.Size = new System.Drawing.Size(105, 29);
            this.tbxYear.TabIndex = 3;
            // 
            // lblYearPub
            // 
            this.lblYearPub.AutoSize = true;
            this.lblYearPub.Location = new System.Drawing.Point(33, 68);
            this.lblYearPub.Name = "lblYearPub";
            this.lblYearPub.Size = new System.Drawing.Size(138, 24);
            this.lblYearPub.TabIndex = 2;
            this.lblYearPub.Text = "Year Published";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BackColor = System.Drawing.Color.White;
            this.tbxTitle.Location = new System.Drawing.Point(205, 28);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.ReadOnly = true;
            this.tbxTitle.Size = new System.Drawing.Size(353, 29);
            this.tbxTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(33, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // cbxComboBoxCategory
            // 
            this.cbxComboBoxCategory.BackColor = System.Drawing.Color.White;
            this.cbxComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComboBoxCategory.FormattingEnabled = true;
            this.cbxComboBoxCategory.Location = new System.Drawing.Point(205, 209);
            this.cbxComboBoxCategory.Name = "cbxComboBoxCategory";
            this.cbxComboBoxCategory.Size = new System.Drawing.Size(353, 32);
            this.cbxComboBoxCategory.TabIndex = 115;
            // 
            // cbxComboBoxLanguage
            // 
            this.cbxComboBoxLanguage.BackColor = System.Drawing.Color.White;
            this.cbxComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComboBoxLanguage.FormattingEnabled = true;
            this.cbxComboBoxLanguage.Location = new System.Drawing.Point(205, 249);
            this.cbxComboBoxLanguage.Name = "cbxComboBoxLanguage";
            this.cbxComboBoxLanguage.Size = new System.Drawing.Size(127, 32);
            this.cbxComboBoxLanguage.TabIndex = 116;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(33, 301);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(101, 24);
            this.lblComments.TabIndex = 117;
            this.lblComments.Text = "Comments";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(205, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(353, 29);
            this.textBox1.TabIndex = 118;
            // 
            // tbxReplacementPrice
            // 
            this.tbxReplacementPrice.BackColor = System.Drawing.Color.White;
            this.tbxReplacementPrice.Location = new System.Drawing.Point(550, 249);
            this.tbxReplacementPrice.Name = "tbxReplacementPrice";
            this.tbxReplacementPrice.ReadOnly = true;
            this.tbxReplacementPrice.Size = new System.Drawing.Size(82, 29);
            this.tbxReplacementPrice.TabIndex = 103;
            // 
            // lblReplacementPrice
            // 
            this.lblReplacementPrice.AutoSize = true;
            this.lblReplacementPrice.Location = new System.Drawing.Point(375, 252);
            this.lblReplacementPrice.Name = "lblReplacementPrice";
            this.lblReplacementPrice.Size = new System.Drawing.Size(170, 24);
            this.lblReplacementPrice.TabIndex = 119;
            this.lblReplacementPrice.Text = "Replacement Price";
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 603);
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
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.MaskedTextBox tbxISBN;
        private System.Windows.Forms.Button btnXAuthor2;
        private System.Windows.Forms.Button btnXAuthor1;
        private System.Windows.Forms.ComboBox cbxAuthor2;
        private System.Windows.Forms.Label lblAuthor2;
        private System.Windows.Forms.ComboBox cbxAuthor1;
        private System.Windows.Forms.Label lblAuthor1;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblPublishedDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Label lblYearPub;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxComboBoxCategory;
        private System.Windows.Forms.ComboBox cbxComboBoxLanguage;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbxReplacementPrice;
        private System.Windows.Forms.Label lblReplacementPrice;
    }
}