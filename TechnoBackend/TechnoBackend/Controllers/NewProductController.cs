using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Business_Logic.NewProduct;
using TechnoBackend.Login;


namespace TechnoBackend.Controllers
{
    public class NewProductController : ApiController
    {
        // POST api/<controller>
        public HttpResponseMessage Post()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 2)
            {
                var message = CreateNewProduct.addProduct(ActionContext);
                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse(HttpStatusCode.Unauthorized);
        }
    }
}