using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    class LoginFormGenerator: FormGenerator
    {
        private string DBName;
        public LoginFormGenerator(ProjectGenerator p, string DBName) 
            : base(p, "LoginForm")
        {
            this.DBName = DBName;
        }

        public override ClassGenerator OnCreateFormDesignerGenerator()
        {
            return new LoginFormDesignerGenerator(this);
        }

        public override string ToSourceCode()
        {
            var template = new LoginFormTemplate();
            template.Generator = this;
            template.DBName = DBName;
            return template.TransformText();
        }
    }
}
