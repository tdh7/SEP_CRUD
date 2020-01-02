using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHibernate.DAO;

namespace SQLHibernateTest
{
    class FirmDAO : AbstractDAO<Firm>
    {
        private FirmDAO() : base() { }

        public static FirmDAO Instance
        {
            get
            {
                return new FirmDAO();
            }
        }
    }
}
