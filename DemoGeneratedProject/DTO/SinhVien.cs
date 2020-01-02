using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLHibernate.Define.HAttribute;
using SQLHibernate.Define.SQLServer;

namespace DemoGeneratedProject.DTO
{
    [Table("SINH_VIEN", "dbo")]
    public class SinhVien: BaseModel
    {
        private String _ten;
        private float _diemTb;
        private int? _mssv = null;

        [Field("TEN")]
        public String Ten
        {
            get { return _ten; }

            set
            {
                _ten = value;
                onPropertyChange();
            }
        }
        [Field("DIEM_TB")]
        public float DiemTB
        {
            get => _diemTb;
            set
            {
                _diemTb = value;
                onPropertyChange();
            }
        }

        [Field("MSSV", FieldFlags.Key)]
        public int? Mssv
        {
            get => _mssv;
            set
            {
                _mssv = value;
                onPropertyChange();
            }
        }

        public override string ToString()
        {
            return $"Ho Ten: {Ten}, MSSV: {Mssv}, DiemTB: {DiemTB}";
        }
    }
}
