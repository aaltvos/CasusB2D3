using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Login;

namespace TechnoBackend.Controllers
{
    public class SessionCheckController : ApiController
    {
        // GET: api/SessionCheck
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse("Log opnieuw in"); 
        }

        // GET: api/SessionCheck/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SessionCheck
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SessionCheck/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SessionCheck/5
        public void Delete(int id)
        {
        }
    }
}
