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
        public double Priority { get; set; }
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
        [CellConfiguration(Position = new int[] { 10, 5 })]
        public double ChargeArret { get; set; }
        [CellConfiguration(Position = new int[] { 11, 5 })]
        public double ChargeNominaleExtenstion { get; set; }
        [CellConfiguration(Position = new int[] { 12, 5 })]
        public double ChargeNominaleRetraction { get; set; }
        [CellConfiguration(Position = new int[] { 13, 5 })]
        public double CourseButeeExtension { get; set; }
        [CellConfiguration(Position = new int[] { 14, 5 })]
        public double CourseButeeRetraction { get; set; }
    }
}
