using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.EOLDControleren
{
    public class EOLDTest
    {
        public static string CreateDummyData(HttpActionContext actionContext)
        {
            // Decode json to a workable object
            var jsonObject = actionContext.Request.Content.ReadAsStringAsync().Result;
            var deserializedDummyProduct = JsonConvert.DeserializeObject<JsonEOLD>(jsonObject);

            // Get session token from http call headers
            string Token = actionContext.Request.Headers.GetValues("Token").First();


            // Create dummy product
            PRODs dummyproduct = new PRODs()
            {
                //variabelen toevoegen
                Prod_Val_Dat = DateTime.Parse(deserializedDummyProduct.Val_Dat)
            };

            using (DBModelContainer db = new DBModelContainer())
            {
                try
                {
                    db.PRODs.Add(dummyproduct);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }

            return "Dummy data created";
        }
    }
}