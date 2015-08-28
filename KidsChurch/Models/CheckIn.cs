using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsChurch.Models
{
    public enum CheckedIn
    {
        YES, NO
    }

    public class CheckIn
    {
        public int ID { get; set; }
        public int ChildID { get; set; }
        public CheckedIn? checkedIn { get; set; }

        public virtual Child child { get; set; }
    }
}