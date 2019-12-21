using System;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Base
{
    public class FormGenerator : GroupGenerator<FileGenerator>
    {
        public ProjectGenerator ProjectOwner { get; set; }
        public string Namespace { get; set; }

        public FormGenerator(ProjectGenerator p, string name, string _namespace) 
        {
            ProjectOwner = p;
            this.name = name;
            Namespace = _namespace;
            Add(new FormDesignerGenerator(this));
        }

        public override string GetFileName()
        {
            return name + ".cs";
        }

        public override string GetRelativePath()
        {
            if (ProjectOwner != null)
                return ProjectOwner.GetRelativePath();
            return "";
        }

        public override string ToSourceCode()
        {
            return new FormTemplate(this).TransformText();
        }
    }
}
