using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Template.Entity
{
    public partial class ModelTemplate
    {
        ModelGenerator generator;
        public ModelTemplate(ModelGenerator g)
        {
            generator = g;
        }
        public string GetBodyClass()
        {
            string content="";
            Table table = generator.Table;
            int count = table.Count;
            string p1, p2;
            Column c;
            for(int i =0;i<count;i++)
            {
                c = table[i];
                p2 = c.BindingName;
                if (c.MapType == MapType.PRIMITIVE)
                    p1 = c.BindingType;
                else p1 = c.ReferenceColumn.Table.BindingName;
                content += string.Format("            public {0} {1} {{ get; set; }}\n",p1,p2);

            }
            return content;
        }
    }
}
