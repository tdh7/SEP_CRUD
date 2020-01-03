using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DemoGeneratedProject.BUS;
using DemoGeneratedProject.DTO;

namespace DemoGeneratedProject.Forms
{
    public partial class ViewDataFrom<E> : BaseForm
        where E: BaseModel
    {
        protected BindingList<E> bindingList;

        public ViewDataFrom()
        {
            InitializeComponent();

            editToolStripMenuItem.Click += EditDataItem;
            toolStripButtonEdit.Click += EditDataItem;

            deleteToolStripMenuItem.Click += DeleteDataItem;
            toolStripButtonDelete.Click += DeleteDataItem;

            toolStripButtonNew.Click += NewDataItem;
            toolStripButtonRefresh.Click += RefreshDataItems;
        }

        protected virtual void ViewDataFrom_Load(object sender, EventArgs e)
        {
            IList<E> list = initList();
            bindingList = new BindingList<E>(list);
            dataGridView1.DataSource = bindingList;
        }

        protected virtual IList<E> initList()
        {
            return new List<E>();
        }

        protected virtual void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataGridView1.CurrentRow.DataBoundItem;
            Edit((E) item);
        }

        protected abstract void Add();
        protected abstract void Edit(E item);

        protected abstract void Delete(E item);

        protected virtual void EditDataItem(object sender, EventArgs e)
        {
            var item = dataGridView1.CurrentRow.DataBoundItem;
            Edit((E)item);
        }

        protected virtual void DeleteDataItem(object sender, EventArgs e)
        {
            var item = dataGridView1.CurrentRow.DataBoundItem;
            Delete((E)item);
        }

        protected virtual void RefreshDataItems(object sender, EventArgs e)
        {
            BindingList<E> bindingList = dataGridView1.DataSource as BindingList<E>;
            IList<E> iList = initList();

            bindingList.Clear();
            foreach (var model in iList)
            {
                bindingList.Add(model);
            }
        }

        protected virtual void NewDataItem(object sender, EventArgs e)
        {
            Add();
        }

        protected void ShowErrorMessageIfNeed(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}