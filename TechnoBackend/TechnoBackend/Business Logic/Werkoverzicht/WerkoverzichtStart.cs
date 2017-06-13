using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Werkoverzicht
{
    public class WerkoverzichtStart
    {
        public List<PRODs> WorkItemsFetchen(int id)
        {
            switch (id)
            {
                case 1:
                    return FetchValidators();
                case 2:
                    return FetchExpiredDates();
                default:
                    return TestWorkItems = "Geen enkele van je ids zijn goede ids";
            }


        }

        private List<PRODs> FetchValidators()
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                List<PRODs> FetchedItems = new List<PRODs>();
                var FetchedItemsQuery = db.PRODs.Where(s => s.Prod_Validator == "0"); //magisch nummer weghalen
                foreach (var item in FetchedItemsQuery)
                {
                    FetchedItems.Add(item);
                }
                return FetchedItems;
            }
        }

        private List<PRODs> FetchExpiredDates()
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                List<PRODs> FetchedItems = new List<PRODs>();
                //verander validator in de dates ding
                var FetchedItemsQuery = (from penis in db.PRODs select penis.Prod_Name && penis.Prod_Val_Dat); //magisch nummer weghalen
                foreach (var item in FetchedItemsQuery)
                {
                    FetchedItems.Add(item);
                }
                return FetchedItems;
            }
        }
    }
}

