namespace SEP_CRUD.Generator.Base
{
    public abstract class FormDesignerGenerator<T> : ClassGenerator where T : FormGenerator
    {
        protected T Owner;
        public FormDesignerGenerator(T owner) : base(owner.ProjectOwner,owner.Name)
        {
            Owner = owner;
        }

        public override string GetFileName()
        {
            return Owner.Name + ".Designer.cs";
        }
    }
}
