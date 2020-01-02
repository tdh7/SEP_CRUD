using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Form;

namespace SEP_CRUD.Generator.Form
{
    public class ItemTableDesignerGenerator : FormDesignerGenerator<ItemTableGenerator>
    {
        public ItemTableDesignerGenerator(ItemTableGenerator owner) : base(owner)
        {
        }

        public override string ToSourceCode()
        {
            SharedFormDesignerTemplate t = new ItemTableDesignerTemplate();
            t.Generator = this;
            return t.TransformText();
        }
    }
}
