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
        private readonly List<WorkItem> _cache;

        private WorkItem _selected;

        public ValidateReviewController()
        {
            _cache = new List<WorkItem>();
        }
        
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);

            if (true/*newtoken.Item1 != "no session" && newtoken.Item2 >= 1*/)
            {
                _cache.Clear();
                _cache.AddRange(WorkItem.LoadAll());
                
                string message = "";
                if (_cache.Count == 0)
                    message = "{\"status\":\"Error\", \"message\":\"No WorkItems could be loaded\"}";
                else
                {
                    message = "{\"status\":\"Success\", \"items\":[";
                    for (int i = 0; i < _cache.Count; i++)
                    {
                        message += _cache[i].ToJson();

                        if (i < _cache.Count - 1)
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
            
            if (true/*newtoken.Item1 != "no session" && newtoken.Item2 >= 2*/)
            {
                string message = "";
                if (_cache.Count == 0)
                    message = "{\"status\":\"Error\", \"message\":\"Cache is empty, please call Get() before sending an index\"}";
                else
                {
                    if (id < 0 || id >= _cache.Count)
                        message = "{\"status\":\"Error\", \"message\":\"Invalid id\"}";
                    else
                    {
                        _selected = _cache[id];
                        message = "{\"status\":\"Succes\", \"item\":" + _selected.ToJson() + "}";
                    }
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
                if (_selected == null)
                    message = "{\"status\":\"Error\", \"message\":\"No WorkItem selected\"}";
                else
                {
                    dynamic json = JsonConvert.DeserializeObject(value);
                    if (json != null)
                    {
                        string action = json.action;
                        if (action.Equals("Accept"))
                            message = _selected.Accept(token);
                        else
                            message = _selected.Deny();
                    } else
                        message = "{\"status\":\"Error\", \"message\":\"Invalid json parsed\"}";
                }

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