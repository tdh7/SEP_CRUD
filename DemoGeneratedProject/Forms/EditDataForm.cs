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

        private static F SetUpForm(E entity, Action<E> saveAction)
        {
            if (entity == null)
                entity = new E();

            F f = new F();
            f.InitBinder(entity);
            f._saveAction = saveAction;
            return f;
        }

        public static void Edit(E entity, Action<E> saveAction)
        {
            F f = SetUpForm(entity, saveAction);
            f.OnFormLoaded(f, FormType.FormUpdate);
            f.ShowDialog();
        }

        public static void Add(Action<E> saveAction)
        {
            F f = SetUpForm(null, saveAction);
            f.OnFormLoaded(f, FormType.FormAdd);
            f.ShowDialog();
        }

        protected virtual void InitBinder(E entity)
        {
            bindingSourceItem.DataSource = entity;
        }

        protected virtual void OnFormLoaded(object sender, FormType e)
        {
        }

        protected virtual void OnValidate(object sender, CancelEventArgs e)
        {

        }

        private void SaveChange()
        {
            var item = bindingSourceItem.Current as E;
            item.EndEdit();
            _saveAction.Invoke(item);
        }

        private void UndoChange()
        {
            var item = bindingSourceItem.Current as E;
            item.CancelEdit();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Validate();
            SaveChange();
            this.Close();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            UndoChange();
        }
    }

    public enum FormType
    {
        FormAdd,
        FormUpdate
    }
}
