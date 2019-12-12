using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoGeneratedProject.DTO;

namespace DemoGeneratedProject.DAOs
{
    class SinhVienDAO
    {
        public void Update(SinhVien sv)
        {
            
        }

        public void Add(SinhVien sv)
        {
            
        }

        public void Delete(SinhVien sv)
        {
            
        }

        public static IList<SinhVien> GetList()
        {
            return generateDummyList();
        }

        private static IList<SinhVien> generateDummyList()
        {
            IList<SinhVien> sv = new List<SinhVien>();
            sv.Add(new SinhVien() { DiemTB = 10.0f, Mssv = 1612110, Ten = "Nguyen Van A" });
            sv.Add(new SinhVien() { DiemTB = 8.5f, Mssv = 1612049, Ten = "Tran Thi B" });
            sv.Add(new SinhVien() { DiemTB = 7.9f, Mssv = 1612942, Ten = "Le Van C" });

            return sv;
        }
    }
}
