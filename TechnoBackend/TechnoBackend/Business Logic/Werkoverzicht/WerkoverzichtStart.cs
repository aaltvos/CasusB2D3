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
        public static Workitems WorkItemsFetchen(int id)
        {
            switch (id)
            {
                case 1:
                    // 1: alleen ongevalideerde Workitems ophalen
                    return FetchValidators();
                //case 2:
                //    // 2: Haal verlopen items op
                //    return FetchExpiredDates();
                default:
                    // Als er een ander getal of woord ingegeven is dan 1 of 2 dan komt het programma hierop uit
                    return null;
            }
        }


        private static Workitems FetchValidators()
        {
            IQueryable WorkitemsIQueryable;
            IQueryable StudentIdsIQueryable;
            List<Object> WorkitemList = new List<Object>();

            // Geef aan met welke database de linq querry wordt uitgevoerd
            using (DBModelContainer db = new DBModelContainer())
            {
                // Querry database for all student ids
                StudentIdsIQueryable = (from id in db.USERs where id.USER_Sec == 3 select id.USER_Id);

                //Ga door iedere naam om correspondeerende workitems eruit te halen
                foreach (var id in StudentIdsIQueryable)
                {

                    // Selected id in the foreach gets querried trough the database
                    WorkitemsIQueryable = (from item in db.PRODs where item.Prod_Val_User == id select item.Prod_Name);

                    try
                    {
                        foreach (var item in WorkitemsIQueryable)
                        {
                            try
                            {
                                JsonWorkitem workitem = new JsonWorkitem(id, item);
                                WorkitemList.Add(workitem);
                            }
                            catch (Exception ex)
                            {
                                continue;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }

                }
                // create workitems object with workitemList
                Workitems Workitems = new Workitems(WorkitemList);

                // return Lijst met ongevalideerde workitems
                return Workitems;
            }
        }


        //private static List<PRODs> FetchExpiredDates()
        //{
        //    using (DBModelContainer db = new DBModelContainer())
        //    {
        //        List<PRODs> FetchedItems = new List<PRODs>();
        //        var FetchedItemsQuery = db.PRODs.Where(s => s.Prod_Val_Dat == DateTime.Today);

        //        foreach (var item in FetchedItemsQuery)
        //        {
        //            FetchedItems.Add(item);
        //        }

        //        return FetchedItems;
        //    }
        //}



        //// This function fetches all Student IDs
        //private static IQueryable fetchStudentIds()
        //{
        //    IQueryable StudentIdsIQueryable;
        //    List<Object> StudentIds = new List<object>();

        //    // Ongevalideerd voor de supervisor is als Prod_Validator == aan een naam van een student
        //    using (DBModelContainer db = new DBModelContainer())
        //    {
        //        // Querry database for all student ids
        //        StudentIdsIQueryable = (from id in db.USERs where id.USER_Sec == 3 select id.USER_Id);

        //        // Cast from IQueryable to an Object List
        //        foreach (var id in StudentIdsIQueryable)
        //        {
        //            StudentIds.Add(id);
        //        }
        //    }

        //    return StudentIdsIQueryable;
        //}
    }
}

