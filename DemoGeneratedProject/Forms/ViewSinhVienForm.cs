using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoGeneratedProject.BUS;
using DemoGeneratedProject.DAOs;
using DemoGeneratedProject.DTO;

namespace DemoGeneratedProject.Forms
{
    public partial class ViewSinhVienForm: ViewDataFrom<SinhVien>
    {
        private SinhVienBUS sinhVienBus = new SinhVienBUS();

        private SinhVienDAO sinhVienDao = SinhVienDAO.Instance;

        public ViewSinhVienForm()
        {
            InitializeComponent();
        }

        protected override IList<SinhVien> initList()
        {
//            return sinhVienDao.readAll();
            return new List<SinhVien>();
        }

        protected override void Add()
        {
            EditSinhVienForm.Add(delegate(SinhVien sv)
            {
                bindingList.Add(sv);
//                sinhVienDao.Insert(sv);
            });
        }

        protected override void Edit(SinhVien item)
        {
            EditSinhVienForm.Edit(item, delegate(SinhVien sv)
            {
//                sinhVienDao.Update(sv);
            });
        }

        protected override void Delete(SinhVien item)
        {
//            sinhVienDao.Delete(item);
            bindingList.Remove(item);
        }

        protected override void ViewDataFrom_Load(object sender, EventArgs e)
        {
            base.ViewDataFrom_Load(sender, e);

            // change DataGridView column header name, column width,...
            dataGridView1.Columns[0].HeaderText = "Họ và tên";
            dataGridView1.Columns[1].HeaderText = "Điểm Trung Bình";
            dataGridView1.Columns[2].HeaderText = "MSSV";
        }
    }
}
