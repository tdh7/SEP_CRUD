namespace SEP_CRUD.Entities
{
    public abstract class DatabaseProperty
    {
        public int Id { get; } = Util.NextId;
        public string DatabaseName { get; set; }
        public string BindingName { get; set; }

        public string EntitiesDatabaseName
        {
            get
            {
                return Entities.Instance.DatabaseName;
            }
        }

        public string EntitiesBindingName
        {
            get
            {
                return Entities.Instance.BindingName;
            }
        }
    }
}
