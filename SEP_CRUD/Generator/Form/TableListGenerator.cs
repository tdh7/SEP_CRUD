using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    class TableListGenerator : FormGenerator
    {
        public TableListGenerator(ProjectGenerator p) 
            : base(p, "TableListForm")
        {
        }

        public override ClassGenerator OnCreateFormDesignerGenerator()
        {
            return new TableListDesignerGenerator(this);
        }

        public override string ToSourceCode()
        {
            var template = new TableListFormTemplate();
            template.Generator = this;
            return template.TransformText();
        }
    }
}
