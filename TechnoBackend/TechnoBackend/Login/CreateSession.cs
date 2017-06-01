using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Login
{

    public class CreateSession
    {
        int UserID;
        string Token;
        public CreateSession(string token, int userID)
        {
            this.UserID = userID;
            this.Token = token;
            DBModelContainer db = new DBModelContainer();

            var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
            var CurrentUser = CurrentUserQuery.FirstOrDefault<USERs>();

            SESSIONS Session = new SESSIONS()
            {
                SESSIONS_Token = Token,
                USER_Id = CurrentUser,
                SESSIONS_TTL = "peni"
            };

            
            db.SESSIONS.Add(Session);
            db.SaveChanges();
        }

        

       
    }
}