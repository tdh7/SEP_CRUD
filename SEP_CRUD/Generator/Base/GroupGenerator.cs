using System;
using System.Collections.Generic;

namespace SEP_CRUD.Generator.Base
{
    public abstract class GroupGenerator<T>  : FileGenerator where T : FileGenerator
    {
      
        public List<T> generatorList = new List<T>();

        public override int Count
        {
            get { return generatorList.Count; }
        }

        public T this[int i]
        {
            get { return generatorList[i]; }
            set { generatorList[i] = value; }
        }

        public void Add(T generator)
        {
            generatorList.Add(generator);
        }

        public void Clear()
        {
            generatorList.Clear();
        }

        public T Get(int i)
        {
            return generatorList[i];
        }

        public virtual bool HasContent()
        {
            return true;
        }

        public override FileGenerator GetItem(int position)
        {
            return this[position];
        }

        public override Result ExportToFiles(string path)
        {
            Result result;

            if (HasContent())
            {
                result = WriteToFile(path);
                if (!result.GetResult()) return result;
            }

            int n = generatorList.Count;
            for (int i = 0; i < n; i++)
            {
                result = generatorList[i].ExportToFiles(path);
                if (!result.GetResult()) return Result.Create("Error when trying to export item " + generatorList[i].GetFileName());
            }
            return Result.Create(true);
        }
    }
}
