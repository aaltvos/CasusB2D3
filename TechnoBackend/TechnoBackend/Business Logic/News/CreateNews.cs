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
            var UserID = (from sessions in db.SESSIONS where sessions.SESSIONS_Token == Token select sessions.USER_Id.USER_Id).First();
            var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
            var currentUser = CurrentUserQuery.FirstOrDefault<USERs>();
            

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
            
            return "Article Added succesfully";
        }
    }
}