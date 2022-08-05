using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using PassengerManagement.Models;


namespace CustomerServices.Controllers
{
    [System.Web.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PassengerController : System.Web.Mvc.ControllerBase
    {
        
        public IEnumerable<Passenger> Get()
        {
            Passenger p1 = new Passenger();
            Passenger p2 = new Passenger();

            p1.PassengerId = 1001;
            p1.PassengerName = "John";
            p1.PickupLocation = "NagarjunaSagar";

            p2.PassengerId = 1002;
            p2.PassengerName = "Ben";
            p2.PickupLocation = "Puttur";

            List<Passenger> plist = new List<Passenger>();
            plist.Add(p1);
            plist.Add(p2);

            return plist;
        }

        [System.Web.Mvc.HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        [System.Web.Mvc.HttpPost]
        public void Post([Microsoft.AspNetCore.Mvc.FromBody] string value)
        {
        }

        [System.Web.Mvc.HttpPut]
        public void Put(int id, [Microsoft.AspNetCore.Mvc.FromBody] string value)
        {
        }

        protected override void ExecuteCore()
        {
            throw new NotImplementedException();
        }
    }
}