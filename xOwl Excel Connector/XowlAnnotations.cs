using System;

namespace xOwl_Annotations
{
    public class BusinessClass : Attribute
    {
        public string BaseUri { get; set; }

        public bool IsComplex { get; set; }
        //TODO: Position is mandatory in case of complex mapping
        public string Position { get; set; }
        public BusinessClass()
        {
            this.IsComplex = false;
        }
    }

    //TODO: eventually add other presentation properties: Color, Font, etc.
    public class CellConfiguration : Attribute
    {
        public int CellsAfter { get; set; }
        public int CellSpan { get; set; }
        //TODO: use template language instead; position is mandatory in case of complex mapping
        public int[] Position { get; set; }

        public CellConfiguration()
        {
            this.CellsAfter = 0;
            this.CellSpan = 1;
        }
    }
}
