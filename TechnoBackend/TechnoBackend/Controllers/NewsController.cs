using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Web.Http;
using System.Web.WebPages;
using TechnoBackend.Business_Logic.News;
using TechnoBackend.Login;


namespace TechnoBackend.Controllers
{
    public class NewsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(int id)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken != "no session")
            {
                var message = ShowNews.GetNews(id);
                Request.Headers.Add("Token",newtoken);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse(newtoken);
        }

        // POST api/<controller>
        public HttpResponseMessage Post()
        {
            
            var message = CreateNews.AddArticle(ActionContext);
            var response = Request.CreateResponse(message);

            return response;
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