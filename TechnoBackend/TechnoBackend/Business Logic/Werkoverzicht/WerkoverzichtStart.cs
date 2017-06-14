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
        public static List<Object> WorkItemsFetchen(int id)
        {
            switch (id)
            {
                case 1:
                    // 1: alleen ongevalideerde Workitems ophalen
                    return FetchValidators();
                case 2:
                    // 2: Haal verlopen items op
                    return FetchExpiredDates();
                default:
                    // Als er een ander getal of woord ingegeven is dan 1 of 2 dan komt het programma hierop uit
                    return null;
            }


        }

        private static List<Object> FetchValidators()
        {
            // In database staat 0 voor ongevalideerd
            string ongevalideerd = "0";
            List<Object> Lijstje = new List<Object>();

            // Geef aan met welke database de linq querry wordt uitgevoerd
            using (DBModelContainer db = new DBModelContainer())
            {
                // initaliseren van de lijst voor ongevalideerde workitems en een linq query on
                // deze workitems uit de database te halen
                IQueryable Workitems;
                Workitems = (from item in db.PRODs where item.Prod_Validator == ongevalideerd select item.Prod_Name);

                // parser om linq querryable om te zetten naar lijst met PRODs
                foreach (var item in Workitems)
                {
                    Lijstje.Add(item);
                }

                // return Lijst met ongevalideerde workitems
                return Lijstje;
            }
        }

        private static List<Object> FetchExpiredDates()
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                List<Object> FetchedItems = new List<Object>();
                TimeSpan t = new TimeSpan(365 * 3);
                var FetchedItemsQuery = (from item in db.PRODs where item.Prod_Val_Dat == DateTime.Today select item.Prod_Name);

                foreach (var item in FetchedItemsQuery)
                {
                    FetchedItems.Add(item);
                }

                return FetchedItems;
            }
        }
    }
}

