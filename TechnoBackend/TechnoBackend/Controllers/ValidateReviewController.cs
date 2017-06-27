using Newtonsoft.Json;
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
    
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);

            if (true/*newtoken.Item1 != "no session" && newtoken.Item2 >= 4*/)
            {
                List<WorkItem> all = WorkItem.LoadAll();

                string message = "";
                if (all.Count == 0)
                    message = "{\"status\":\"Error\", \"message\":\"No WorkItems could be loaded\"}";
                else
                {
                    message = "{\"status\":\"Success\", \"items\":[";
                    for (int i = 0; i < all.Count; i++)
                    {
                        message += all[i].ToJson();

                        if (i < all.Count - 1)
                            message += ",";
                    }
                    message += "]}";
                }
                
                Request.Headers.Add("Token", newtoken.Item1);
                return Request.CreateResponse(message);
            }
            
            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(int id)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            
            if (true/*newtoken.Item1 != "no session" && newtoken.Item2 >= 4*/)
            {
                string message = "";
                if (id < 0)
                    message = "{\"status\":\"Error\", \"message\":\"Invalid id\"}";
                else
                {
                    WorkItem selected = WorkItem.ForId(id);
                    if (selected != null)
                        message = "{\"status\":\"Succes\", \"item\":" + selected.ToJson() + "}";
                    else
                        message = "{\"status\":\"Error\", \"message\":\"No WorkItem found with id\"}";
                }

                Request.Headers.Add("Token", newtoken.Item1);
                return Request.CreateResponse(message);
            }

            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "[ValidateReview::Post] - Should not be used, use Put instead");
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            Debug.WriteLine("put: " + value);
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (true/*newtoken.Item1 != "no session" && newtoken.Item2 >= 4*/)
            {
                string message = "";
                dynamic json = JsonConvert.DeserializeObject(value);
                if (json != null)
                {
                    WorkItem selected = WorkItem.ForId(id);
                    if (selected != null)
                    {
                        string action = json.action;
                        if (action.Equals("Accept"))
                            message = selected.Accept(token);
                        else
                            message = selected.Deny();
                    } else
                        message = "{\"status\":\"Error\", \"message\":\"No WorkItem found with id\"}";
                }
                else
                    message = "{\"status\":\"Error\", \"message\":\"Invalid json parsed\"}";

                Request.Headers.Add("Token", newtoken.Item1);
                return Request.CreateResponse(message);
            }

            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "[ValidateReview::Delete] - Should not be used");
        }

    }

}