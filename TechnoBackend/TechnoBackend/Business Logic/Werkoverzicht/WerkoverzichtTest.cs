using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Werkoverzicht
{
    public class WerkoverzichtTest
    {
        public static string CreateDummyData(HttpActionContext actionContext)
        {
            // Decode json to a workable object
            var json = actionContext.Request.Content.ReadAsStringAsync().Result;
            JsonWorkitem deserializedDummyProduct = JsonConvert.DeserializeObject<JsonWorkitem>(json);

            // Get session token from http call headers
            string Token = actionContext.Request.Headers.GetValues("Token").First();

            // Create dummy product
            PRODs dummyproduct = new PRODs()
            {
                //variabelen toevoegen
                Prod_ID = deserializedDummyProduct.product_id,
                Prod_Name = deserializedDummyProduct.product_name

            };

            using (DBModelContainer db = new DBModelContainer())
            {
                
            }

            // return dingetje
            return "Dummy data created";
        }
    }
}