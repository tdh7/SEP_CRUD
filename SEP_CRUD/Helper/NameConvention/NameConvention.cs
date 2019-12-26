using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Helper.NameConvention
{
    public interface NameConvention
    {
        string Normalize(string input);
    }

    public class PascalCaseConvention : NameConvention
    {
        public string Normalize(string str)
        {
            string[] arr = str.Split(new[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
            return arr.Select(s => char.ToUpperInvariant(s[0]) + s.Substring(1, s.Length - 1).ToLowerInvariant()).Aggregate(string.Empty, (s1, s2) => s1 + s2);
        }
    };

    public class UpperCaseWithUnderscoreConvention : NameConvention
    {
        public string Normalize(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }

    public class KeepOriginalConvention : NameConvention
    {
        public string Normalize(string str)
        {
            return str;
        }
    }
}
