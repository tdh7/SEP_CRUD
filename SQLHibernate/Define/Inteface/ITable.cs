using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.Inteface
{
    interface ITable
    {
        IDatabase Database { get; }
        Type Clazz { get; }

        int Insert(object obj);
        int Update(object obj);
        int Delete(object obj);
        IList ReadAll();

        //IQuery query();

    }
}
