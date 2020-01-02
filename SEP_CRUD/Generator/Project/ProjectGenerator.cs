using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Project;

namespace SEP_CRUD.Generator.Project
{
    public class ProjectGenerator : GroupGenerator<FileGenerator>
    {
        public string TypeGuid {
            get { return "FAE04EC0-301F-11D3-BF4B-00C04F79EFBC"; }
        }

        public string DefaultFormNamespace { get; set; } = "Forms";
        public string DefaultModelNamespace { get; set; } = "Models";
        public string DefaultDAONamespace { get; set; } = "DAO";
        public string DefaultFormNamespaces
        {
            get { return Name + "." + DefaultFormNamespace; }
        }

        public string DefaultModelNamespaces
        {
            get { return Name + "." + DefaultModelNamespace; }
        }

        public string DefaultDAONamespaces
        {
            get { return Name + "." + DefaultDAONamespace; }
        }

        public string Guid { get; }
        private FormGenerator startupForm;
        public FormGenerator StartupForm { get { return startupForm; } }

        public void AddAsStartupForm(FormGenerator g)
        {
            startupForm = g;
            Add(g);
        }

        private ProjectGenerator(string name)
        {
            this.name = name;
            Guid = System.Guid.NewGuid().ToString().ToUpperInvariant();
        }

        public static ProjectGenerator NewInstance(string name)
        {
            ProjectGenerator p = new ProjectGenerator(name);
            p.Add(MustHaveGroupGenerator.NewInstance(p));
            return p;
        }

        public override string GetFileName()
        {
            return name + ".csproj";
        }

        public override string GetRelativePath()
        {
            return name;
        }

        public override string ToSourceCode()
        {
            return new ProjectTemplate(this).TransformText();
        }

    }
}
