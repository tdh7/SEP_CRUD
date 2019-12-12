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
    public partial class ViewDataFrom : DemoGeneratedProject.Forms.BaseForm
    {
        private BindingList<SinhVien> bindingList;
        private SinhVienBUS sinhVienBus = new SinhVienBUS();

        public ViewDataFrom()
        {
            InitializeComponent();

            editToolStripMenuItem.Click += EditDataItem;
            toolStripButtonEdit.Click += EditDataItem;

            deleteToolStripMenuItem.Click += DeleteDataItem;
            toolStripButtonDelete.Click += DeleteDataItem;
        }

        private void ViewDataFrom_Load(object sender, EventArgs e)
        {
            bindingList = new BindingList<SinhVien>(sinhVienBus.GetList());
            dataGridView1.DataSource = bindingList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingList.Add(new SinhVien() {DiemTB = 9.1f, Mssv = 1617290, Ten = "NGuyen VaN A"});
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataGridView1.CurrentRow.DataBoundItem;
            Edit((SinhVien) item);
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            CreateOrUpdateDataForm.Add(delegate(SinhVien sv)
            {
                bindingList.Add(sv);
                sinhVienBus.Add(sv);
            });
        }

        private void Edit(SinhVien item)
        {
            CreateOrUpdateDataForm.Edit(item, delegate(SinhVien sv)
            {
                sinhVienBus.Update(sv);
            });
        }

        private void Delete(SinhVien item)
        {
            sinhVienBus.Delete(item);
            bindingList.Remove(item);
        }

        private void EditDataItem(object sender, EventArgs e)
        {
            var item = dataGridView1.CurrentRow.DataBoundItem;
            Edit((SinhVien)item);
        }

        private void DeleteDataItem(object sender, EventArgs e)
        {
            var item = dataGridView1.CurrentRow.DataBoundItem;
            Delete((SinhVien)item);
        }
    }
}