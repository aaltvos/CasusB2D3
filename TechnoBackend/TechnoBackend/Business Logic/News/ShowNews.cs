﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public static string GetNews(int numberOfArticles)
        {
            var newsmax = 0;
            var newscount = 0;
            List<object> articleList = new List<object>();
            DBModelContainer db = new DBModelContainer();
            //getting highest article # from DB and getting # of articles from db
            try
            {
                newsmax = (from news in db.NEWS where news.News_Id >= 1 select news.News_Id).Max();
                newscount = (from news in db.NEWS where news.News_Id >= 1 select news.News_Id).Count();
            }
            catch (Exception e)
            {
                return (e.ToString());
            }
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
                    if (currentArticle != null)
                    {
                        articleList.Add(currentArticle);
                    }
                    newsmax -= 1;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            //TODO: Fix string formatting and object messup
            var jsonstring = JsonConvert.SerializeObject(articleList[0],
                new JsonSerializerSettings
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                    //ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            return jsonstring;
          
        }    

        
    }
}