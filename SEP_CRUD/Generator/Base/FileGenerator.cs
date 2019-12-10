using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Generator.Base
{
    public abstract class FileGenerator : Generator
    {

        public abstract string GetFileName();

        public abstract string GetRelativePath();

        public abstract string ToSourceCode();

        public virtual Result ExportTo(string path)
        {
            return WriteToFile(path);
        }

        public Result WriteToFile(string rootPath)
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
