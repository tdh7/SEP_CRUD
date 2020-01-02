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
        
        private static SinhVienDAO _instance = null;

        private SinhVienDAO() { }

        public static SinhVienDAO Instance
        {
            get
            {
                return _instance == null ? new SinhVienDAO() : _instance;
            }
        }
    }
}
