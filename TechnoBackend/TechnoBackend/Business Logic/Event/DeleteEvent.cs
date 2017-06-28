using System;
using System.Linq;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Event
{
    public class DeleteEvent
    {
        public static string _DeleteEvent(int eventid)
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                var currentEvent = db.EVENTs.Where(s => s.Event_Id == eventid).FirstOrDefault();
                if (currentEvent != null)
                {
                    db.EVENTs.Remove(currentEvent);
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        return (e.ToString());
                    }
                    return ("Event with ID: " + eventid + "has been removed");
                }
                return ("The Event could not be found in the database");
            }
        }
    }
}