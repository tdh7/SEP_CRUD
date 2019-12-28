using System.Collections.Generic;

namespace SEP_CRUD.Entities
{
    public class PrimaryKey : DatabaseProperty
    {
        public List<Column> Columns = new List<Column>();
        public void Add(Column col)
        {
            Columns.Add(col);
        }

        public bool HasColumn(Column c)
        {
            return Columns.Contains(c);
        }

        public Column this[int i]
        {
            get { return Columns[i]; }
            set { Columns[i] = value; }
        }

        public int Count => Columns.Count;

        public void Clear()
        {
            Columns.Clear();
        }
    }
}
