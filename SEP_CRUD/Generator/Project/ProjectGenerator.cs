using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Project;

namespace SEP_CRUD.Generator.Project
{
    public class ProjectGenerator : GroupGenerator<FileGenerator>
    {
        public string TypeGuid {
            get { return "FAE04EC0-301F-11D3-BF4B-00C04F79EFBC"; }
        }

        public string Guid { get; }

        public FileGenerator DefaultFormGenerator { get; set; }


        private ProjectGenerator(string name)
        {
            this.name = name;
            Guid = System.Guid.NewGuid().ToString().ToUpperInvariant();
        }

        public static ProjectGenerator NewInstance(string name)
        {
            ProjectGenerator p = new ProjectGenerator(name);
            p.DefaultFormGenerator = p;
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
