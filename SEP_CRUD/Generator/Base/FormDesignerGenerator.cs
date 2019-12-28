namespace SEP_CRUD.Generator.Base
{
    public abstract class FormDesignerGenerator : ClassGenerator
    {
        FormGenerator Owner;
        public FormDesignerGenerator(FormGenerator owner) : base(owner.ProjectOwner,owner.Name)
        {
            Owner = owner;
        }

        public override string GetFileName()
        {
            return Owner.Name + ".Designer.cs";
        }
    }
}
