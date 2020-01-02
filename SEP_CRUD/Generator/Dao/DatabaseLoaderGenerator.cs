using SEP_CRUD.Entities.Loader;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Project;
using SEP_CRUD.Template.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_CRUD.Generator.Dao
{
    public class DatabaseLoaderGenerator : ClassGenerator
    {
        public DatabaseLoaderGenerator(ProjectGenerator p) : base(p,"DatabaseLoader")
        {
        }

        public override string ToSourceCode()
        {
            return new DatabaseLoaderTemplate(this).TransformText();
        }

        public string DataSource
        {
            get
            {
                return EntitiesLoader.Instance.DataSource;
            }
        }

        public string DatabaseName
        {
            get
            {
                return EntitiesLoader.Instance.DatabaseName;
            }
        }

        public string Username
        {
            get
            {
                return EntitiesLoader.Instance.Username;
            }
        }

        public string ConnectionString
        {
            get
            {
                return EntitiesLoader.Instance.ConnectionString;
            }
        }

        public string LoadTablesSqlQuery
        {
            get
            {
                return Constant.LoadTablesSqlQuery;
            }
        }

    }
}
