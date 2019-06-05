using System;
using System.Linq;
using System.Reflection;
using System.Text;


namespace xOwl_Excel_Connector
{
    public class Artifact
    {
        public string type { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        private string _base;

        public string Base
        {
            get
            {
                return this._base;
            }
            set
            {
                this._base = value;
            }
        }

        public string version { get; set; }
        public string from { get; set; }
        public string creation { get; set; }
        public string archetype { get; set; }
        public string superseded { get; set; }

        public string supersededDisplay
        {
            get
            {
                return this.name + " [" + this.version + "]";
            }
        }

    }

    public abstract class Identifiable
    {
        public string UUID { get; set; }

        public string ToJsonLD()
        {
            StringBuilder sb = new StringBuilder();
            Type type = this.GetType();
            string className = type.Name;
            string baseUri = XowlUtils.GetBaseUri(type);
            PropertyInfo[] properties = this.GetType().GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            sb.Append("{");
            sb.Append($"\"@id\":\"{baseUri}");
            sb.Append(this.UUID);
            sb.Append("\", \"@type\":\"");
            sb.Append(baseUri + className);
            sb.Append("\",");
            PropertyInfo property;
            Type propertyType;
            for (int i = 1; i < properties.Length; i++)
            {
                property = properties[i];
                propertyType = property.PropertyType;
                string name = property.Name.ToLower();
                string value = property.GetValue(this).ToString();
                string typeName = property.PropertyType.Name;
                if (typeName.Equals("Double"))
                {
                    value = value.Replace(',', '.');
                }
                if (typeName.Equals("String"))
                {
                    sb.Append($"\"{baseUri}{name}\":\"{value}\"");
                }
                else
                {
                    sb.Append($"\"{baseUri}{name}\":{value}");
                }
                if (i == properties.Length - 1)
                {
                    sb.Append("}");
                }
                else
                {
                    sb.Append(",");
                }
            }
            return sb.ToString();
        }
    }

}
