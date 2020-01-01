using SQLHibernate.Define.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SQLHibernate.Define.SQLServer
{
    class SqlField : IField
    {
        private string name;
        private PropertyInfo property;
        private FieldInfo field;
        private FieldFlags flags = FieldFlags.ReadWrite;

        public SqlField(string name, MemberInfo member, FieldFlags flags)
        {
            this.name = name;
            this.flags = flags;
            if (member.MemberType == MemberTypes.Property)
                property = member as PropertyInfo;
            else
                field = member as FieldInfo;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public PropertyInfo Property
        {
            get { return property; }
            set { this.property = value; }
        }

        public FieldInfo Field
        {
            get { return field; }
            set { this.field = value; }
        }

        public FieldFlags Flags
        {
            get
            {
                return this.flags;
            }
        }

        public Type DataType
        {
            get
            {
                if (property != null)
                    return property.PropertyType;
                return field.FieldType;
            }
        }

        public void SetValue(object target, object value)
        {
            Type dataType = DataType;

            if (dataType.IsGenericType)
                dataType = dataType.GetGenericArguments()[0];
            //if value's datatype does't assign from dataType then convert Type
            if (value != null && !dataType.IsAssignableFrom(value.GetType()))
                value = Convert.ChangeType(value, dataType);

            try
            {
                //update value to SqlField
                if (property != null)
                    property.SetValue(target, value, null);
                else
                    field.SetValue(target, value);
            }
            catch (TargetInvocationException e)
            {
                if (e.InnerException != null)
                    throw e.InnerException;
                throw e;
            }
        }

        public object GetValue(object source)
        {
            object value = null;
            try
            {
                if (property != null)
                    value = property.GetValue(source, null);
                else
                    value = field.GetValue(source);
            }
            catch (TargetInvocationException e)
            {
                if (e.InnerException != null)
                    throw e.InnerException;
                throw e;
            }
            return value;
        }
    }
}
