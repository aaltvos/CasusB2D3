using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Login;
using TechnoBackend.Business_Logic.Zoekenenfilteren;
/*
namespace TechnoBackend.Controllers
{
    public class GetSubHand_Geb : ApiController
    {

        // GET api/<controller>/5
        public HttpResponseMessage Get()   // allemaal ophalen
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var handgeb_id = ActionContext.Request.Headers.GetValues("Handgeb_ID").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 1)
            {
                try
                {
                    var message = getsubhand_Geb.GetSupHand_Geb();
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
*/