using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using xOwl_Excel_Connector;
using xOwl_Annotations;

namespace BusinessData
{
    [BusinessClass(baseUri = "http://xowl.org/requirement#")]
    public class Requirement : Identifiable
    {
        [CellConfiguration(cellsAfter = 1)]
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    [BusinessClass(baseUri = "http://xowl.org/function#")]
    public class Function : Identifiable
    {
        public string name { get; set; }

        public int priority { get; set; }
    }

    [BusinessClass(baseUri ="http://xowl.org/components#")]
    public class Component : Identifiable
    {
        [CellConfiguration(cellsAfter = 2)]
        public string name { get; set; }

        public int complexity { get; set; }
    }
}
