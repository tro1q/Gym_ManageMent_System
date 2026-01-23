using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities
{
    internal class Receptionists
    {
        public int ReceptId { get; set; }
        public string RecepName { get; set; }
        public string RecepGen { get; set; }
        public DateTime RecepDOB { get; set; }
        public string RecepAdd { get; set; }
        public string RecepPhone { get; set; }
        public string RecepPass { get; set; }
    }
}
