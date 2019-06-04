using xOwl_Annotations;
using xOwl_Excel_Connector;

namespace BusinessData
{
    [BusinessClass(BaseUri = "http://xowl.org/requirement#")]
    public class Requirement : Identifiable
    {
        [CellConfiguration(CellsAfter = 1)]
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    [BusinessClass(BaseUri = "http://xowl.org/function#")]
    public class Function : Identifiable
    {
        public string Name { get; set; }

        public int Priority { get; set; }
    }

    [BusinessClass(BaseUri = "http://xowl.org/components#")]
    public class Component : Identifiable
    {
        [CellConfiguration(CellsAfter = 2)]
        public string Name { get; set; }

        public int Complexity { get; set; }
    }

    [BusinessClass(BaseUri = "http://xowl.org/specparam#", IsComplex = true, Position = "Paramètre spec")]
    public class SpecParameter : Identifiable
    {
        [CellConfiguration(Position = new int[] { 5, 10 })]
        public double ChargeArret { get; set; }
        [CellConfiguration(Position = new int[] { 5, 11 })]
        public double ChargeNominaleExtenstion { get; set; }
        [CellConfiguration(Position = new int[] { 5, 12 })]
        public double ChargeNominaleRetraction { get; set; }
        [CellConfiguration(Position = new int[] { 5, 13 })]
        public double CourseButeeExtension { get; set; }
        [CellConfiguration(Position = new int[] { 5, 14 })]
        public double CourseButeeRetraction { get; set; }
    }
}
