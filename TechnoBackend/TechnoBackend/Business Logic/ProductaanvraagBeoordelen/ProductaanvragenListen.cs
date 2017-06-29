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

namespace TechnoBackend.Business_Logic.ProductaanvraagListen
{
    public class ProductaanvraagListen
    {
        public static List<PRODs> OnbeoordeeldeProductaanvragen() //OnbeoordeeldeProductaanvragen = OP
        {
            DBModelContainer db = new DBModelContainer();
            {
                //Lijst OP initialiseren.
                List<PRODs> OnbeoordeeldeProductaanvragen = new List<PRODs>();

                //Query aanmaken met filter op productaanvragen die gemaakt zijn door users met security level kleiner dan 3.
                var OnbeoordeeldeProductaanvragenQuery = db.PRODs.Where(User_Sec.Prod_Val_User < 3);

                //Lijst OP invullen met OP's.
                foreach (var OP in OnbeoordeeldeProductaanvragenQuery)
                {
                    OnbeoordeeldeProductaanvragen.Add(OP);
                }
                //Lijst OP returnen.
                return OnbeoordeeldeProductaanvragen;
            }
        }
    }
}