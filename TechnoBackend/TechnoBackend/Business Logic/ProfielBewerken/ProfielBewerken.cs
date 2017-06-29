using System;
using System.Diagnostics;
using System.Linq;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Login;
using System.Collections.Generic;


namespace TechnoBackend.Business_Logic.ProfielBewerken
{
    public class ProfielBewerken
    {
        public static string EditProfile(HttpActionContext actionContext)
        {

            // Geef aan met welke database de linq querry wordt uitgevoerd
            using (DBModelContainer db = new DBModelContainer())
            {

                var json = actionContext.Request.Content.ReadAsStringAsync().Result;
                JsonProfielBewerken editProfile = JsonConvert.DeserializeObject<JsonProfielBewerken>(json);

                //Get token from headers
                string token = actionContext.Request.Headers.GetValues("Token").First();

                //Use token to get the user id
                var userID = (from sessions in db.SESSIONS where sessions.SESSIONS_Token == token select sessions.USER_Id.USER_Id).First();
                var currentUser = from users in db.USERs where users.USER_Id == userID select users;                
                Debug.WriteLine(currentUser.ToString());

                List<string> lijst = new List<string>();
                string nameInput = "x";
                string PWInput = "y";
                string emailInput = "z";

                if (nameInput != null)
                {
                    currentUser.USER_Name = nameInput;
                }
                if (PWInput != null)
                {
                    currentUser.USER_PW = PWInput;
                }
                if (emailInput != null)
                {
                    currentUser.USER_Email = emailInput;
                }

                if (nameInput != null || PWInput != null || emailInput != null)
                { 
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception e)
                    {
                        return e.ToString();
                    }

                return "Succesfully changed details";
                }
                else
                {
                    return "No changes were made";
                }


            }
        }



    }
}