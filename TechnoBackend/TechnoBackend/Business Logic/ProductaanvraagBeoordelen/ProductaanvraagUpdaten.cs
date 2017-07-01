using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using TechnoBackend.Login;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Business_Logic.ProductaanvraagListen;

namespace TechnoBackend.Business_Logic.ProductaanvraagUpdaten

{
    public class ProductaanvraagUpdaten
    {
        public static string Productaanvraag_Updaten (int Product_ID, string token)
        {
            DBModelContainer db = new DBModelContainer();

            //Security level van de gebruiker bepalen mbv Token.
            int Sec_Lvl = SessionCheck.GetSecRole(token);
            
            //Wanneer security level lager dan 3 is (1 of 2).
            if (Sec_Lvl < 3)
            {

                //Query die API input (Product_ID) vergelijkt met PRODs.Prod_ID en hierbij
                //de user_ID van de huidige gebruiker in cell van Prod_Val_user_USER_Id plaats.
                var query =
                    (from PRODs in db.PRODs
                    where PRODs.Prod_ID == Product_ID
                    select PRODs.Prod_Val_User).SingleOrDefault();

                try
                {
                    //Db opslaan met veranderingen.
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    // Provide for exceptions.
                }

                //Return wanneer de UseCase doorlopen is.
                return "Het product is beoordeeld";

            }
            //Als security level < 3 is.
            else
            {
                //Return wanneer security level 2 of lager is (De IF statement).
                return "Security level is niet hoog genoeg.";
            }
        }
    }
}