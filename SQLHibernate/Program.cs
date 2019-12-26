using SQLHibernate.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            IList firms = FirmDAO.Instance.readAll();
            foreach (Firm firm in firms)
            {
                Console.WriteLine(firm.NameFirm);
            }
            Console.WriteLine(firms.Count);
            //Firm f = firms[8] as Firm;
            //f.NameFirm = "def";
            //Console.WriteLine(FirmDAO.Instance.Update(f));
            //f.IDFirm = 10;
            //f.NameFirm = "test";
            //Console.WriteLine(FirmDAO.Instance.Insert(f));
            //firms = FirmDAO.Instance.readAll();

            //Console.WriteLine(firms.Count);
        }
    }
}
