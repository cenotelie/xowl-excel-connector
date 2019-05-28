using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xOwl_Excel_Connector;
using xOwl_Annotations;

namespace BusinessData
{
    public class Requirement : Identifiable
    {
        [CellConfiguration(cellsAfter = 1)]
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public override string ToJsonLD()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ \"@id\":\"http://xowl.org/requirement#");
            sb.Append(this.uuid);
            sb.Append("\", \"http://xowl.org/requirement#id\":\"");
            sb.Append(this.id);
            sb.Append("\", \"http://xowl.org/requirement#title\":\"");
            sb.Append(this.title);
            sb.Append("\", \"http://xowl.org/requirement#description\":\"");
            sb.Append(this.description);
            sb.Append("\"}");
            return sb.ToString();
        }
    }

    public class Function : Identifiable
    {
        public string name { get; set; }

        public int priority { get; set; }

        public override string ToJsonLD()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ \"@id\":\"http://xowl.org/function#");
            sb.Append(this.uuid);
            sb.Append("\", \"http://xowl.org/requirement#name\":\"");
            sb.Append(this.name);
            sb.Append("\", \"http://xowl.org/requirement#priority\":");
            sb.Append(this.priority);
            sb.Append("}");
            return sb.ToString();
        }
    }
}
