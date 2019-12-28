using SQLHibernate.Define.HAttribute;
using SQLHibernate.Define.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.DTO
{
    [Table("Firm", "dbo")]
    class Firm
    {
        private int? id;
        private string name;
        private bool delete;

        [Field("IDFirm", FieldFlags.Key)]
        public int? IDFirm
        {
            get { return id; }
            set { id = value; }
        }

        [Field("NameFirm")]
        public string NameFirm
        {
            get { return name; }
            set { name = value; }
        }

        [Field("isDelete")]
        public bool isDelete
        {
            get { return delete; }
            set { delete = value; }
        }
    }
}
