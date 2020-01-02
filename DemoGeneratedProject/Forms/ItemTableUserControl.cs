using System.Drawing;
using System.Windows.Forms;

namespace DemoGeneratedProject.Forms
{
    public partial class ItemTableUserControl : UserControl
    {
        public ItemTableUserControl()
        {
            InitializeComponent();
        }

        public string BindingName { get; set; } = "UnknownTable";
        public string Databasename { get; set; } = "UNKNOWN_TABLE";

        public int Position { get; } = 0;
        public ItemTableUserControl(int position, string bindingName, string databaseName)
        {
            this.Position = position;
            this.BindingName = bindingName;
            this.Databasename = databaseName;
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            if(Position%4==0)
            {
                this.Margin = new Padding(32, 16, 16, 16);
            } else if ((Position + 1) % 4 ==0)
            {
                this.Margin = new Padding(16, 16, 32, 16);
            } else
            {
                this.Margin = new Padding(16, 16, 16, 16);
            }

            Title.Text = this.BindingName;
            Description.Text = "From table \"" + this.Databasename + "\"";
        }

        private void OnMouseMovePanel(object sender, MouseEventArgs e)
        {
            InsidePanel.Height = 223;
            InsidePanel.BackColor = Color.FromArgb(227, 253, 253);
            //Title.ForeColor = Description.ForeColor = Color.White;
        }

        private void OnMouseLeavePanel(object sender, System.EventArgs e)
        {
            InsidePanel.Height = 218;
            InsidePanel.BackColor = Color.White;
            //Title.ForeColor = Description.ForeColor = Color.FromArgb(11,11,11);

        }

        private void OnMouseDownPanel(object sender, MouseEventArgs e)
        {
            Form f = ViewFormFactory.Instance.FindFormByBindingName(BindingName);
            if (f == null) MessageBox.Show("No Form for this item");
            else f.Show();
        }
    }
}
