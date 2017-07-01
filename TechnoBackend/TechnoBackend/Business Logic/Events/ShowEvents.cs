using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Events
{
    public class ShowEvents
    {
        //All the data from the database table Events are stored in a list called event_list
        public static IList<JsonEvents> GetEvents()
        {
            List<JsonEvents> event_list = new List<JsonEvents>();
            using (DBModelContainer db = new DBModelContainer())
            {
                foreach (var i in db.EVENTs)
                {
                    JsonEvents grab_event = new JsonEvents();
                    grab_event.Event_ID = i.Event_Id;
                    grab_event.Event_Name = i.Event_Name;
                    grab_event.Event_Body = i.Event_Body;
                    grab_event.Event_Address = i.Event_Address;
                    grab_event.Event_Link = i.Event_Link;
                    grab_event.USERs_USER_Name = i.USERs.USER_Name;
                    event_list.Add(grab_event);
                }
                return event_list;
            }
        }
    }
}