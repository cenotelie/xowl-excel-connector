using xOwl_Annotations;
using xOwl_Excel_Connector;

namespace BusinessData
{
    [BusinessClass(baseUri = "http://xowl.org/requirement#")]
    public class Requirement : Identifiable
    {
        [CellConfiguration(cellsAfter = 1)]
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    [BusinessClass(baseUri = "http://xowl.org/function#")]
    public class Function : Identifiable
    {
        public string Name { get; set; }

        public int Priority { get; set; }
    }

    [BusinessClass(baseUri = "http://xowl.org/components#")]
    public class Component : Identifiable
    {
        [CellConfiguration(cellsAfter = 2)]
        public string Name { get; set; }

        public int Complexity { get; set; }
    }
}
