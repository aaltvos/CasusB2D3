﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Login
{
    public class SessionCheck
    {

        public static Tuple<string,int> Check(string token)
        {
            //string token;
            //token = actioncontext.Request.Headers.GetValues("Token").First();
            
            using (DBModelContainer db = new DBModelContainer())
            {
                try
                {
                    DateTime TTL = (from session in db.SESSIONS where session.SESSIONS_Token == token select session.SESSIONS_TTL).First();
                    if (TTL != null)
                    {
                        TimeSpan TimeLeft = TTL - DateTime.UtcNow;
                        DateTime newTime = DateTime.UtcNow.AddHours(3);
                        if (TimeLeft.Days == 0 & TimeLeft.Minutes < 30 & TimeLeft.Hours == 0)
                        {
                            SESSIONS CurrentSession = (from s in db.SESSIONS where s.SESSIONS_Token == token select s).First();
                            CurrentSession.SESSIONS_TTL = newTime;
                            db.SaveChanges();
                        }

                        else if (TimeLeft.Hours < 0)
                        {
                            SESSIONS CurrentSession = (from s in db.SESSIONS where s.SESSIONS_Token == token select s).First();
                            db.SESSIONS.Attach(CurrentSession);
                            db.SESSIONS.Remove(CurrentSession);
                            db.SaveChanges();
                            
                            return new Tuple<string, int>("no session", 0);
                        }

                        return new Tuple<string,int>(token, GetSecRole(token));

                    }
                    return new Tuple<string, int>(token, GetSecRole(token));
                }
                catch
                {
                    return new Tuple<string, int>("no session", 0);
                }
            }
        }

        public static Tuple<string, int> GetToken(string username)
        {
            string Token;
            using(DBModelContainer db = new DBModelContainer())
            {
                int UserID = (from user in db.USERs where user.USER_Name == username select user.USER_Id).First();
                var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
                var CurrentUser = CurrentUserQuery.FirstOrDefault<USERs>();

                try
                {
                    Token = (from session in db.SESSIONS where session.USER_Id.USER_Id == CurrentUser.USER_Id select session.SESSIONS_Token).First();
                    return Check(Token);
                }

                catch
                {
                    return new Tuple<string, int>("no session", 0);
                }
            }
        }

        public static int GetSecRole(string token)
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                int SecRole = (from s in db.SESSIONS where s.SESSIONS_Token == token select s.USER_Id.USER_Sec).First();
                return SecRole;
            }
        }
    }
}