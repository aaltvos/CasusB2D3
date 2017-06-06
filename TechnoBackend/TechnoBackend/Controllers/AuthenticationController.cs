using System.Collections.Generic;
using TechnoBackend.DatabaseModel;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using TechnoBackend.Login;
using System.IO;
using System.Web.Http.Controllers;
using System.Linq;

namespace TechnoBackend.Controllers
{
    public class AuthenticationController : ApiController
    { 
        public HttpResponseMessage Post()
        {
            if(AuthenticationAttribute.Authent(ActionContext) != "Unauthorized")
            {
                var response = Request.CreateResponse(HttpStatusCode.OK);
                response.Headers.Add("Token", AuthenticationAttribute.Authent(ActionContext));

                return response;
            }

            else { return Request.CreateResponse(HttpStatusCode.Unauthorized);}
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
