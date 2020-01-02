using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Form;
using SEP_CRUD.Generator.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEP_CRUD.Template.Project
{
    public partial class SolutionTemplate
    {
        public SolutionGenerator generator;
        public SolutionTemplate(SolutionGenerator generator)
        {
            this.generator = generator;
        }
    }

    public partial class ProjectTemplate
    {
        public enum CompileType {
            FORM,
            USER_CLASS,
            PROGRAM_CLASS,
            SETTINGS,
            ASSEMBLY_INFO
            }
        public ProjectGenerator generator;
        public ProjectTemplate(ProjectGenerator generator)
        {
            this.generator = generator;
        }
        public List<string> GetCompileItems()
        {
            List<string> list = new List<string>();
            GetCompileItems(generator, list);
            return list;
        }

        public string NormalizeRelativeFilePath(string path)
        {
            path = path.Replace("/", "\\");
            int index = path.IndexOf("\\");

            return path.Substring(index + 1);
        }

        public string NormalizeRelativeFilePath(FileGenerator f)
        {
            return NormalizeRelativeFilePath(f.GetRelativeFilePath());
        }
        private void GetCompileItems(FileGenerator f, List<String> list)
        {
            if (f is FormGenerator)
            {
                list.Add(string.Format(@"<Compile Include=""{0}"">
      <SubType>{3}</SubType>
    </Compile>
    <Compile Include = ""{1}"" >
      <DependentUpon>{2}</DependentUpon>
    </Compile> ", NormalizeRelativeFilePath(f), NormalizeRelativeFilePath(f.GetItem(0)), f.GetFileName(),((FormGenerator)f).SubType));
            }
            else if (f is ClassGenerator)
            {
                list.Add(string.Format(@"<Compile Include=""{0}"" />", NormalizeRelativeFilePath(f)));
            }
            else if (f is QuickFileGenerator)
            {
                switch (f.Name)
                {
                    case "AssemblyInfo":
                    case "Program":
                        list.Add(string.Format(@"<Compile Include=""{0}"" />", NormalizeRelativeFilePath(f)));
                        break;
                    case "Settings":
                        list.Add(string.Format(@"<None Include=""{0}"">
  <Generator>SettingsSingleFileGenerator</Generator>
  <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include = ""{1}"" >
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>", NormalizeRelativeFilePath(f), NormalizeRelativeFilePath(f.GetRelativePath()+"/"+f.Name+ ".Designer.cs")));
                        break;
                }
            }
            else
            {
                int count = f.Count;
                for (int i = 0; i < count; i++)
                {
                    GetCompileItems(f.GetItem(i),list);
                }
            }
        }
    }

    public partial class ProgramTemplate
    {
        public ProjectGenerator generator;
        public ProgramTemplate(ProjectGenerator project)
        {
            this.generator = project;
        }
    }

    public partial class AssemblyInfoTemplate
    {
        public ProjectGenerator generator;
        public AssemblyInfoTemplate(ProjectGenerator generator)
        {
           
            this.generator = generator;
        }
    }
}
