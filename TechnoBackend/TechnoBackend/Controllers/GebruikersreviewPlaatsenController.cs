using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Login;
using TechnoBackend.Business_Logic.GebruikersreviewPlaatsen;
using TechnoBackend.DatabaseModel;
using System.Web.Security;

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
        public HttpResponseMessage Post()
        {
            DBModelContainer database = new DBModelContainer();
            {
                PRODs current = database.PRODs.Where(p => p.Prod_ID == _product.Prod_ID).First();
                if (current == null) return "{\"status\":\"Error\", \"message\":\"No WorkItem found\"}";

                USERs user = database.USERs.Where(s => s.USER_Id == session.USER_Id.USER_Id).First();
                if (user == null) return "{\"status\":\"Error\", \"message\":\"No User found\"}";

                throw new NotImplementedException();

            }
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