using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities
{
    internal class Coachs
    {
        public int CId { get; set; }          
        public string CName { get; set; }     
        public string CGen { get; set; }      
        public DateTime CDOB { get; set; }   
        public string CPhone { get; set; }    
        public string CExperience { get; set; } 
        public string CAddress { get; set; }  

       
        public Coachs() { }
    }
}
