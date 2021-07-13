using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SeniceroDAngelo_ScreenDesign
{
    public partial class frmMain:Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //private frmDashboard dashboard = new frmDashboard();
        //private frmSubjects subjects = new frmSubjects();
        //private frmAuthors authors = new frmAuthors();
        //private frmBooks books = new frmBooks();
        //private frmRentals rentals = new frmRentals();
        //private frmAccounts accounts = new frmAccounts();

        public const string TITLE = "My Library Program";

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(this.currentButton != (Button)btnSender)
                {
                    this.DisableButton();
                    Color color = this.SelectThemeColor();
                    this.currentButton = (Button)btnSender;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    foreach(Button button in this.pnlMenu.Controls.OfType<Button>())
                    {
                        button.BackColor = ThemeColor.SecondaryColor;
                        if(ThemeColor.SecondaryColor.R * 0.2126 + ThemeColor.SecondaryColor.G *
                            0.7152 + ThemeColor.SecondaryColor.B * 0.0722 > 255 / 2)
                        {
                            //dark color
                            button.ForeColor = Color.Black;
                        }
                        else
                        {
                            //light color
                            button.ForeColor = Color.White;
                        }

                    }
                    this.currentButton.BackColor = ThemeColor.PrimaryColor;
                    this.currentButton.ForeColor = Color.White;
                    this.pnlTitle.BackColor = ThemeColor.PrimaryColor;
                    this.pnlLogo.BackColor = ThemeColor.SecondaryColor;
                    this.pnlMenu.BackColor = ThemeColor.SecondaryColor;
                    this.currentButton.Enabled = false;
                }
            }

        }

        private void DisableButton()
        {
            foreach(Control previousBtn in this.pnlMenu.Controls)
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
            if(this.activeForm != null)
            {
                this.activeForm.Close();
                this.Reset();
            }

            this.ActivateButton(btnSender);
            this.activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlForms.Controls.Add(childForm);
            this.pnlForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.lblMenuName.Text = childForm.Text;
            this.Text = TITLE + " - " + childForm.Text;
        }
        public frmMain()
        {
            this.InitializeComponent();
            this.random = new Random();
            this.Text = TITLE;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private Color SelectThemeColor()
        {
            int index = this.random.Next(ThemeColor.ColorList.Count);
            while(this.tempIndex == index)
            {
                index = this.random.Next(ThemeColor.ColorList.Count);
            }
            this.tempIndex = index;
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
            this.btnDashboard.PerformClick();
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
            if(this.currentButton != (Button)sender)
            {
                this.OpenChildForm(new Forms.frmDashboard(),sender);
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
            if(this.currentButton != (Button)sender)
            {
                this.OpenChildForm(new Forms.frmBooks(),sender);
            }
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
            if(this.currentButton != (Button)sender)
            {
                this.OpenChildForm(new Forms.frmAuthors(),sender);
            }
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
            if(this.currentButton != (Button)sender)
            {
                this.OpenChildForm(new Forms.frmRentals(),sender);
            }
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
            if(this.currentButton != (Button)sender)
            {
                this.OpenChildForm(new Forms.frmAccounts(),sender);
            }
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
            if(this.currentButton != (Button)sender)
            {
                this.OpenChildForm(new Forms.frmSubjects(),sender);
            }
        }

        private void Reset()
        {
            this.DisableButton();
            this.lblMenuName.Text = "Dashboard";
            this.pnlTitle.BackColor = Color.FromArgb(0,150,136);
            this.pnlLogo.BackColor = Color.FromArgb(39,39,58);
            this.currentButton = null;
        }

    }
}
