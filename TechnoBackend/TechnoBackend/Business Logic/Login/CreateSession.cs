using System;
using System.Linq;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Login
{

    //Creates a new session
    public class CreateSession
    {
        int UserID;
        string Token;
        public static void Create(string token, int userID)
        {
            DBModelContainer db = new DBModelContainer();

            var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == userID);
            var CurrentUser = CurrentUserQuery.FirstOrDefault<USERs>();
            DateTime ttl = DateTime.UtcNow;
            ttl = ttl.AddHours(3);

            SESSIONS Session = new SESSIONS()
            {
                SESSIONS_Token = token,
                USER_Id = CurrentUser,
                SESSIONS_TTL = ttl
            };
            
            db.SESSIONS.Add(Session);
            db.SaveChanges();
        }
    }
}