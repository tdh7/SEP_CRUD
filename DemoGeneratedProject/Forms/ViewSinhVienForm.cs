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
    public partial class ViewSinhVienForm: ViewDataFrom<SinhVien>
    {
        private SinhVienBUS sinhVienBus = new SinhVienBUS();

        public ViewSinhVienForm()
        {
            InitializeComponent();
        }

        protected override IList<SinhVien> initList()
        {
            return sinhVienBus.GetList();
        }

        protected override void Add()
        {
            EditSinhVienForm.Add(delegate(SinhVien sv)
            {
                bindingList.Add(sv);
                sinhVienBus.Add(sv);
            });
        }

        protected override void Edit(SinhVien item)
        {
            EditSinhVienForm.Edit(item, delegate(SinhVien sv)
            {
                sinhVienBus.Update(sv);
            });
        }

        protected override void Delete(SinhVien item)
        {
            sinhVienBus.Delete(item);
            bindingList.Remove(item);
        }

        protected override void ViewDataFrom_Load(object sender, EventArgs e)
        {
            base.ViewDataFrom_Load(sender, e);

        }
    }
}
