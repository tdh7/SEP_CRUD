using SEP_CRUD.Entities.Loader;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Form;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Entity;
using System;

namespace SEP_CRUD.Generator.Dao
{
    public class MustHaveDaoClassesGenerator : GroupGenerator<FileGenerator>
    {
        public MustHaveDaoClassesGenerator(ProjectGenerator p)
        {
            string ns = p.Name + ".DAO";

            Add(new QuickClassGenerator(p, "Result",new ResultTemplate(ns)).AddToNamespace("DAO"));
            Add(new DatabaseLoaderGenerator(p).AddToNamespace("DAO"));
            Add(new ConfigControllerGenerator(p, EntitiesLoader.Instance.ConnectionString));
            Add(new ItemTableGenerator(p));
        }
        public override string GetFileName()
        {
            return "";
        }

        public override string GetRelativePath()
        {
            return "";
        }

        public override bool HasContent()
        {
            return false;
        }

        public override string ToSourceCode()
        {
            return "";
        }
    }
}
