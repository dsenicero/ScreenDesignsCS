﻿using System.Drawing;
using System.Windows.Forms;

namespace SeniceroDAngelo_ScreenDesign.Forms
{
    public partial class frmSubjects:Form
    {
        public frmSubjects()
        {
            InitializeComponent();
            mnuSubjects.Renderer = new MyRenderer();
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
    }
}