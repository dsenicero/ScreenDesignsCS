using System;
using System.Windows.Forms;

using SeniceroDAngelo_ScreenDesign.Forms;

namespace SeniceroDAngelo_ScreenDesign
{
    public partial class frmMain:Form
    {

        public const string TITLE = "My Library Program";

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender,EventArgs e)
        {

        }

        private void mnuMainItemPrintItemAccounts_Click(object sender,EventArgs e)
        {
            frmPrintReports reports = new frmPrintReports();
            reports.ShowDialog();
        }

        private void mnuMainItemPrintItemAuthors_Click(object sender,EventArgs e)
        {
            frmPrintReports reports = new frmPrintReports();
            reports.ShowDialog();
        }

        private void mnuMainItemPrintItemBooks_Click(object sender,EventArgs e)
        {
            frmPrintReports reports = new frmPrintReports();
            reports.ShowDialog();
        }

        private void mnuMainItemPrintItemPublishers_Click(object sender,EventArgs e)
        {
            frmPrintReports reports = new frmPrintReports();
            reports.ShowDialog();
        }

        private void mnuMainItemPrintItemRentals_Click(object sender,EventArgs e)
        {
            frmPrintReports reports = new frmPrintReports();
            reports.ShowDialog();
        }

        private void mnuMainItemPrintItemSubjects_Click(object sender,EventArgs e)
        {
            frmPrintReports reports = new frmPrintReports();
            reports.ShowDialog();
        }

        private void mnuMainItemPrintItemUsers_Click(object sender,EventArgs e)
        {
            frmPrintReports reports = new frmPrintReports();
            reports.ShowDialog();
        }

        private void mnuMainItemAccountsItemAddAccount_Click(object sender,EventArgs e)
        {
            frmAddAccount addAccount = new frmAddAccount();
            addAccount.ShowDialog();
        }

        private void mnuMainItemFileItemExit_Click(object sender,EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMainItemPublishersAddPublisher_Click(object sender,EventArgs e)
        {
            frmAddPublisher addPublisher = new frmAddPublisher();
            addPublisher.ShowDialog();
        }

        private void mnuMainItemAuthorsItemAddAuthors_Click(object sender,EventArgs e)
        {
            frmAddAuthor addAuthor = new frmAddAuthor();
            addAuthor.ShowDialog();
        }

        private void mnuMainItemUsersItemAddUser_Click(object sender,EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.ShowDialog();
        }

        private void mnuMainItemBooksItemAddBook_Click(object sender,EventArgs e)
        {
            frmAddBook addBook = new frmAddBook();
            addBook.ShowDialog();
        }

        private void mnuMainItemSubjectsItemAddSubject_Click(object sender,EventArgs e)
        {
            frmAddSubject addSubject = new frmAddSubject();
            addSubject.Show();
        }
    }
}
