using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Web.Http;
using System.Web.WebPages;
using TechnoBackend.Business_Logic.News;


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
            var message = ShowNews.GetNews(ActionContext, id);
            var response = Request.CreateResponse(message);
            return response;
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