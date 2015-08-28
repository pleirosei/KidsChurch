using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsChurch.Models
{
    public enum BibleBrought
    {
        YES, NO
    }
    public class Bible
    {
        public int ID { get; set; }
        public int childID { get; set; }
        public BibleBrought? bibleBrought { get; set; }

        public virtual Child children { get; set; }
    }
}