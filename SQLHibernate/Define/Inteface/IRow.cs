using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.Inteface
{
    interface IRow
    {
        int FieldCount { get; }
        string[] FieldNames { get; }

        object this[string name] { get; }
        object this[int index] { get; }

        int GetValues(object[] values);
    }
}
