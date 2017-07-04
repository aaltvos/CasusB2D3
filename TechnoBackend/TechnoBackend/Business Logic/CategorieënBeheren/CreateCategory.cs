using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.CategorieënBeheren
{
    public class CreateCategory
    {

        public static string AddCategory(HttpActionContext actionContext)
        {

            DBModelContainer db = new DBModelContainer();

            //Decoding Json to Object
            var json = actionContext.Request.Content.ReadAsStringAsync().Result;
            JsonCategory newCategory = JsonConvert.DeserializeObject<JsonCategory>(json);

            //Get token from headers
            string Token = actionContext.Request.Headers.GetValues("Token").First();

            //Use token to get the user id
            var UserID = (from sessions in db.SESSIONS where sessions.SESSIONS_Token == Token select sessions.USER_Id.USER_Id).First();
            var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
            var currentUser = CurrentUserQuery.FirstOrDefault<USERs>();

            //Create new Article in DB with info from tje object and the user id
            CAT category = new CAT()
            {
                CAT_Name = newCategory.Name,
                CAT_IMG = newCategory.Img,
            };
            try
            {
                db.CATs.Add(category);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return e.ToString();
            }

            return "Category added succesfully";
        }
    }
}