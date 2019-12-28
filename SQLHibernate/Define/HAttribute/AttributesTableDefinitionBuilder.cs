using SQLHibernate.Define.HDefinition;
using SQLHibernate.Define.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.HAttribute
{
    class AttributesTableDefinitionBuilder : ITableDefinitionBuilder
    {
        public TableDefinition Build(Type type)
        {
            if (!type.IsDefined(typeof(TableAttribute), false))
                return null;

            TableAttribute ta = (TableAttribute)type.GetCustomAttributes(typeof(TableAttribute), false)[0];

            TableDefinition table = new TableDefinition(ta.Name).SetSchema(ta.Schema);

            List<MemberInfo> members = new List<MemberInfo>();

            BindingFlags flags = BindingFlags.Instance
                    | BindingFlags.Public
                    | BindingFlags.NonPublic;
            //get all public and non public field of class
            members.AddRange(type.GetFields(flags));
            members.AddRange(type.GetProperties(flags));

            foreach(MemberInfo member in members)
            {
                if(!member.IsDefined(typeof(FieldAttribute), false))
                {
                    continue;
                }
                FieldAttribute fa = (FieldAttribute)member.GetCustomAttributes(typeof(FieldAttribute), false)[0];

                
                FieldDefinition field = new FieldDefinition(table, fa.Name, fa.Flags).MapTo(member.Name);
                table.fields.Add(field);
            }
            return table;
        }
    }
}
