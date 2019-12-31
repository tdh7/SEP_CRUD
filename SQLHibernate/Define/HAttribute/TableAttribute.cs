using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.HAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property,
            Inherited = true, AllowMultiple = false)]
    public class TableAttribute : Attribute
    {
        private string name;
        private string schema;

        public TableAttribute(string name)
        {
            this.name = name;
        }

        public TableAttribute(string name, string schema)
        {
            this.name = name;
            this.schema = schema;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Schema
        {
            get { return schema; }
            set { schema = value; }
        }
    }
}
