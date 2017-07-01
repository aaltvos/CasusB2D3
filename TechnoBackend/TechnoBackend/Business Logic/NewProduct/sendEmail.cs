using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.NewProduct
{
	public class sendEmail
	{
        DBModelContainer db;
        public string sendAll(int securityLevel)
        {
            db = new DBModelContainer();
            var emailList = (from user in db.USERs where user.USER_Sec == securityLevel select user.USER_Email).AsEnumerable();
            string recipients;
            foreach (var email in emailList)
            {
                //build and send email!
                recipients = "example@example.com";
                return recipients;
            }
            return null;
        }
	}
}