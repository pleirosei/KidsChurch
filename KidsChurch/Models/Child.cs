using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsChurch.Models
{
    public class Child
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nickName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string primaryGuardian { get; set; }
        public string secondaryGuardian { get; set; }

        public virtual ICollection<CheckIn> CheckIns { get; set; } 
    }
}