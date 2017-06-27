using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using TechnoBackend.Business_Logic.ProfielBewerken;


namespace TechnoBackend.Business_Logic.ProfielBewerken
{
    public class ProfielBewerken
    {
        private static List<Object> getCurrentDetails()
        {

            List<Object> userDetails = new List<Object>();

            // Geef aan met welke database de linq querry wordt uitgevoerd
            using (DBModelContainer db = new DBModelContainer())
            {
                string Token = waar vandaan ?; 
                


                int USER_Id = (from i in db.SESSIONS where i.SESSIONS_Token = Token select i.SESSIONS.USER_Id)

                // parser om linq querryable om te zetten naar lijst met PRODs
                foreach (var item in Workitems)
                {
                    Lijstje.Add(item);
                }

                // return Lijst met ongevalideerde workitems
                return Lijstje;
            }
        }



    }
}


//[USER_Id] int IDENTITY(1,1) NOT NULL,

//[USER_Name] nvarchar(max)  NOT NULL,

//[USER_PW] nvarchar(max)  NOT NULL,

//[USER_Sec] int NOT NULL,
//    [USER_Val_dat] datetime NOT NULL