using SEP_CRUD.Entities.Loader;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Helper.NameConvention;
using System.Collections.Generic;

namespace SEP_CRUD.Entities
{
    public class Entities : DatabaseProperty
    {
        private static Entities sInstance = null;
        public static Entities Instance
        {
            get
            {
                if (sInstance == null)
                {
                    sInstance = new Entities();
                }
                return sInstance;
            }
        }

        private Entities()
        {
        }

        public Dictionary<int,Table> Tables = new Dictionary<int, Table>();
        public Dictionary<int, Column> Columns = new Dictionary<int, Column>();
        public Dictionary<int, PrimaryKey> PrimaryKeys = new Dictionary<int, PrimaryKey>();
        public Dictionary<int, ForeignKey> ForeignKeys = new Dictionary<int, ForeignKey>();
    
        public Result UpdateData()
        {
            return EntitiesLoader.Instance.LoadData(this);
        }

        public void Add<T>(T t) where T : DatabaseProperty
        {
            if (t is Table)
                Tables.Add(t.Id, t as Table);
            else if (t is Column)
                Columns.Add(t.Id, t as Column);
            else if (t is PrimaryKey)
                PrimaryKeys.Add(t.Id, t as PrimaryKey);
            else if (t is ForeignKey)
                ForeignKeys.Add(t.Id, t as ForeignKey);
        }
        
        public void Clear()
        {
            Tables.Clear();
            Columns.Clear();
            PrimaryKeys.Clear();
            ForeignKeys.Clear();
        }

        private NameConvention nameConvention = new PascalCaseConvention();
        public NameConvention NameConvention
        {
            get
            {
                return nameConvention;
            }
            set
            {
                if (value != null) nameConvention = value;
            }
        }
    }
}
