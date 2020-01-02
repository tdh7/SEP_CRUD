using SEP_CRUD.Entities;
using SEP_CRUD.Generator.Base;
using SEP_CRUD.Generator.Model;

namespace SEP_CRUD.Template.Entity
{
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

    public partial class ModelTemplate3
    {
        ModelGenerator generator;
        public ModelTemplate3(ModelGenerator g)
        {
            generator = g;
        }
    }
}
