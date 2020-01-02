using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SEP_CRUD.Forms
{
    public partial class WaitingForm : BaseForm
    {
        public WaitingForm()
        {
            InitializeComponent();
        }

        public Action CloseAction { private get; set; }

        private void WaitingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAction?.Invoke();
        }
    }
}
