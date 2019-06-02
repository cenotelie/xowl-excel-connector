using System;

namespace xOwl_Annotations
{
    public class BusinessClass : Attribute
    {
        public string baseUri { get; set; }
    }

    //TODO: eventually add other presentation properties: Color, Font, etc.
    public class CellConfiguration : Attribute
    {
        public int cellsAfter { get; set; }
        public int cellSpan { get; set; }

        public CellConfiguration()
        {
            this.cellsAfter = 0;
            this.cellSpan = 1;
        }
    }
}
