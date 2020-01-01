using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD.Generator.Model
{
    class ConfigControllerGenerator : ClassGenerator
    {
        private string cnnStr;

        public ConfigControllerGenerator(ProjectGenerator p, string cnnStr): base(p, "ConfigController")
        {
            Namespaces.Add("DAO");
            this.cnnStr = cnnStr;
        }

        public override string ToSourceCode()
        {
            var template = new ConfigControllerTemplate();
            template.Generator = this;
            template.ConnectionString = cnnStr;
            return template.TransformText();
        }
    }
}
