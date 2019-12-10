using SEP_CRUD.Generator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Generator.Project
{
    public class ProjectGenerator : FileGenerator
    {
        
        private List<FileGenerator> fileList = new List<FileGenerator>();

        public void AddFile(FileGenerator file)
        {
            fileList.Add(file);
        }
        public readonly string projectName;
        private ProjectGenerator(string name)
        {
            projectName = name;
        }

        public static ProjectGenerator CreateEmptyProject(string name)
        {
            ProjectGenerator p = new ProjectGenerator(name);
            return p;
        }

        public override string GetFileName()
        {
            return projectName + ".csproj";
        }

        public override string GetRelativePath()
        {
            return projectName;
        }

        public override string ToSourceCode()
        {
            return "This is project files.";
        }
    }
}
