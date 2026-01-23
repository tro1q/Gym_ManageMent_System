using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities
{
    internal class Finance
    {

        public int BillId { get; set; }
        public int Agent { get; set; }
        public int Member { get; set; }
        public string BPeriod { get; set; }
        public DateTime BDate { get; set; }
        public int BAmount { get; set; }

    }
}
