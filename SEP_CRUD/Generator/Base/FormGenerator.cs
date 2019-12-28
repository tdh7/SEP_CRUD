using System;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Base
{
    public abstract class FormGenerator : GroupGenerator<ClassGenerator>
    {
        public ProjectGenerator ProjectOwner { get; set; }
        public string Namespace
        {
            get
            {
                return this[0].Namespace;
            }
        }

        public FormGenerator(ProjectGenerator p, string name) 
        {
            ProjectOwner = p;
            this.name = name;
            Add(FormDesignerGenerator);
        }

        public abstract FormDesignerGenerator FormDesignerGenerator { get; }

        public override string GetFileName()
        {
            return name + ".cs";
        }

        public override string GetRelativePath()
        {
            return this[0].GetRelativePath();
        }
    }
}
