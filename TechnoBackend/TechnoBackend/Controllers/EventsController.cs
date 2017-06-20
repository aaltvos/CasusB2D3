using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Login;
using TechnoBackend.Business_Logic.Events;

namespace TechnoBackend.Controllers
{
    public class EventsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        //public string Get(int id)
        //{
            //var token = ActionContext.Request.Headers.GetValues("Token").First();
            //var new_token = SessionCheck.Check(token);
            //if (new_token.Item1 != "no session" && new_token.Item2 >1)
            //{
             //   var message = ShowEvents.GetEvents(id);
            //    Request.Headers.Add("Token", new_token.Item1);
             //   var response = Request.CreateResponse(message);
            //    return response;
            //}
           // return Request.CreateResponse("Invalid action");
        //}

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