using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment_1.Models;

namespace Assignment_1.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        static List<Country> countrylist = new List<Country>()
        {
            new Country{Id=1, CountryName="India", Capital="New Delhi"},
            new Country{Id=2, CountryName="Pakisthan", Capital="Islamabad"},
            new Country{Id=3, CountryName="Srilanka", Capital="Colombo"},
            new Country{Id=4, CountryName="USA", Capital="Washington"},
        };

        [HttpGet]
        [Route("countrydetails")]

        public IEnumerable<Country> Get()
        {
            return countrylist;
        }

        [HttpGet]
        [Route("countrylist")]

        public HttpResponseMessage GetCountrylist()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, countrylist);
            return response;
        }

        [HttpGet]
        [Route("c")]
        public HttpResponseMessage GetP(int cid)
        {
            var country = countrylist.Find(x => x.Id == cid);      

                if (country == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, cid);
                }
                return Request.CreateResponse(HttpStatusCode.OK, country);
            }

            //POST
            public Country Post([FromBody] Country c)
            {
                countrylist.Add(c);
                return c;
            }

            //PUT
            public IEnumerable<Country> Put(int id, [FromBody] Country country)
            {
                countrylist[id - 1] = country;
                return countrylist;
            }

            [HttpGet]
            [Route("ById")]
            public IHttpActionResult GetID(int cid)
            {
                var country = countrylist.Find(x => x.Id == cid);

                if (country == null)
                {
                    return NotFound();
                }
                return Ok(country);
            }

            [HttpGet]
            [Route("Name")]
            public IHttpActionResult GetName(int cid)
            {
                string country = countrylist.Where(x => x.Id == cid).SingleOrDefault()?.CountryName;

                if (country == null)
                {
                    return NotFound();
                }
                return Ok(country);
            
        }
    }
    }
