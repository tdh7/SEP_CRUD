using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SEP_CRUD
{
    class Util
    {
        public static string GetTextFromAsset(string path)
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            string NAME = "SEP_CRUD." + path;
            using (Stream stream = ass.GetManifestResourceStream(NAME))
            {

                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
