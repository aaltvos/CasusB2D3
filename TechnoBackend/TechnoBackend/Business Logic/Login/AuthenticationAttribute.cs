using System;
using Newtonsoft.Json;
using System.Web.Http.Controllers;

namespace TechnoBackend.Login
{
    public class AuthenticationAttribute
    {

        public static string Authent(HttpActionContext actionContext)
        {
            string AuthToken;

            var json = actionContext.Request.Content.ReadAsStringAsync().Result;
            JsonLogin Credentials = JsonConvert.DeserializeObject<JsonLogin>(json);
            string username = Credentials.Username;
            string password = Credentials.Password;
            
            if (Authentication.Login(username, password) != 0)
            {
                AuthToken = SessionCheck.GetToken(username).Item1;
                if (AuthToken == "no session")
                {
                    AuthToken = RandomString();
                    CreateSession newSession = new CreateSession(AuthToken, Authentication.Login(username, password));
                }
            }

            else
            {
                return "Unauthorized";
            }

            return AuthToken;
        }

        public static string RandomString()
        {
            string gen = "";
            Random random = new Random();
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            for (int i = 0; i < 100; i++)
            {
                gen += chars[random.Next(chars.Length)].ToString(); ;
            }
            return gen;
        }
    }
}