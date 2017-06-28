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
            string jsonObject = actionContext.Request.Content.ReadAsStringAsync().Result;
            JsonWorkitem deserializedDummyProduct = JsonConvert.DeserializeObject<JsonWorkitem>(jsonObject);

            // Get session token from http call headers
            string Token = actionContext.Request.Headers.GetValues("Token").First();

            // Create dummy product
            PRODs dummyproduct = new PRODs()
            {
                //variabelen toevoegen
                Prod_ID = deserializedDummyProduct.product_id,
                Prod_Name = deserializedDummyProduct.product_name,
                Prod_Dat = deserializedDummyProduct. product_date,
                Prod_Size = deserializedDummyProduct.product_size,
                Prod_Weight = deserializedDummyProduct.product_weight,
                Prod_Cost = deserializedDummyProduct.product_cost,
                Prod_Covered = deserializedDummyProduct.product_covered,
                Prod_Avail = deserializedDummyProduct.product_availability,
                Prod_Desc = deserializedDummyProduct.product_description,
                Prod_Spec = deserializedDummyProduct.product_specification,
                Prod_Req = deserializedDummyProduct.product_requirements,
                Prod_Mov = deserializedDummyProduct.product_movie,
                Prod_Views = deserializedDummyProduct.product_views,
                Prod_Val_Dat = deserializedDummyProduct.product_validation_date
            };

            using(DBModelContainer db = new DBModelContainer())
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

            // return dingetje
            return "Dummy data created";
        }
    }
}