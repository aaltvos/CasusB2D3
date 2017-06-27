using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Business_Logic.ManageEvents;
using TechnoBackend.Login;

namespace TechnoBackend.Controllers
{
    public class EventController : ApiController
    {
        // GET api/<controller>/5
        public HttpResponseMessage Get()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 1)
            {
                try
                {
                    var message = ShowEvent.GetEvent();
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
        public HttpResponseMessage Post()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 2)
            {
                var message = CreateEvent.AddEvent(ActionContext);

                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                var message = DeleteEvent._DeleteEvent(id);

                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
        }
    }
}