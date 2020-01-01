using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.Inteface
{
    interface IField
    {
        void SetValue(object target, object value);
        object GetValue(object source);
    }
}
