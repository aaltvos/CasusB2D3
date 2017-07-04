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

namespace TechnoBackend.Business_Logic.EOLDControleren
{
    public class EOLDStart
    {
        public static object FetchEOL()
        {
         return FetchEOLProducts();
        }

        // Fetch expired products
        private static List<ShowEOLD> FetchEOLProducts()
        {
            // Initialise workitem list
            List<ShowEOLD> FetchedItems = new List<ShowEOLD>();

            // Single database usage
            using (DBModelContainer db = new DBModelContainer())
            {
                // Get product object(s) which have the needed information with the correct datetime condition
                IQueryable<PRODs> ExpiredProducts = db.PRODs.Where(s => s.Prod_Val_Dat.AddYears(1) < DateTime.Today);

                // Cycle through each product and add needed data as an object to the FetchedItems list
                foreach (PRODs expiredproduct in ExpiredProducts)
                {
                    ShowEOLD EOLDItem = new ShowEOLD(
                        expiredproduct.Prod_Val_Dat);
                    FetchedItems.Add(EOLDItem);
                }

                // return the fetched expired products
                return FetchedItems;
            }
        }
    }
}