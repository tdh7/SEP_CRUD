using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    class ViewFormFactoryGenerator: ClassGenerator
    {
        private List<Table> tables;

        public ViewFormFactoryGenerator(ProjectGenerator p, List<Table> tables) 
            : base(p, "FormFactory")
        {
            this.tables = tables;
        }

        public override string ToSourceCode()
        {
            var template = new ViewFormFactoryTemplate();
            template._namespace = Namespace;
            template.Tables = tables;
            return template.TransformText();
        }
    }
}
