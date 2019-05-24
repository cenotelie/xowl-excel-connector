using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xOwl_Excel_Connector
{
    public class Artifact
    {
        public string type { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        private string _base;

        public string Base
        {
            get
            {
                return this._base;
            }
            set
            {
                this._base = value;
            }
        }

        public string version { get; set; }
        public string from { get; set; }
        public string creation { get; set; }
        public string archetype { get; set; }
        public string superseded { get; set; }

    }

}
