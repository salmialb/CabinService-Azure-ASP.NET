using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj2.Models
{
    public class Reservation
    {
     
        public string serviceType { get; set; }
        public string cabin { get; set; }
        public string datum { get; set; }
        public string booker { get; set; }
        public int ID { get; set; }
    }
}
