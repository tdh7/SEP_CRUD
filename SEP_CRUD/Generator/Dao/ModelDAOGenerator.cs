using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Entity;
namespace SEP_CRUD.Generator.Dao
{
    class ModelDAOGenerator : ClassGenerator
    {
        public ModelDAOGenerator(ProjectGenerator p, Table t) : base(p, $"{t.BindingName}DAO")
        {
            Namespaces.Add("DAO");
            this.Table = t;
        }

        public Table Table { get; }

        public override string ToSourceCode()
        {
            var template = new ModelDAOTemplate();
            template.Generator = this;
            template.Table = Table;
            return template.TransformText();
        }
    }
}
