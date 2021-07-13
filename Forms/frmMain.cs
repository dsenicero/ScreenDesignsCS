using System;
using System.Drawing;
using System.Windows.Forms;

using SeniceroDAngelo_ScreenDesign.Forms;

namespace SeniceroDAngelo_ScreenDesign
{
    public partial class frmMain:Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private frmDashboard dashboard = new frmDashboard();
        private frmSubjects subjects = new frmSubjects();
        private frmAuthors authors = new frmAuthors();
        private frmBooks books = new frmBooks();
        private frmRentals rentals = new frmRentals();
        private frmAccounts accounts = new frmAccounts();

        public const string TITLE = "My Library Program";

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    pnlTitle.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    currentButton.Enabled = false;
                }
            }

        }

        private void DisableButton()
        {
            foreach(Control previousBtn in pnlMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Enabled = true;
                    previousBtn.BackColor = Color.FromArgb(0,128,128);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
                Reset();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlForms.Controls.Add(childForm);
            pnlForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblMenuName.Text = childForm.Text;
            Text = TITLE + " - " + childForm.Text;
        }



        public frmMain()
        {
            InitializeComponent();
            random = new Random();
            Text = TITLE;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void frmMain_Load(object sender,EventArgs e)
        {
            //activeForm = dashboard;
            //Text = TITLE + "Dashboard";
            //dashboard.TopLevel = false;
            //dashboard.AutoScroll = true;
            //pnlForms.Controls.Add(dashboard);
            //dashboard.Show();
            btnDashboard.PerformClick();
        }

        private void btnDashboard_Click(object sender,EventArgs e)
        {
            //if(activeForm != dashboard)
            //{
            //    activeForm.Hide();
            //    lblMenuName.Text = "Dashboard";
            //    Text = TITLE + "Dashboard";
            //    activeForm = dashboard;
            //    dashboard.TopLevel = false;
            //    dashboard.AutoScroll = true;
            //    pnlForms.Controls.Add(dashboard);
            //    dashboard.Show();
            //}
            if(currentButton != (Button)sender)
            {
                OpenChildForm(new Forms.frmDashboard(),sender);
            }


        }

        private void btnBooks_Click(object sender,EventArgs e)
        {
            //if(activeForm != books)
            //{
            //    activeForm.Hide();
            //    lblMenuName.Text = "Books";
            //    Text = TITLE + "Books";
            //    activeForm = books;
            //    books.TopLevel = false;
            //    books.AutoScroll = true;
            //    pnlForms.Controls.Add(books);
            //    books.Show();
            //}
            if(currentButton != (Button)sender)
                OpenChildForm(new Forms.frmBooks(),sender);

        }

        private void btnAuthors_Click(object sender,EventArgs e)
        {
            //if(activeForm != authors)
            //{
            //    activeForm.Hide();
            //    lblMenuName.Text = "Authors";
            //    Text = TITLE + "Authors";
            //    activeForm = authors;
            //    authors.TopLevel = false;
            //    authors.AutoScroll = true;
            //    pnlForms.Controls.Add(authors);
            //    authors.Show();
            //}
            if(currentButton != (Button)sender)
                OpenChildForm(new Forms.frmAuthors(),sender);
        }

        private void btnRentals_Click(object sender,EventArgs e)
        {
            //if(activeForm != authors)
            //{
            //    activeForm.Hide();
            //    lblMenuName.Text = "Rentals";
            //    Text = TITLE + "Rentals";
            //    activeForm = rentals;
            //    rentals.TopLevel = false;
            //    rentals.AutoScroll = true;
            //    pnlForms.Controls.Add(rentals);
            //    rentals.Show();
            //}
            if(currentButton != (Button)sender)
                OpenChildForm(new Forms.frmRentals(),sender);
        }

        private void btnAccounts_Click(object sender,EventArgs e)
        {
            //if(activeForm != accounts)
            //{
            //    activeForm.Hide();
            //    lblMenuName.Text = "Accounts";
            //    Text = TITLE + "Accounts";
            //    activeForm = accounts;
            //    accounts.TopLevel = false;
            //    accounts.AutoScroll = true;
            //    pnlForms.Controls.Add(accounts);
            //    accounts.Show();
            //}
            if(currentButton != (Button)sender)
                OpenChildForm(new Forms.frmAccounts(),sender);
        }

        private void btnSubjects_Click(object sender,EventArgs e)
        {
            //if(activeForm != subjects)
            //{
            //    activeForm.Hide();
            //    lblMenuName.Text = "Subjects";
            //    Text = TITLE + "Subjects";
            //    activeForm = subjects;
            //    subjects.TopLevel = false;
            //    subjects.AutoScroll = true;
            //    pnlForms.Controls.Add(subjects);
            //    subjects.Show();
            //}
            if(currentButton != (Button)sender)
                OpenChildForm(new Forms.frmSubjects(),sender);
        }

        private void Reset()
        {
            DisableButton();
            lblMenuName.Text = "Dashboard";
            pnlTitle.BackColor = Color.FromArgb(0,150,136);
            pnlLogo.BackColor = Color.FromArgb(39,39,58);
            currentButton = null;
        }

    }
}
