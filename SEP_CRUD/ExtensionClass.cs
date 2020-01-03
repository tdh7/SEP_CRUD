using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using SEP_CRUD.Entities;

namespace SEP_CRUD
{
    public static class CollectionExtension
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

    public static class StringExtension
    {

        public static string ClearSpace(this string str)
        {
            string[] strs = str.Split(' ');
            return String.Concat(strs);
        }

        public static string toClassNameNotation(this string schemaNameNotation)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            schemaNameNotation = schemaNameNotation.Replace('_', ' ');
            schemaNameNotation = textInfo.ToTitleCase(schemaNameNotation);
            schemaNameNotation = schemaNameNotation.ClearSpace();                        
            return schemaNameNotation;
        }
    }

    public static class ColumnExtension
    {
        public static bool IsAbleBindingToTextBoxControl(this Column column)
        {
            string primitiveType = column.BindingType;

            return primitiveType.Equals(BindingType.DOUBLE) ||
                   primitiveType.Equals(BindingType.FLOAT) ||
                   primitiveType.Equals(BindingType.INT) ||
                   primitiveType.Equals(BindingType.SHORT) ||
                   primitiveType.Equals(BindingType.LONG) ||
                   primitiveType.Equals(BindingType.STRING);
        }

        public static bool IsAbleBindingToDateTimePicker(this Column column)
        {
            string primitiveType = column.BindingType;

            return primitiveType.Equals(BindingType.DATE_TIME);
        }

        public static bool IsAbleBindingToCheckbox(this Column column)
        {
            string primitiveType = column.BindingType;

            return primitiveType.Equals(BindingType.BOOL);
        }
    }
}
