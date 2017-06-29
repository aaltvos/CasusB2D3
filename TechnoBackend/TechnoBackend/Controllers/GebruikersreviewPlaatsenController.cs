using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Business_Logic.GebruikersreviewPlaatsen;
using TechnoBackend.Login;

namespace TechnoBackend.Controllers
{
    [Route("api/GebruikersreviewPlaatsen")]
    public class GebruikersreviewPlaatsenController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult PostReview(string ReviewContent, Int32 UserID)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                GebruikersreviewPlaatsen;
            }
            throw new NotImplementedException();
        }
        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}