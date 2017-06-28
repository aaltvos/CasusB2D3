using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Business_Logic.WorkitemOpvragen;
using TechnoBackend.Login;


namespace TechnoBackend.Controllers
{
    public class WorkItemOpvragenController : ApiController
    {
        public HttpStatusCode Get()   // allemaal ophalen
        {
            {
                try
                {
                    var message = WorkitemOpvragen.GetWorkItem();             
                    return HttpStatusCode.OK;
                }
                catch
                {
                    return HttpStatusCode.InternalServerError;
                }
            }
        }
    }
}