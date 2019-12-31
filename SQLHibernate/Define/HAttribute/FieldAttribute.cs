using SQLHibernate.Define.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.HAttribute
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property,
            Inherited = true, AllowMultiple = false)]
    public class FieldAttribute : Attribute
    {
        private string name;
        private FieldFlags flags = FieldFlags.Read | FieldFlags.Write;
        public FieldAttribute(string name)
        {
            this.name = name;
        }
        public FieldAttribute(string name, FieldFlags flags)
        {
            this.name = name;
            this.flags = flags;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public FieldFlags Flags
        {
            get
            {
                return flags;
            }
        }
    }
}
