using SQLHibernate.Define.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.HDefinition
{
    class FieldDefinition
    {
        private TableDefinition table;

        private string fieldName; //name of class's field
        private string columnName; //name of database column
        public FieldFlags flags = FieldFlags.ReadWrite;

        public FieldDefinition(TableDefinition table, string name, FieldFlags flags)
        {
            this.table = table;
            this.columnName = name;
            this.flags |= flags;
        }

        public FieldDefinition MapTo(string name)
        {
            this.fieldName = name;
            return this;
        }

        public string FieldName
        {
            get
            {
                return fieldName;
            }
        }

        public string ColumnName
        {
            get
            {
                return columnName;
            }
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
