using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.ManageEvents
{
    public class CreateEvent
    {
        public static string AddEvent(HttpActionContext actionContext)
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                //Decoding Json to Object
                var json = actionContext.Request.Content.ReadAsStringAsync().Result;
                JsonEvent newEvent = JsonConvert.DeserializeObject<JsonEvent>(json);

                //Get token from headers
                string Token = actionContext.Request.Headers.GetValues("Token").First();

                //Use token to get the user id
                var UserID = (from sessions in db.SESSIONS where sessions.SESSIONS_Token == Token select sessions.USER_Id.USER_Id).First();
                var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
                var currentUser = CurrentUserQuery.FirstOrDefault<USERs>();


                //Create new Article in DB with info from the object and the user id
                EVENT event_ = new EVENT()
                {
                    Event_Name = newEvent.Name,
                    Event_Body = newEvent.Body,
                    Event_Address = newEvent.Address,
                    Event_Link = newEvent.Link,
                    USERs = currentUser
                };
                try
                {
                    db.EVENTs.Add(event_);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }

                return "Event Added succesfully";
            }
        }
    }
}