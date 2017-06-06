using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.News
{
    public class CreateNews
    {
        public static string AddArticle(HttpActionContext actionContext)
        {

            DBModelContainer db = new DBModelContainer();
            
            //Decoding Json to Object
            var json = actionContext.Request.Content.ReadAsStringAsync().Result;
            JsonNews newArticle = JsonConvert.DeserializeObject<JsonNews>(json);

            //Get token from headers
            string Token = actionContext.Request.Headers.GetValues("Token").First();

            //Use token to get the user id
            var currentUserQuery = db.SESSIONS.Where(s => s.SESSIONS_Token == Token);
            var currentUser = currentUserQuery.FirstOrDefault<USERs>();
            //TODO: Figure out the LINQ querry to retain the USER_ID from Session

            //Create new Article in DB with info from tje object and the user id
            NEWS news = new NEWS()
            {
                News_Title = newArticle.Title,
                News_Body =  newArticle.Body,
                News_IMG =  newArticle.Img,
                News_Link = newArticle.Link,
                USERs = currentUser
            };
            try
            {
                db.NEWS.Add(news);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            
            return "succes";
        }
    }
}