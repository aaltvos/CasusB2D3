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
        public static object WorkItemsFetchen(int id)
        {
            switch (id)
            {
                case 1:
                    // 1: Fetch unvalidated workitems for supervisor
                    //    an unvalidated workitem for a supervisor is a
                    //    product that has been validated by a student
                    return FetchValidators();

                case 2:
                    // 2: Fetch expired workitems, workitems are expired
                    //    when their validation date is more then 3 years ago
                    return FetchExpiredDates();

                default:
                    // Als er een ander getal of woord ingegeven is dan 1 of 2 dan komt het programma hierop uit
                    return null;
            }
        }

        // Fetch unvalidated products
        private static List<JsonWorkitem> FetchValidators()
        {
            List<JsonWorkitem> WorkitemList = new List<JsonWorkitem>();

            // Single database usage
            using (DBModelContainer db = new DBModelContainer())
            {
                // Get user(s) object which have the product information needed with correct security level
                IQueryable<USERs> Students = db.USERs.Where(s => s.USER_Sec == 3);
               
                // Cycle trough each student and every product they have and add it to the list
                foreach (USERs student in Students)
                {
                    foreach (PRODs unvalidatedProduct in student.PRODs)
                    {
                        JsonWorkitem workitem = new JsonWorkitem(unvalidatedProduct.Prod_ID, unvalidatedProduct.Prod_Name);
                        WorkitemList.Add(workitem);
                    }
                }

                // return list with unvalidated products
                return WorkitemList;
            }
        }

        // Fetch expired products
        private static List<JsonWorkitem> FetchExpiredDates()
        {
            // Initialise workitem list
            List<JsonWorkitem> FetchedItems = new List<JsonWorkitem>();

            // Single database usage
            using (DBModelContainer db = new DBModelContainer())
            {
                // Get product object(s) which have the needed information with the correct datetime condition
                IQueryable<PRODs> ExpiredProducts = db.PRODs.Where(s => s.Prod_Val_Dat.AddYears(3) < DateTime.Today);

                // Cycle through each product and add needed data as an object to the FetchedItems list
                foreach (PRODs product in ExpiredProducts)
                {
                    JsonWorkitem workitem = new JsonWorkitem(product.Prod_ID, product.Prod_Name);
                    FetchedItems.Add(workitem);
                }

                // return the fetched expired products
                return FetchedItems;
            }
        }
    }
}