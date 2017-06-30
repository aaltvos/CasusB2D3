using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.CategorieënBeheren
{
    public class ChangeCategory
    {

        public static string AddCategory(HttpActionContext actionContext)
        {

            DBModelContainer db = new DBModelContainer();

            //Decoding Json to Object
            var json = actionContext.Request.Content.ReadAsStringAsync().Result;
            JsonCategory UpdateCategory = JsonConvert.DeserializeObject<JsonCategory>(json);

            //Get token from headers
            string Token = actionContext.Request.Headers.GetValues("Token").First();

            //Use token to get the user id
            var UserID = (from sessions in db.SESSIONS where sessions.SESSIONS_Token == Token select sessions.USER_Id.USER_Id).First();
            var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
            var currentUser = CurrentUserQuery.FirstOrDefault<USERs>();

            try
            {
                db.CAT
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return e.ToString();
            }

            return "Category updated succesfully";
        }
    }
}