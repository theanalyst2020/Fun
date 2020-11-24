using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fun.Models
{
    public class store
    {
        public int StoreID { get; set; }
        public int PhoneNumber { get; set; }
        public int ManagerName { get; set; }
        enum Locations { 
            Shuaibah,
            Agabiya,
            Maqam,
            Muwaiji
        }
    }
}
