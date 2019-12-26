using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoGeneratedProject.DTO
{
    public class SinhVien: BaseObject
    {
        private String _ten;
        private float _diemTb;
        private int _mssv;

        public String Ten
        {
            get { return _ten; }

            set
            {
                _ten = value;
                onPropertyChange();
            }
        }

        public float DiemTB
        {
            get => _diemTb;
            set
            {
                _diemTb = value;
                onPropertyChange();
            }
        }

        public int Mssv
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
