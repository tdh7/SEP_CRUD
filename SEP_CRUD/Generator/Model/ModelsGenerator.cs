using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using System;

namespace SEP_CRUD.Generator.Model
{
    public class ModelsGenerator : GroupGenerator<ModelGenerator>
    {
        private ModelsGenerator(ProjectGenerator p)
        {
            ProjectOwner = p;
            Entities.Entities entities = Entities.Entities.Instance;
            foreach (var t in entities.Tables)
            {
                Add(new ModelGenerator(t.Value, ProjectOwner));
            }
        }
        ProjectGenerator ProjectOwner { get; }

        public static ModelsGenerator CreateInstance(ProjectGenerator p)
        {
            ModelsGenerator mgg = new ModelsGenerator(p);
            return mgg;
        }

        public override string GetFileName()
        {
            return "";
        }

        public override string GetRelativePath()
        {
            return "";
        }

        public override string ToSourceCode()
        {
            return "";
        }

        public override bool HasContent()
        {
            return false;
        }
    }
}
