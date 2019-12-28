using SQLHibernate.Define.HDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.Inteface
{
    interface ITableDefinitionBuilder
    {
        TableDefinition Build(Type type);
    }
}
