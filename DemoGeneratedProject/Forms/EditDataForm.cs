using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DemoGeneratedProject.DTO;

namespace DemoGeneratedProject.Forms
{
    public partial class EditDataForm<E, F> : BaseForm
        where E: BaseModel, new()
        where F: EditDataForm<E, F>, new()
    {
        private Action<E> _saveAction;
        protected BindingSource bindingSourceItem = new BindingSource();

        public EditDataForm()
        {
            InitializeComponent();
        }

        private static void SetUpAndShowForm(E entity, Action<E> saveAction)
        {
            if (entity == null)
                entity = new E();

            F f = new F();
            f.InitBinder(entity);
            f._saveAction = saveAction;
            f.ShowDialog();
        }

        public static void Edit(E entity, Action<E> saveAction)
        {
            SetUpAndShowForm(entity, saveAction);
        }

        public static void Add(Action<E> saveAction)
        {
            SetUpAndShowForm(null, saveAction);
        }

        protected virtual void InitBinder(E entity)
        {
            bindingSourceItem.DataSource = entity;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var item = bindingSourceItem.Current as E;
            item.EndEdit();
            _saveAction.Invoke(item);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var item = bindingSourceItem.Current as E;
            item.CancelEdit();
            this.Close();
        }
    }
}
