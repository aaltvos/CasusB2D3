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
        public HttpResponseMessage Get()   // allemaal ophalen
        {
            //var token = ActionContext.Request.Headers.GetValues("Token").First();
            //var newtoken = SessionCheck.Check(token);
            //if (newtoken.Item1 != "no session" && newtoken.Item2 >= 1)
            {
                try
                {
                    var message = WorkitemOpvragen.GetWorkItem();             
                    //Request.Headers.Add("Token", newtoken.Item1);
                    var response = Request.CreateResponse(message);
                    return response;
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }
        }
    }
}