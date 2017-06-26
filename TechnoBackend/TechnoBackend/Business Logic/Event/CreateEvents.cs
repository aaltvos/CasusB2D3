using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DBmodelContainer;
using TechnoBackend.Business_Logic.Event;

namespace TechnoBackend.Business_Logic.ManageNews
{
    public class CreateEvents
    {
        public static string AddEvent(HttpActionContext actionContext)
        {
            using (DBmodelContainer data = new DBmodelContainer())
            {
                var json = actionContext.Request.Content.ReadAsStringAsync().Result;
                JsonEvent newEvent = JsonConvert.DeserializeObject<JsonEvent>(json);

                string Token = actionContext.Request.Headers.GetValues("Token").First();

                var UserID = (from sessions in db.SESSIONS where sessions.SESSIONS_Token == Token select sessions.USER_Id.USER_Id).First();
                var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
                var currentUser = CurrentUserQuery.FirstOrDefault<USERs>();

                EVENT event = new EVENT()
            }
        }
    }
}