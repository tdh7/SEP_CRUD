using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoGeneratedProject.Forms
{
    public partial class TableListForm : Form
    {
        public TableListForm()
        {
            InitializeComponent();
            this.Load += OnLoadTableListForm;
            this.Notification.MouseDown += OnMouseDownNotification;
            OpenLoginForm();
        }

        private void OnMouseDownNotification(object sender, MouseEventArgs e)
        {
            if (!Result) OpenLoginForm();
        }

        private bool Result = false;

        private void OnLoadTableListForm(object sender, System.EventArgs e)
        {
            RefreshData();
        }

        private void OpenLoginForm()
        {
            LoginForm form = new LoginForm();
            form.LoginResultHandler = OnLoginResult;
            Hide();
            form.ShowDialog(); // Force user focus on login form
        }

        private void OnLoginResult(object sender, bool e)
        {
            Show();
            Result = e;
            RefreshData();
        }

        private List<ItemTableUserControl> ItemTableUserControls = new List<ItemTableUserControl>();

        private void RefreshData()
        {
            ItemTableUserControls.Clear();
            FlowListPanel.Controls.Clear();

            if (Result)
            {
                FlowListPanel.Controls.Add(Title);
                /*
                for (int i = 0; i < 7; i++)
                {
                    ItemTableUserControl c = new ItemTableUserControl(i, "Item " + i, "ITEM_" + i);
                    FlowListPanel.Controls.Add(c);
                }
                */

                ViewFormFactory factory = ViewFormFactory.Instance;
                int count = factory.Count;

                ItemTableUserControl c;
                for(int i = 0; i < count; i++)
                {
                    c = new ItemTableUserControl(i, factory.BindingNames[i], factory.DatabaseNames[i]);
                    FlowListPanel.Controls.Add(c);
                    ItemTableUserControls.Add(c);
                }
            } else
            {
                FlowListPanel.Controls.Add(Notification);
            }
        }
    }
}
