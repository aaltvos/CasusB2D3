using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.News
{
    public class ShowNews
    {
        public static string GetNews(HttpActionContext actioncontact, int numberOfArticles)
        {

            List<object> articleList = new List<object>();
            DBModelContainer db = new DBModelContainer();
            var newsarticles = (from news in db.NEWS where news.News_Id >= 1 select news.News_Id);
            var newscount = newsarticles.Count();
            //Todo: retrieve the most recent numberOfArticles from the db as object in an array
            //Todo: conver the array to json and return the string



            return newscount.ToString();
        }
    }
}