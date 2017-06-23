using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Events
{
    public class ShowEvents
    {
        public static IList<EVENT> GetEvents(int Events_Amounts)
        {
            var events_max_amount = 0;
            var events_counter = 0;

            var Event_List = new List<EVENT>();
            using (DBModelContainer db = new DBModelContainer())
            {
                events_max_amount = (from events in db.EVENTs where events.Event_Id >= 1 select events.Event_Id).Max();
                events_counter = (from events in db.EVENTs where events.Event_Id >= 1 select events.Event_Id).Count();

                if (Events_Amounts > events_counter)
                {
                    Events_Amounts = events_counter;
                }

                while (Events_Amounts > Event_List.Count)
                {
                    try
                    {
                        var current_Event_Query = db.EVENTs.Where(event_db => event_db.Event_Id == events_max_amount);
                        var current_Event = current_Event_Query.FirstOrDefault();
                        if (current_Event != null)
                        {
                            var grab_event = new JsonEvents();
                            grab_event.ID = current_Event.Event_Id.ToString();
                            grab_event.Name = current_Event.Event_Name;
                            grab_event.Body = current_Event.Event_Body;
                            grab_event.Address = current_Event.Event_Address;
                            grab_event.Link = current_Event.Event_Link;
                            Event_List.Add(current_Event);
                        }
                        events_max_amount -= 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return Event_List;
            }
        }
    }
}