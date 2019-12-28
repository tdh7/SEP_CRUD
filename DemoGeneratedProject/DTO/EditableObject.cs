using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace DemoGeneratedProject.DTO
{
    public class EditableObject: IEditableObject
    {
        private Hashtable _properties = new Hashtable(16);

        public void BeginEdit()
        {
            if (! _properties.isEmpty())
            {
                return;
            }

            PropertyInfo[] properties = (this.GetType()).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            for (int i = 0; i < properties.Length; i++)
            {
                //check if there is set accessor
                if (null != properties[i].GetSetMethod())
                {
                    object value = properties[i].GetValue(this, null);
                    _properties.Add(properties[i].Name, value);
                }
            }
        }

        public void EndEdit()
        {
            _properties.Clear();
        }

        public void CancelEdit()
        {
            if (_properties.isEmpty())
                return;

            //restore old values
            PropertyInfo[] properties = (this.GetType())
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);

            for (int i = 0; i < properties.Length; i++)
            {
                //check if there is set accessor
                if (null != properties[i].GetSetMethod())
                {
                    object value = _properties[properties[i].Name];
                    properties[i].SetValue(this, value, null);
                }
            }

            //delete current values            
            _properties.Clear();
        }
    }
}
