using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Accounts_Beheren
{
    public class OldAccount
    {
        public static string DeleteAccount(int userid)
        {
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                var existingaccount = dbModel.USERs.Where(s => s.USER_Id == userid).FirstOrDefault();
                if (existingaccount != null)
                {
                    dbModel.USERs.Remove(existingaccount);
                    try
                    {
                        dbModel.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        return (e.ToString());
                    }
                    return ("deleted:"+ userid);
                }
                return ("Account could not be found");
            }
                
        }


    }
}