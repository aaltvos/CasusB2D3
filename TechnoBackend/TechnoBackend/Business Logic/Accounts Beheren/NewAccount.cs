using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Accounts_Beheren
{
    public class NewAccount
    {
       // string SelectAccount;
        //User account = new User();
       // DBModelContainer db = new DBModelContainer();

        public static HttpStatusCode CreateAccount(HttpActionContext actionContext)
        {
          //  User account = new User();
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                JsonAccount json = JsonConvert.DeserializeObject<JsonAccount>(actionContext.Request.Content.ReadAsStringAsync().Result);

                USERs NewUser = new USERs()
                {
                    //USER_Id = json.id,
                    USER_Name = json.name,
                    USER_PW = json.pw,
                    USER_Sec = json.sec,
                    USER_Val_dat = json.val_dat,
                   // USER_Email = json.mail
                };
                try
                {
                    dbModel.USERs.Add(NewUser);
                    dbModel.SaveChanges();
                    return HttpStatusCode.OK;
                }
                catch
                {
                    return HttpStatusCode.InternalServerError;
                }




                ////Controle op input, username en pw mogen niet leeg zijn
                //if (!string.IsNullOrEmpty(account.USER_Name) && !string.IsNullOrEmpty(account.USER_PW))
                //{
                //    //Verval datum wordt gezet op huidige datum + 500 dgn 
                //    DateTime now = DateTime.Now;
                //    DateTime enddate = now.AddDays(500);
                //    account.USER_Val_dat = enddate;

                //    // controle op security lvl, als deze niet 'bestaat' wordt deze op 1 gezet.
                //    if (account.USER_Sec == 0 || account.USER_Sec > 4 || account.USER_Sec < 1)
                //    {
                //        account.USER_Sec = 1;
                //        USERs NewUser = new USERs()
                //        {
                //            // USER_Id
                //            USER_Name = account.USER_Name,
                //            USER_PW = account.USER_PW,
                //            USER_Sec = account.USER_Sec,
                //            USER_Val_dat = account.USER_Val_dat
                //        };
                //        try
                //        {
                //            dbModel.USERs.Add(NewUser);
                //            dbModel.SaveChanges();
                //        }
                //        catch (Exception e)
                //        {
                //            return e.ToString();
                //        }
                //        return ("standard account added");
                //    }
                //    else
                //    {
                //        // account.USER_Sec = User input
                //        USERs NewUser = new USERs()
                //        {
                //            // USER_Id
                //            USER_Name = account.USER_Name,
                //            USER_PW = account.USER_PW,
                //            USER_Sec = account.USER_Sec,
                //            USER_Val_dat = account.USER_Val_dat
                //        };
                //        try
                //        {
                //            dbModel.USERs.Add(NewUser);
                //            dbModel.SaveChanges();
                //        }
                //        catch (Exception e)
                //        {
                //            return e.ToString();
                //        }
                //        return ("personal account added");
                //    }

                //}
                //else
                //{
                //    return ("incorrect input");
                //}


            }

        }







    }
}