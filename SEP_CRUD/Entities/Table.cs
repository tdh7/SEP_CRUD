using System.Collections;
using System.Collections.Generic;

namespace SEP_CRUD.Entities
{
    public class Table : DatabaseProperty, IEnumerator<Column>
    {
        private List<Column> ColumnIds = new List<Column>();
        public PrimaryKey PrimaryKey { get; } = new PrimaryKey();
        public void Add(Column col)
        {
            ColumnIds.Add(col);
        }

        public int Count
        {
            get
            {
                return ColumnIds.Count;
            }
        }

        public Column this[int i]
        {
            get { return ColumnIds[i]; }
            set { ColumnIds[i] = value; }
        }

        public void Clear()
        {
            ColumnIds.Clear();
        }

        public void Dispose()
        {
        }

        private int position = 0;

        public bool MoveNext()
        {
            position++;
            return (position < Count);
        }

        public void Reset()
        {
            position = 0;
        }

        public object Current
        {
            get { return this[position]; }
        }

        Column IEnumerator<Column>.Current => this[position];

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
