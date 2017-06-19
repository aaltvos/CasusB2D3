using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Login;

namespace TechnoBackend.Controllers
{
    public class AuthenticationController : ApiController
    {
        public HttpResponseMessage Post()
        {
            if (AuthenticationAttribute.Authent(ActionContext) != "Unauthorized")
            {
                var response = Request.CreateResponse(HttpStatusCode.OK);
                response.Headers.Add("Token", AuthenticationAttribute.Authent(ActionContext));

                return response;
            }

            else { return Request.CreateResponse(HttpStatusCode.Unauthorized); }
        }

        // GET: api/Authentication/5
        public string Get(int id)
        {

            return "value";
        }


        // PUT: api/Authentication/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Authentication/5
        public void Delete(int id)
        {
        }
    }
}