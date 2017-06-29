using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Business_Logic.ProductaanvraagListen;

namespace TechnoBackend.Business_Logic.ProductaanvraagUpdaten

{
    public class ProductaanvraagUpdaten
    {
        public static string ProductaanvraagUpdaten (int Prod_ID)
        {
            DBModelContainer db = new DBModelContainer();

            //Security level bepalen van de gebruiker.
            {
                int Sec_Lvl = (from user in db.USERs where user.USER_Name == username select user.USER_Sec).First();
                var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
                var CurrentUser = CurrentUserQuery.FirstOrDefault<USERs>();
                return Sec_Lvl;
            }

            //Wanneer security level hoger dan 2 is (3 of 4).
            if (Sec_Lvl > 2)
            {
                //Current_User_ID initialiseren en updaten.
                int Current_User_ID = (from user in db.USERs where user.USER_Name == username select user.USER_Id).First();
                var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
                var CurrentUser = CurrentUserQuery.FirstOrDefault<USERs>();

                //TeBeoordelen is het product dat beoordeeld moet worden.
                var Beoordeeld = (from Prod_Val_User in db.PRODs where Prod_ID == PRODs.Prod_ID select Prod_ID.Prod_ID).First();

                //Return te beoordelen           return Current_User_ID;
                return "Het product is beoordeeld";

            }
            else
            {
                return "Security level is niet hoog genoeg.";
            }
        }
    }
}