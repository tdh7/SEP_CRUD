﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

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
}
