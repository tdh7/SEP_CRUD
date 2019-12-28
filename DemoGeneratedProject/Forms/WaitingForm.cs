using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoGeneratedProject.Forms
{
    public partial class WaitingForm : BaseForm
    {
        public WaitingForm()
        {
            InitializeComponent();
        }

        private const int WS_SYSMENU = 0x80000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~ WS_SYSMENU;
                return cp;
            }

        }
    }
}
