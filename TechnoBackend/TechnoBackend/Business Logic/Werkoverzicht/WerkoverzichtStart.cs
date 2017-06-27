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


        private static object FetchValidators()
        {
            List<JsonWorkitem> WorkitemList = new List<Object>();

            // Geef aan met welke database de linq querry wordt uitgevoerd
            using (DBModelContainer db = new DBModelContainer())
            {
                // get user object which have the product information
                var Students = db.USERs.Where(s => s.USER_Sec == 3);
               
                //Ga door iedere naam om correspondeerende workitems eruit te halen
                foreach (var student in Students)
                {
                    foreach (var prod in student.PRODs)
                    {
                        var wantedItem = new JsonWorkitem(prod.Prod_ID, prod.Prod_Name);
                        WorkitemList.Add(wantedItem);
                    }
                }

                // return Lijst met ongevalideerde workitems
                return WorkitemList;
            }
        }


        private static List<PRODs> FetchExpiredDates()
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                List<PRODs> FetchedItems = new List<PRODs>();
                var FetchedItemsQuery = db.PRODs.Where(s => s.Prod_Val_Dat == DateTime.Today);

                foreach (var item in FetchedItemsQuery)
                {
                    FetchedItems.Add(item);
                }

                return FetchedItems;
            }
        }
    }
}

