using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xOwl_Excel_Connector;

namespace BusinessData
{
    public class Requirement : Identifiable
    {
        public string title { get; set; }
        public string description { get; set; }

        public override string ToJsonLD()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ \"@id\":\"http://xowl.org/requirement#");
            sb.Append(this.identifier);
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
        public override string ToJsonLD()
        {
            throw new NotImplementedException();
        }
    }
}
