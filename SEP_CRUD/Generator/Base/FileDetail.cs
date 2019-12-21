using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Generator.Base
{
    public class QuickFileGenerator : FileGenerator
    {
        public QuickFileGenerator(string name,string fileName, string relativePath, string sourceCode)
        {
            this.name = name;
            FileName = fileName;
            RelativePath = relativePath;
            SourceCode = sourceCode;

        }

        public QuickFileGenerator(string name)
        {
            this.name = name;
            FileName = name + ".cs";
            RelativePath = "";
            SourceCode = "";
        }

        public QuickFileGenerator(string name, string fileName)
        {
            this.name = name;
            FileName = fileName;
            RelativePath = "";
            SourceCode = "";
        }

        public string RelativePath
        {
            get;
            set;
        }

        public string FileName
        {
            get;
        }

        public override string GetFileName()
        {
            return FileName;
        }

        public override string GetRelativePath()
        {
            return RelativePath;
        }

        public string SourceCode
        {
            get;
            set;
        }

        public override string ToSourceCode()
        {
            return SourceCode;
        }
    }
}
