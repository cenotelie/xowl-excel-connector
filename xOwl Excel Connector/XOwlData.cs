using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using xOwl_Annotations;


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
        public string uuid { get; set; }

        public string ToJsonLD()
        {
            StringBuilder sb = new StringBuilder();
            Type type = this.GetType();
            string className = type.Name;
            string baseUri = XowlUtils.GetBaseUri(type);
            PropertyInfo[] properties = this.GetType().GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            sb.Append("{");
            sb.Append($"\"@id\":\"{baseUri}");
            sb.Append(this.uuid);
            sb.Append("\", \"@type\":\"");
            sb.Append(baseUri + className);
            sb.Append("\",");
            for (int i = 1; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];
                string name = property.Name.ToLower();
                string value = property.GetValue(this).ToString();
                string typeName = property.PropertyType.Name;
                if (typeName.Equals("String"))
                {
                    sb.Append($"\"{baseUri}{name}\":\"{value}\"");
                } else
                {
                    sb.Append($"\"{baseUri}{name}\":{value}");
                }
                if (i == properties.Length - 1)
                {
                    sb.Append("}");
                } else
                {
                    sb.Append(",");
                }
            }
            return sb.ToString();
        }
    }

}
