using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Web.Http;
using System.Web.WebPages;
using TechnoBackend.Business_Logic.CategoryBeheren;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Login;

namespace TechnoBackend.Controllers
{
    public class CategoryBeherenController : ApiController
    {

        // POST api/<controller>
        public HttpStatusCode Post()
        {
            return CreateCategory.AddCategory(ActionContext);
        }


        // DELETE api/<controller>/5
        public HttpStatusCode Delete(int catid)
        {
            try
            {
                var message = DeleteCategory.DelCategory(catid);
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