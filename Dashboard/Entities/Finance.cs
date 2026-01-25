using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities
{
    internal class Finance
    {

        public int FinanceId { get; set; }    
        public int MemberId { get; set; }     
        public int AgentId { get; set; }      
        public decimal Amount { get; set; }    
        public DateTime PaymentDate { get; set; } 
        public string PaymentMethod { get; set; }
        public Finance() { }

    }
}
