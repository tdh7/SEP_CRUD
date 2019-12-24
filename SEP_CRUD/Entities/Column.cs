namespace SEP_CRUD.Entities
{
    public enum MapType
    {
        PRIMITIVE,
        REFERENCE_1_1,
        REFERENCE_N_N,
    }

    public class Column : DatabaseProperty
    {
        public MapType MapType
        {
            get
            {
                if (ForeignKey == null) return MapType.PRIMITIVE;
                if (ForeignKey.Count == 1) return MapType.REFERENCE_1_1;
                else return MapType.REFERENCE_N_N;
            }
        }
        public int TableId { get; set; }
        public Table Table
        {
            get
            {
                return Entities.Instance.Tables[TableId];
            }
        }
        public string DatabaseType { get; set; }
        public string BindingType { get; set; }
        public bool Nullable { get; set; } = true;
        public ForeignKey ForeignKey { get; set; }
        public bool IsPrimaryKey { get; set; } = false;

        public Column ReferenceColumn
        {
            get
            {
                if (ForeignKey != null) return ForeignKey[this];
                return null;
            }
        }
    }
}
