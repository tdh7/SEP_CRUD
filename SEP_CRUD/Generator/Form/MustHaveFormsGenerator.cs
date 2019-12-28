using SEP_CRUD.Generator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD.Generator.Form
{
    public class MustHaveFormsGenerator : GroupGenerator<FormGenerator>
    {
        public MustHaveFormsGenerator()
        {
        }

        public override string GetFileName()
        {
            return "";
        }

        public override string GetRelativePath()
        {
            return "";
        }

        public override string ToSourceCode()
        {
            return "";
        }
        public override bool HasContent()
        {
            return false;
        }
    }
}
