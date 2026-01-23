using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities
{
    internal class MemberShip
    {

        public int MShipId { get; set; }
        public string MName { get; set; }
        public int MDuration { get; set; }
        public string MGoal { get; set; }
        public int MCost { get; set; }
    }
}
