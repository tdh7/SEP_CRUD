using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Entity
{
    class ForeignKey
    {
        public string column { get; set; }
        public KeyValuePair<string, string> reference { get; set; } //tablename
    }
}
