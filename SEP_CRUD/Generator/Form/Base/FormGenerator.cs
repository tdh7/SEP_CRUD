using SEP_CRUD.Generator.Project;

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

        public virtual string SubType => "Form";

        public FormGenerator AddToNamespace(string _namespace)
        {
            this[0].AddToNamespace(_namespace);
            return this;
        }

        public FormGenerator(ProjectGenerator p, string name) 
        {
            ProjectOwner = p;
            this.name = name;
            Add(OnCreateFormDesignerGenerator());
            AddToNamespace(p.DefaultFormNamespace);
        }

        public abstract ClassGenerator OnCreateFormDesignerGenerator();

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
