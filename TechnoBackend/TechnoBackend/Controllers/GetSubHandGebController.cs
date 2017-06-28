using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Login;
using TechnoBackend.Business_Logic.Zoekenenfilteren;
using System.Web.Http.Controllers;

namespace TechnoBackend.Controllers
{
    public class GetSubHandGebController : ApiController
    {

        // GET api/<controller>/5
        public HttpResponseMessage Get()   // allemaal ophalen
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            //var handgeb = ActionContext.Request.Headers.GetValues("Handgeb").First();
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 1)
            {
                try
                {
                    var message = showSuphandgeb.GetSupHand_Geb(ActionContext);
                    Request.Headers.Add("Token", newtoken.Item1);
                    var response = Request.CreateResponse(message);
                    return response;
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}