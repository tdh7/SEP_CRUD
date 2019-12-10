using SEP_CRUD.Generator.Base;
using System.Collections.Generic;

namespace SEP_CRUD.Generator.Project
{
    public class SolutionGenerator : FileGenerator
    {
        List<ProjectGenerator> projectList = new List<ProjectGenerator>();
        public void addProject(ProjectGenerator project)
        {
            projectList.Add(project);
        }

        public void SetStartupProject(int position)
        {

        }

        public readonly string solutionName;

        public SolutionGenerator(string solutionName)
        {
            this.solutionName = solutionName;
        }

        public override string GetFileName()
        {
            return solutionName+".sln";
        }

        public override string GetRelativePath()
        {
            return "";
        }

        public override string ToSourceCode()
        {
            return Util.GetTextFromAsset(Constant.Constant.SOLUTION_TEMPLATE);
        }

        public override Result ExportTo(string path)
        {
            Result result = WriteToFile(path);
            if (!result.GetResult()) return result;

            int n = projectList.Count;
            for(int i =0;i < n;i++)
            {
                result = projectList[i].ExportTo(path);
                if (!result.GetResult()) return Result.Create("Error when exporting project "+projectList[i].GetFileName());
            }
            return Result.Create(true);
        }
    }
}
