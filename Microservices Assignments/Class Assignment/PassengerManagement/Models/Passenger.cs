using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassengerManagement.Models
{
    public class Passenger 
    {
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string PickupLocation { get; set; }

    }
}