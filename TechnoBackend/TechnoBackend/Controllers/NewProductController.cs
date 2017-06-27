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
        public HttpStatusCode Post()
        {
            try
            {
                var message = CreateNewProduct.addProduct(ActionContext);
                var response = Request.CreateResponse(message);
                return HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}