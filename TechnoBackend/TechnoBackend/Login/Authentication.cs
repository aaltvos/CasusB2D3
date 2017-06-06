using System.Linq;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Login
{
    public class Authentication
    {
        public static bool Login(string username, string password)
        {

            using (DBModelContainer db = new DBModelContainer())
            {
                if ((from user in db.USERs where user.USER_Name == username && user.USER_PW == password select user.USER_PW).First() == null) { return false; }
                else { return true; }
            }
        }
    }
}