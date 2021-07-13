using System;
using System.Windows.Forms;

namespace SeniceroDAngelo_ScreenDesign.Forms
{
    public partial class frmAddAccount:Form
    {
        public frmAddAccount()
        {
            this.InitializeComponent();
        }

        private void pnlForms_Paint(object sender,PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
