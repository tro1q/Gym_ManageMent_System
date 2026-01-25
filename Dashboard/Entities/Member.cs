using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entits
{
    internal class Member
    {

        public int MId { get; set; }         
        public string MName { get; set; }      
        public string MGen { get; set; }       
        public DateTime MDOB { get; set; }     
        public DateTime MJDate { get; set; }  
        public int MMembership { get; set; }  
        public int MCoach { get; set; }        
        public string MPhone { get; set; }     
        public string MTiming { get; set; }    
        public string MStatus { get; set; }   
        public bool IsDeleted { get; set; }    

        
        public Member() { }

    }
}
