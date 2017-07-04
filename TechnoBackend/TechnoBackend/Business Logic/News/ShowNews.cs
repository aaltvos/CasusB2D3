using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.News
{
    public class ShowNews
    {
        public static IList<JsonNews> GetNews(int numberOfArticles)
        {
            var newsmax = 0;
            var newscount = 0;
            
            var articleList = new List<JsonNews>();
            DBModelContainer db = new DBModelContainer();
            //getting highest article # from DB and getting # of articles from db

            newsmax = (from news in db.NEWS where news.News_Id >= 1 select news.News_Id).Max();
            newscount = (from news in db.NEWS where news.News_Title != null select news.News_Id).Count();

            //check if the # of requested articles isent more then the ammount of articles in the db
            if (numberOfArticles > newscount)
            {
                numberOfArticles = newscount;
            }
            
            //Retrieving numberOfArticles and put them as object in a list
            while (numberOfArticles > articleList.Count)
            {
                try
                {
                    var currentarticleQuery = db.NEWS.Where(s => s.News_Id == newsmax);
                    var currentArticle = currentarticleQuery.FirstOrDefault();
                    if (currentArticle.News_Title != null)
                    {
                        var wantedarticle = new JsonNews();
                        wantedarticle.Body = currentArticle.News_Body;
                        wantedarticle.ID = currentArticle.News_Id.ToString();
                        wantedarticle.Img = currentArticle.News_IMG;
                        wantedarticle.Link = currentArticle.News_Link;
                        wantedarticle.Title = currentArticle.News_Title;

                        articleList.Add(wantedarticle);
                    }
                    newsmax -= 1;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            //TODO: Fix string formatting and object messup
//            var jsonstring = JsonConvert.SerializeObject(articleList,Formatting.Indented);
//            return jsonstring;
            return articleList;

        }    

        
    }
}