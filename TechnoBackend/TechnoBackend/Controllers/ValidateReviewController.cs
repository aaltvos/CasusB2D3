using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnoBackend.Business_Logic.ValidateReview;
using TechnoBackend.Login;

namespace TechnoBackend.Controllers
{
    public class ValidateReviewController : ApiController
    {
        private readonly List<WorkItem> cache;

        private WorkItem _item;

        public ValidateReviewController()
        {
            cache = new List<WorkItem>();
        }
        
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);

            if (true/*newtoken.Item1 != "no session" && newtoken.Item2 >= 1*/)
            {
                cache.Clear();
                cache.AddRange(WorkItem.LoadAll());
                
                string message = "";
                if (cache.Count == 0)
                    message = "{\"status\":\"Error: No WorkItems could be loaded\"}";
                else
                {
                    message += "{";
                    for (int i = 0; i < cache.Count; i++)
                    {
                        message += cache[i].ToJson();
                        if (i < cache.Count - 1)
                            message += ",";
                    }
                    message += "}";
                }
                
                Request.Headers.Add("Token", newtoken.Item1);
                return Request.CreateResponse(message);
            }
            
            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(int id)
        {
            // auth validation
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            
            if (true/*newtoken.Item1 != "no session" && newtoken.Item2 >= 1*/)
            {
                string message = "";
                if (cache.Count == 0)
                    message = "{\"status\":\"Error: Cache is empty, please call Get() before sending an index\"}";
                else
                {
                    if (id < 0 || id >= cache.Count)
                        message = "{\"status\":\"Error: Invalid id\"}";
                    else
                    {
                        message = "{\"status\":\"Succes\"}";
                        _item = cache[id];
                    }
                }

                Request.Headers.Add("Token", newtoken.Item1);
                return Request.CreateResponse(message);
            }

            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException("[ValidateReview::Post] - Should not be used, use Put instead");
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            Debug.WriteLine("[VRC] - Put:[id=" + id + "data=" + value + "]");

            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (true/*newtoken.Item1 != "no session" && newtoken.Item2 >= 2*/)
            {
                string message = "";
                if (_item == null)
                    message = "{\"status\":\"Error: No WorkItem selected\"}";

                Request.Headers.Add("Token", newtoken.Item1);
                return Request.CreateResponse(message);
            }

            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                // TODO: fill message
                var message = "";
                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }

            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");
        }

    }

}