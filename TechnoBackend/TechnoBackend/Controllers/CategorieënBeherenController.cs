using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Web.Http;
using System.Web.WebPages;
using TechnoBackend.Business_Logic.CategorieënBeheren;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Login;

namespace TechnoBackend.Controllers
{
    public class CategorieënBeherenController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST api/<controller>
        public HttpResponseMessage Post()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                var message = CreateCategory.AddCategory(ActionContext);

                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                var message = ChangeCategory.UpdateCategory(id);

                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                var message = DeleteCategory.DelCategory(id);

                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
        }
    }
}