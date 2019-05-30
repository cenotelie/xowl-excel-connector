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
        public string uuid { get; }

        public Identifiable()
        {
            this.uuid = System.Guid.NewGuid().ToString();
        }

        public string ToJsonLD()
        {
            StringBuilder sb = new StringBuilder();
            /*
            sb.Append("{ \"@id\":\"http://xowl.org/requirement#");
            sb.Append(this.uuid);
            sb.Append("\", \"http://xowl.org/requirement#id\":\"");
            sb.Append(this.id);
            sb.Append("\", \"http://xowl.org/requirement#title\":\"");
            sb.Append(this.title);
            sb.Append("\", \"http://xowl.org/requirement#description\":\"");
            sb.Append(this.description);
            sb.Append("\"}");
            */
            string baseUri;
            var businessClass = this.GetType().GetCustomAttribute(typeof(BusinessClass));
            if (businessClass != null)
            {
                baseUri = ((BusinessClass)businessClass).baseUri;
            } else
            {
                baseUri = "http://xowl.org/freetype#";
            }
            PropertyInfo[] properties = this.GetType().GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            int count = properties.Length;
            sb.Append("{");
            sb.Append($"\"@id\":\"{baseUri}");
            sb.Append(this.uuid);
            sb.Append("\",");
            for (int i = 1; i < count; i++)
            {
                PropertyInfo property = properties[i];
                string name = property.Name.ToLower();
                string value = property.GetValue(this).ToString();
                string type = property.PropertyType.Name;
                if (type.Equals("String"))
                {
                    sb.Append($"\"{baseUri}{name}\":\"{value}\"");
                } else
                {
                    sb.Append($"\"{baseUri}{name}\":{value}");
                }
                if (i == count - 1)
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
