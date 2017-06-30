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
        public HttpResponseMessage Post(string ReviewContent)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                var message = Business_Logic.GebruikersreviewPlaatsen.Review.CreateReview(token, ReviewContent);
                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
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