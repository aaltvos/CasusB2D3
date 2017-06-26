using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.NewProduct
{
    public class SendEmail
    {
        public HttpStatusCode SendNewEmail(HttpActionContext actionContext)
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                return HttpStatusCode.OK;
            }
        }
    }
}