using System;
using System.Drawing;
using System.Windows.Forms;

namespace SeniceroDAngelo_ScreenDesign.Forms
{
    public partial class frmBooks:Form
    {
        public frmBooks()
        {
            InitializeComponent();
            mnuBooks.Renderer = new MyRenderer();
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

        private void myToolStripMenuItem_MouseEnter(object sender,EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.White; //new color
        }

        private void myToolStripMenuItem_MouseLeave(object sender,EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Black; //original color
        }

    }
}
