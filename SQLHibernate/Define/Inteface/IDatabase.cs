using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.Inteface
{
    interface IDatabase : IDisposable
    {
        bool InTransaction { get; }

        void BeginTransaction();
        //void BeginTransaction(IsolationLevel level);
        void Commit();
        void Rollback();

        //IStatement Prepare(string sql);

        ITable Table(Type type);
        ITable Table<T>();
    }
}
