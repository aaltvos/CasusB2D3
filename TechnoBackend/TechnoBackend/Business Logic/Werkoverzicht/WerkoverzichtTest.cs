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
            var jsonObject = actionContext.Request.Content.ReadAsStringAsync().Result;
            var deserializedDummyProduct = JsonConvert.DeserializeObject<JsonWorkitem>(jsonObject);
            
            // Get session token from http call headers
            string Token = actionContext.Request.Headers.GetValues("Token").First();


            // Create dummy product
            PRODs dummyproduct = new PRODs()
            {
                //variabelen toevoegen
                Prod_Name = deserializedDummyProduct.Name,
                Prod_Dat = DateTime.Parse(deserializedDummyProduct.Dat),
                Prod_Size = deserializedDummyProduct.Size,
                Prod_Weight = deserializedDummyProduct.Weight,
                Prod_Cost = deserializedDummyProduct.Cost,
                Prod_Covered = deserializedDummyProduct.Covered,
                Prod_Avail = deserializedDummyProduct.Avail,
                Prod_Desc = deserializedDummyProduct.Desc,
                Prod_Spec = deserializedDummyProduct.spec,
                Prod_Req = deserializedDummyProduct.Req,
                Prod_Mov = deserializedDummyProduct.Mov,
                Prod_Views = deserializedDummyProduct.Views,
                Prod_Val_Dat = DateTime.Parse(deserializedDummyProduct.Val_Dat)
            };

            using(DBModelContainer db = new DBModelContainer())
            {

                IQueryable<USERs> Leveranciers = db.USERs.Where(s => s.USER_Sec == 2);
                USERs leverancier = Leveranciers.First();
                dummyproduct.Prod_Val_User = 

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