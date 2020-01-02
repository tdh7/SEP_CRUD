using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Entity;

namespace SEP_CRUD.Generator.Base
{
    public class QuickClassGenerator : ClassGenerator
    {
        public ClassTemplate ClassTemplate { get; }
        public QuickClassGenerator(ProjectGenerator p, string name, ClassTemplate template) : base(p, name)
        {
            ClassTemplate = template;
        }

        public override string ToSourceCode()
        {
            return ClassTemplate.TransformText();
        }
    }
}
