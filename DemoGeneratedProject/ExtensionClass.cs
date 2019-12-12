using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneratedProject
{
    public static class ExtensionClass
    {
        public static bool isEmpty(this Hashtable hashtable)
        {
            return hashtable.Count == 0;
        }
    }
}
