using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xOwl_Annotations
{
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
