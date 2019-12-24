using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Entities
{
    public class TypeBinder
    {
        private static TypeBinder sTypeBinder;
        public static TypeBinder Instance
        {
            get
            {
                if(sTypeBinder==null)
                {
                    sTypeBinder = new TypeBinder();
                }
                return sTypeBinder;
            }
        }

        public TypeBinder()
        {
            Init();
        }


        private Dictionary<string, string> Types = new Dictionary<string, string>();

        private void Init()
        {
            Types.Add("bigint", "long");

            Types.Add("binary", "byte[]");

            Types.Add("bit", "boolean");

            Types.Add("char", "string");

            Types.Add("date", "DateTime");

            Types.Add("datetime", "DateTime");

            Types.Add("datetime2", "DateTime");

            Types.Add("datetimeoffset", "DateTimeOffset");

            Types.Add("decimal", "decimal");

            Types.Add("float", "float");

            Types.Add("image", "byte[]");

            Types.Add("int", "int");

            Types.Add("money", "decimal");

            Types.Add("nchar", "string");

            Types.Add("ntext", "string");

            Types.Add("numeric", "decimal");

            Types.Add("nvarchar", "string");

            Types.Add("real", "double");

            Types.Add("smalldatetime", "DateTime");

            Types.Add("smallint", "short");

            Types.Add("smallmoney", "decimal");

            Types.Add("text", "string");

            Types.Add("time", "TimeSpan");

            Types.Add("timestamp", "DateTime");

            Types.Add("tinyint", "byte");

            Types.Add("uniqueidentifier", "Guid");

            Types.Add("varbinary", "byte[]");

            Types.Add("varchar", "string");

        }

        public string BindType(string databaseType)
        {
            string type = Types[databaseType];
            if (type == null) type = "string";
            return type;
        }

    }
}
