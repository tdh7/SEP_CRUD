using SQLHibernate.Define.HDefinition;
using SQLHibernate.Define.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.HAttribute
{
    class TableDefinitionFactory
    {
        public static readonly ITableDefinitionBuilder builder = new AttributesTableDefinitionBuilder();

        public static TableDefinition Build(Type type)
        {
            //convert table attribute to table definition
            TableDefinition table = builder.Build(type);
            return table;
        }
    }
}
