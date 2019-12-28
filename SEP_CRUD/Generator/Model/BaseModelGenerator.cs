using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Entity;

namespace SEP_CRUD.Generator.Model
{
    class BaseModelGenerator: ClassGenerator
    {
        public BaseModelGenerator(ProjectGenerator p) : 
            base(p, "BaseModel")
        {
            Namespaces.Add("Model");
        }

        public override string ToSourceCode()
        {
            var template = new BaseModelTemplate();
            template.Session = new Dictionary<string, object>();
            template.Session.Add("_namespace", Namespace);
            template.Initialize();
            return template.TransformText();
        }
    }
}
