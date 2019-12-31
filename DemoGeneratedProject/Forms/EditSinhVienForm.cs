using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoGeneratedProject.DTO;

namespace DemoGeneratedProject.Forms
{
    public partial class EditSinhVienForm : EditSinhVienFormBase
    {
        public EditSinhVienForm()
        {
            InitializeComponent();
        }

        protected override void InitBinder(SinhVien entity)
        {
            base.InitBinder(entity);
            textBoxHoTen.DataBindings.Add("Text", bindingSourceItem, "Ten");
            textBoxDiemTB.DataBindings.Add("Text", bindingSourceItem, "DiemTB");
            textBoxMSSV.DataBindings.Add("Text", bindingSourceItem, "Mssv", true, DataSourceUpdateMode.OnValidation, string.Empty);
        }

        protected override void OnFormLoaded(object sender, FormType e)
        {
            if (e == FormType.FormAdd)
            {
                textBoxMSSV.ReadOnly = false;
            }
            else if (e == FormType.FormUpdate)
            {
                textBoxMSSV.ReadOnly = true;
            }
        }
    }

    // This additional inheritance is required to avoid a WinForms bug,
    // which does not allow using generic classes as base classes for forms and uer controls.
    //
    public class EditSinhVienFormBase: EditDataForm<SinhVien, EditSinhVienForm> { }
}
