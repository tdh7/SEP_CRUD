using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace DemoGeneratedProject
{
    public static class ExtensionClass
    {
        public static bool isEmpty(this ICollection collection)
        {
            return collection.Count == 0;
        }

        public static bool isEmpty<T>(this ICollection<T> collection)
        {
            return collection.Count == 0;
        }

        public static void DisplayData(this DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                }
                Console.WriteLine("============================");
            }
        }
    }
}
