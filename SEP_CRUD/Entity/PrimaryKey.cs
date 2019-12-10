using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Entity
{
    class PrimaryKey
    {
        public List<string> columns { get; set; }
        public Dictionary<string, string> references { get; set; } //tablename - columnname

    }
}
