using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DemoGeneratedProject.Forms
{
	public class ViewFormFactory
	{
        private static ViewFormFactory sFactory;
        public static ViewFormFactory Instance
        {
            get
            {
                if (sFactory == null)
                {
                    sFactory = new ViewFormFactory();
                }
                return sFactory;
            }
        }

        private ViewFormFactory()
        {
        }

        public enum GeneratedForm : int
        {
            None = -1,
            Thamgiadt = 0,
            Khoa = 1,
            Bomon = 2,
            Chude = 3
        }

        public List<string> BindingNames { get; } = new List<string>
        {

        };

        public List<string> DatabaseNames { get; } = new List<string>
        {

        };

        public int Count
        {
            get
            {
                return BindingNames.Count;
            }
        }

        
        public Form FindForm(GeneratedForm f)
		{
            switch(f)
            {
                /*
                case GeneratedForm.ViewThamgiadtForm:
                    return new ViewThamgiadtForm();

                case GeneratedForm.ViewKhoaForm:
                    return new ViewKhoaForm();

                case GeneratedForm.ViewBomonForm:
                    return new ViewBomonForm();

                case GeneratedForm.ViewChudeForm:
                    return new ViewChudeForm();
                    */

                case GeneratedForm.None:
                default:
                    return null;
            }
		}

        public GeneratedForm FindFormTypeByBindingName(string name)
        {
            if (name == null) return GeneratedForm.None;

            int index = -1;
            for (int i=0;i < Count; i++) {
                if(name.Equals(BindingNames[i]))
                {
                    index = i;
                    break;
                }
            }
            return (GeneratedForm)index;
        }

        public GeneratedForm FindFormTypeByDatabaseName(string name)
        {
            if (name == null) return GeneratedForm.None;

            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (name.Equals(DatabaseNames[i]))
                {
                    index = i;
                    break;
                }
            }
            return (GeneratedForm)index;
        }

        
        public Form FindFormByBindingName(string name)
        {
            return FindForm(FindFormTypeByBindingName(name));
        }

        public Form FindFormByDatabaseName(string name)
        {
            return FindForm(FindFormTypeByDatabaseName(name));
        }
        
	}
}

