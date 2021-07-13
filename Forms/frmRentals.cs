using System.Drawing;
using System.Windows.Forms;

namespace SeniceroDAngelo_ScreenDesign.Forms
{
    public partial class frmRentals:Form
    {
        public frmRentals()
        {
            InitializeComponent();
            mnuRentals.Renderer = new MyRenderer();
        }
        private class MyRenderer:ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors:ProfessionalColorTable
        {

            public override Color MenuItemSelected
            {
                get
                {
                    return ThemeColor.PrimaryColor;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return ThemeColor.PrimaryColor;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return ThemeColor.PrimaryColor;
                }
            }
        }

        private void addBooksToolStripMenuItem_MouseEnter(object sender,System.EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.White; //new color
        }

        private void addBooksToolStripMenuItem_MouseLeave(object sender,System.EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Black; //new color
        }
    }
}
