using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Web.Http;
using System.Web.WebPages;
using TechnoBackend.Business_Logic.News;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Login;


namespace TechnoBackend.Controllers
{
    public class NewsController : ApiController
    {
        // GET api/<controller>
        public HttpResponseMessage Get()
        {   
            DBModelContainer db = new DBModelContainer();
            var newsmax = (from news in db.NEWS where news.News_Id >= 1 select news.News_Id).Max();
            var response = Request.CreateResponse(newsmax);
            return response;
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(int id)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 1)
            {
                try
                 {
                    var message = ShowNews.GetNews(id);
                    Request.Headers.Add("Token", newtoken.Item1);
                    var response = Request.CreateResponse(message);
                    return response;
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized,"Session not found");
        }

        // POST api/<controller>
        public HttpResponseMessage Post()
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 2)
            {
                var message = CreateNews.AddArticle(ActionContext);
                
                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 4)
            {
                var message = DeleteNews.DeleteArticle(id);

                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
        }
    }
}