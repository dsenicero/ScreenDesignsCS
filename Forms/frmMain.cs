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
            this.InitializeComponent();
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
            frmAddAccount addAccounts = new frmAddAccount();
            addAccounts.ShowDialog();
        }

        private void mnuMainItemFileItemExit_Click(object sender,EventArgs e)
        {
            Application.Exit();
        }
    }
}
