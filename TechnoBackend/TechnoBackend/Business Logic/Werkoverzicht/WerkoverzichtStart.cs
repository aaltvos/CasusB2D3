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
        public static object FetchWorkitems(int id)
        {
            switch (id)
            {
                case 1:
                    // 1: Fetch unvalidated workitems for supervisor
                    //    an unvalidated workitem for a supervisor is a
                    //    product that has been validated by a student
                    return FetchUnvalidatedProducts();

                case 2:
                    // 2: Fetch expired workitems, workitems are expired
                    //    when their validation date is more then 3 years ago
                    return FetchExpiredProducts();

                default:
                    // Als er een ander getal of woord ingegeven is dan 1 of 2 dan komt het programma hierop uit
                    return null;
            }
        }

        // Fetch unvalidated products
        private static List<Workitem> FetchUnvalidatedProducts()
        {
            List<Workitem> WorkitemList = new List<Workitem>();

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
                        Workitem workitem = new Workitem(
                            unvalidatedProduct.Prod_ID, 
                            unvalidatedProduct.Prod_Name,
                            unvalidatedProduct.Prod_Dat,
                            unvalidatedProduct.Prod_Size,
                            unvalidatedProduct.Prod_Weight,
                            unvalidatedProduct.Prod_Cost,
                            unvalidatedProduct.Prod_Covered,
                            unvalidatedProduct.Prod_Avail,
                            unvalidatedProduct.Prod_Desc,
                            unvalidatedProduct.Prod_Spec,
                            unvalidatedProduct.Prod_Req,
                            unvalidatedProduct.Prod_Mov,
                            unvalidatedProduct.Prod_Views,
                            unvalidatedProduct.Prod_Val_Dat);
                        WorkitemList.Add(workitem);
                    }
                }

                // return list with unvalidated products
                return WorkitemList;
            }
        }

        // Fetch expired products
        private static List<Workitem> FetchExpiredProducts()
        {
            // Initialise workitem list
            List<Workitem> FetchedItems = new List<Workitem>();

            // Single database usage
            using (DBModelContainer db = new DBModelContainer())
            {
                // Get product object(s) which have the needed information with the correct datetime condition
                IQueryable<PRODs> ExpiredProducts = db.PRODs.Where(s => s.Prod_Val_Dat.AddYears(3) < DateTime.Today);

                // Cycle through each product and add needed data as an object to the FetchedItems list
                foreach (PRODs expiredproduct in ExpiredProducts)
                {
                    Workitem workitem = new Workitem(
                        expiredproduct.Prod_ID,
                        expiredproduct.Prod_Name,
                        expiredproduct.Prod_Dat,
                        expiredproduct.Prod_Size,
                        expiredproduct.Prod_Weight,
                        expiredproduct.Prod_Cost,
                        expiredproduct.Prod_Covered,
                        expiredproduct.Prod_Avail,
                        expiredproduct.Prod_Desc,
                        expiredproduct.Prod_Spec,
                        expiredproduct.Prod_Req,
                        expiredproduct.Prod_Mov,
                        expiredproduct.Prod_Views,
                        expiredproduct.Prod_Val_Dat);
                    FetchedItems.Add(workitem);
                }

                // return the fetched expired products
                return FetchedItems;
            }
        }
    }
}