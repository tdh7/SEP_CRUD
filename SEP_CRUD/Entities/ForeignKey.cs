using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Entities
{
    public class ForeignKey : DatabaseProperty
    {
        private int count = 0;
        public int Count
        {
            get { return count; }
        }
        public List<Column> SrcColumns = new List<Column>();
        public List<Column> DestColumns = new List<Column>();
        public void Add(Column src, Column dest)
        {
            if (src != null && dest != null)
            {
                count++;
                SrcColumns.Add(src);
                DestColumns.Add(dest);
            }
        }

        public void Clear()
        {
            SrcColumns.Clear();
            DestColumns.Clear();
        }

        public Column FindDestColumnBySrcColumnId(int id)
        {
            for( int i = 0; i < count; i++)
                if(SrcColumns[i].Id == id)
                {
                    return DestColumns[i];
                }
            return null;
        }

        public Column FindDestColumnBySrcColumn(Column column)
        {
            return FindDestColumnBySrcColumnId(column.Id);
        }

        public Column this[Column src]
        {
            get
            {
                return FindDestColumnBySrcColumn(src);
            }

        }

        public Column this[int srcId]
        {
            get
            {
                return FindDestColumnBySrcColumnId(srcId);
            }
        }
    }
}
