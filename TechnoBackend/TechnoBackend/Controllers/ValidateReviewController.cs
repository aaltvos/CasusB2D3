using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TechnoBackend.Business_Logic.ValidateReview;
using TechnoBackend.Login;

/**
 * @Author Patrick
 * */
namespace TechnoBackend.Controllers
{
    public class ValidateReviewController : ApiController
    {
    
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);

            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
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
            
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
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
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                string message = "";

                WorkItem selected = WorkItem.ForId(id);
                if (selected != null)
                {
                    IEnumerable<string> action = ActionContext.Request.Headers.GetValues("Action");
                    if (action != null)
                    {
                        if (action.Equals("Accept"))
                            message = selected.Accept(token);
                        else if (action.Equals("Deny"))
                            message = selected.Deny();
                        else
                            message = "{\"status\":\"Error\", \"message\":\"Invalid Action\"}";
                    }
                    else
                        message = "{\"status\":\"Error\", \"message\":\"No Action found in headers\"}";
                }
                else
                    message = "{\"status\":\"Error\", \"message\":\"No WorkItem found with id\"}";

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