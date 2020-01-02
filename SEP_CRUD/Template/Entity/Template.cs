using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Dao;
using SEP_CRUD.Generator.Model;

namespace SEP_CRUD.Template.Entity
{
    public partial class DatabaseLoaderTemplate
    {
        protected DatabaseLoaderGenerator generator;
        public DatabaseLoaderTemplate(DatabaseLoaderGenerator g)
        {
            generator = g;
        }
    }

    public partial class ResultTemplate
    {
        protected string _namespace;
        public ResultTemplate(string _namespace)
        {
            this._namespace = _namespace;
        }
    }

    public partial class ModelTemplate
    {
        ModelGenerator generator;
        public ModelTemplate(ModelGenerator g)
        {
            generator = g;
        }
    }
    public partial class ModelTemplate2
    {
        ModelGenerator generator;
        public ModelTemplate2(ModelGenerator g)
        {
            generator = g;
        }
    }

    public partial class ModelDAOTemplate
    {
        ClassGenerator generator;
        public ClassGenerator Generator
        {
            get
            {
                return generator;
            }
            set
            {
                generator = value;
            }
        }

        public Table Table;
    }

    public partial class ConfigControllerTemplate
    {
        public ClassGenerator Generator;
        public string ConnectionString;
    }

    public partial class ModelTemplate3
    {
        ModelGenerator generator;
        public ModelTemplate3(ModelGenerator g)
        {
            generator = g;
        }
    }
}
