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
    public partial class CreateOrUpdateDataForm : BaseForm
    {
        private Action<SinhVien> _saveAction;
        private BindingSource bindingSourceItem = new BindingSource();

        public CreateOrUpdateDataForm()
        {
            InitializeComponent();
        }


        public static void Edit(SinhVien sv, Action<SinhVien> saveAction)
        {
            CreateOrUpdateDataForm f = new CreateOrUpdateDataForm();
            f.InitBinder(sv);
            f._saveAction = saveAction;
            f.ShowDialog();
        }

        public static void Add(Action<SinhVien> saveAction)
        {
            CreateOrUpdateDataForm f = new CreateOrUpdateDataForm();
            f.InitBinder(new SinhVien());
            f._saveAction = saveAction;
            f.ShowDialog();
        }

        private void InitBinder(SinhVien sv)
        {
            bindingSourceItem.DataSource = sv;
            textBoxHoTen.DataBindings.Add("Text", bindingSourceItem, "Ten");
            textBoxDiemTB.DataBindings.Add("Text", bindingSourceItem, "DiemTB");
            textBoxMSSV.DataBindings.Add("Text", bindingSourceItem, "Mssv");

            // Traditional way
//            textBoxHoTen.Text = sv.Ten;
//            textBoxDiemTB.Text = sv.DiemTB.ToString();
//            textBoxMSSV.Text = sv.Mssv.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var item = bindingSourceItem.Current as SinhVien;
            item.EndEdit();
            _saveAction.Invoke(item);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var item = bindingSourceItem.Current as SinhVien;
            item.CancelEdit();
            this.Close();
        }
    }
}
