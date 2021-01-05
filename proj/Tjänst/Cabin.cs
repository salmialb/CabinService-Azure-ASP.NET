using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tjänst

{
    public class Cabin
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public Boolean beds { get; set; }
        public Boolean sauna { get; set; }
        public Boolean beach { get; set; }
    }
}
