using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoGeneratedProject.DTO;
using SQLHibernate.DAO;

namespace DemoGeneratedProject.DAOs
{
    class SinhVienDAO: AbstractDAO<SinhVien>
    {
        
        private static IList<SinhVien> generateDummyList()
        {
            IList<SinhVien> sv = new List<SinhVien>();
            sv.Add(new SinhVien() { DiemTB = 10.0f, Mssv = 1612110, Ten = "Nguyen Van A" });
            sv.Add(new SinhVien() { DiemTB = 8.5f, Mssv = 1612049, Ten = "Tran Thi B" });
            sv.Add(new SinhVien() { DiemTB = 7.9f, Mssv = 1612942, Ten = "Le Van C" });

            return sv;
        }

        protected override string ConnectionString
        {
            get
            {
                return "Data Source=NINH\\SQLENTERPIRSE;Initial Catalog=QL_SINH_VIEN;Integrated Security=True"; 

            }
        }

        private static SinhVienDAO _instance = null;

        public static SinhVienDAO Instance
        {
            get
            {
                return _instance == null ? new SinhVienDAO() : _instance;

            }
        }

        private SinhVienDAO(): base() { }
    }
}
