using SEP_CRUD.Generator.Base;
using SEP_CRUD.Template.Project;
using System;

namespace SEP_CRUD.Generator.Project
{
    public class MustHaveGroupGenerator : GroupGenerator<FileGenerator>
    {
        private MustHaveGroupGenerator()
        {

        }

        public static MustHaveGroupGenerator NewInstance(ProjectGenerator p)
        {
            MustHaveGroupGenerator g = new MustHaveGroupGenerator();
            g.Add(new QuickFileGenerator("Program")
            {
                RelativePath = p.GetRelativePath(),
                SourceCode = new ProgramTemplate(p).TransformText()
            });

            g.Add(new QuickFileGenerator("Settings","Settings.Designer.cs")
            {
                RelativePath = p.GetRelativePath() + "/Properties",
                SourceCode = new SettingDesignerTemplate().TransformText()
            });

            g.Add(new QuickFileGenerator("AssemblyInfo")
            {
                RelativePath = p.GetRelativePath() + "/Properties",
                SourceCode = new AssemblyInfoTemplate(p).TransformText()
            });

            g.Add(new QuickFileGenerator("Settings", "Settings.settings")
            {
                RelativePath = p.GetRelativePath() + "/Properties",
                SourceCode = new SettingTemplate().TransformText()
            });
            return g;
        }

        public override bool HasContent()
        {
            return false;
        }

        public override string GetFileName()
        {
            return "MustHaveGroup";
        }

        public override string GetRelativePath()
        {
            return "";
        }

        public override string ToSourceCode()
        {
            return "";
        }
    }
}
