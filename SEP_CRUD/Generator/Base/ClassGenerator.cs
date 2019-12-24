using SEP_CRUD.Generator.Project;
using System.Collections.Generic;

namespace SEP_CRUD.Generator.Base
{
    public abstract class ClassGenerator : FileGenerator
    {
        public List<string> Namespaces = new List<string>();
        public ProjectGenerator ProjectOwner { get; set; }
        public string Namespace {
            get {
                string ns = "";
                int count = Namespaces.Count;
                for(int i = 0; i < count;i++)
                {
                    if (i != 0) ns += ".";
                    ns += Namespaces[i];
                }
                return ns;
            }
        }
        public ClassGenerator(ProjectGenerator p, string name)
        {
            ProjectOwner = p;
            this.name = name;
            this.Namespaces.Add(p.Name);
        }

        public override string GetFileName()
        {
            return name + ".cs";
        }

        public override string GetRelativePath()
        {
            string path = "";
            int count = Namespaces.Count;
            for(int i = 0; i < count; i++)
            {
                if (i != 0) path += "/";
                path += Namespaces[i];
            }
            return path;
        }
    }
}
