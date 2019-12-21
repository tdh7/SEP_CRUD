using System;
using System.IO;

namespace SEP_CRUD.Generator.Base
{
    public abstract class FileGenerator : Generator
    {
        protected string name = "";
        public string Name
        {
            get { return name; }
        }

        public abstract string GetFileName();

        public abstract string GetRelativePath();

        public abstract string ToSourceCode();

        public string RegisterToProject()
        {
            return string.Empty;
        }

        public virtual Result ExportToFiles(string path)
        {
            return WriteToFile(path);
        }

        public string GetRelativeFilePath()
        {
            return GetRelativePath() + "/" + GetFileName();
        }

        public virtual int Count
        {
            get { return 0; }
        }

        public virtual FileGenerator GetItem(int position)
        {
            return this;
        }

        public virtual Result WriteToFile(string rootPath)
        {

            string content = ToSourceCode();
            if (content.Length == 0) return Result.Create("Generated Source Code is empty");

            string relativePath = GetRelativePath();
            if (relativePath == null) return Result.Create("Relative Path is null");
            if (rootPath == null) return Result.Create("Root Path is null");

            string fileName = GetFileName();
            if (fileName == null || fileName.Length == 0) return Result.Create("File Name is null or empty");

            string path = Path.GetFullPath(Path.Combine(rootPath, relativePath));

       

            // create new directory if not existed
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (path.EndsWith("/")) path += fileName;
            else path += '/' + fileName;


            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {

                    writer.Write(content);
                    writer.Close();
                }
            } catch(Exception e)
            {
                return Result.Create("Exception : " + e.Message);
            }

            return Result.Create(true);
        }
    }
}
