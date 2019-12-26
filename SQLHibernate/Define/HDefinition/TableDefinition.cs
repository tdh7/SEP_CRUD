using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.HDefinition
{
    class TableDefinition
    {
        private string name;
        private string schema;

        public List<FieldDefinition> fields = new List<FieldDefinition>();

        public TableDefinition(string name)
        {
            this.name = name;
        }

        public TableDefinition SetSchema(string schema)
        {
            this.schema = schema;
            return this;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Schema
        {
            get
            {
                return schema;
            }
        }

    }
}
