using System.Linq;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Login
{
    public class Authentication
    {
        public static int Login(string username, string password)
        {

            using (DBModelContainer db = new DBModelContainer())
            {
               
                try
                {
                    var userId = (from user in db.USERs where user.USER_Name == username && user.USER_PW == password select user.USER_Id).First();
                    return userId;
                }
                
                catch { return 0; }
            }
        }
    }
}