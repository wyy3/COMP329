using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP329_Milestone3
{
    public class Room
    {
        public decimal RoomTypeID { get; set; }
        public string RName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal AID { get; set; }

        public string CheckInDate { get; set; }
        public string AName { get; set; }
    }
}
