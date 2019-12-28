using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Entity;

namespace SEP_CRUD.Generator.Model
{
    public class ModelGenerator : ClassGenerator
    {
        public Table Table { get; }
        public ModelGenerator(Table table, ProjectGenerator p) : base(p, table.BindingName)
        {
            Table = table;
            Namespaces.Add(p.DefaultModelNamespace);
        }

        public override string ToSourceCode()
        {
            return new ModelTemplate(this).TransformText();
        }
    }
}
