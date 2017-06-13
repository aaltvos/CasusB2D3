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
        public static string WorkItemsFetchen(int id)
        {
            String TestWorkItems;

            switch (id)
            {
                case 1:
                    return TestWorkItems = FetchValidators();
                case 2:
                    return TestWorkItems = FetchExpiredDates();
                default:
                    return TestWorkItems = "Geen enkele van je ids zijn goede ids";
            }


        }

        private static string FetchValidators()
        {
            return "Fetched all workitems which are not verified!";
        }

        private static string FetchExpiredDates()
        {
            return "Fetched all workitems with an expired date!";
        }
    }
}