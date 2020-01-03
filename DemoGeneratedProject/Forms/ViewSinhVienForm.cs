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

        private Func<FormType, SinhVien, bool> saveAction;

        public ViewSinhVienForm()
        {
            InitializeComponent();
            saveAction = SaveAction;
        }

        private bool SaveAction(FormType formMode, SinhVien item)
        {
            bool saveSuccess = false;
            Action action = () =>
            {
                if (formMode == FormType.FormAdd)
                {
                    sinhVienDao.Insert(item);
                    bindingList.Add(item);
                }

                if (formMode == FormType.FormUpdate)
                {
                    sinhVienDao.Update(item);
                }

                saveSuccess = true;
            };

            ShowErrorMessageIfNeed(action);
            return saveSuccess;
        }

        protected override IList<SinhVien> initList()
        {
            return sinhVienDao.readAll();
            return new List<SinhVien>();
        }

        protected override void Add()
        {
            EditSinhVienForm.Add(saveAction);
        }

        protected override void Edit(SinhVien item)
        {
            EditSinhVienForm.Edit(item, saveAction);
        }

        protected override void Delete(SinhVien item)
        {
            var dialogResult = MessageBox.Show("Are you sure to delete this item? This action can't undo.", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                ShowErrorMessageIfNeed((() =>
                {
                    sinhVienDao.Delete(item);
                    bindingList.Remove(item);
                }));
            }
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
