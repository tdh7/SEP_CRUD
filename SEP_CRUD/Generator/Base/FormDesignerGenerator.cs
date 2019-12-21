using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Base
{
    public class FormDesignerGenerator : FileGenerator
    {
        FormGenerator Owner;
        public FormDesignerGenerator(FormGenerator owner) 
        {
            Owner = owner;
            this.name = owner.Name;
        }
        public string Namespace
        {
            get { return Owner.Namespace; }
        }

        public override string GetFileName()
        {
            return Owner.Name + ".Designer.cs";
        }

        public override string GetRelativePath()
        {
            return Owner.GetRelativePath();
        }

        public override string ToSourceCode()
        {
            return new FormDesignerTemplate(this).TransformText();
        }
    }
}
