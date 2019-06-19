using System;
using System.Linq;
using System.Reflection;
using System.Text;


namespace xOwl_Excel_Connector
{
    public class Artifact
    {
        public string Type { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string Base { get; set; }
        public string Version { get; set; }
        public string From { get; set; }
        public string Creation { get; set; }
        public string Archetype { get; set; }
        public string Superseded { get; set; }
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
                if (typeName.Equals("Boolean"))
                {
                    if (value.Equals("True"))
                    {
                        value = "true";
                    }
                    else
                    {
                        value = "false";
                    }
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
