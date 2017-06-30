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
        // Create a dummy product in database for unit test
        public static string CreateDummyProduct(HttpActionContext actionContext)
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

            // Commit and save the dummy product to the database
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

            // return dingetje
            return "Dummy data created";
        }


        // test method to fetch the dummyproduct that was created in previous method
        public static Object TestDummyProduct(HttpActionContext actionContext)
        {
            string productName = actionContext.Request.Headers.GetValues("ProductName").First();
            
            using (DBModelContainer db = new DBModelContainer())
            {
                List<Workitem> WorkitemList = new List<Workitem>();

                try
                {
                    // fetch all products with the name DummyProduct
                    IQueryable<PRODs> dummyproducts = db.PRODs.Where(s => s.Prod_Name == productName);

                    foreach (var fetcheddummyproduct in dummyproducts)
                    {
                        Workitem dummyproduct = new Workitem(
                            fetcheddummyproduct.Prod_ID,
                            fetcheddummyproduct.Prod_Name,
                            fetcheddummyproduct.Prod_Dat,
                            fetcheddummyproduct.Prod_Size,
                            fetcheddummyproduct.Prod_Weight,
                            fetcheddummyproduct.Prod_Cost,
                            fetcheddummyproduct.Prod_Covered,
                            fetcheddummyproduct.Prod_Avail,
                            fetcheddummyproduct.Prod_Desc,
                            fetcheddummyproduct.Prod_Spec,
                            fetcheddummyproduct.Prod_Req,
                            fetcheddummyproduct.Prod_Mov,
                            fetcheddummyproduct.Prod_Views,
                            fetcheddummyproduct.Prod_Val_Dat);
                        WorkitemList.Add(dummyproduct);
                    }
                }
                catch (Exception e)
                {
                    return e.ToString();
                }

                //return PRODs object
                return WorkitemList;
            }
        }

        // test method to delete the dummyproduct that was created in previous in first method
        public static object DeleteDummyProduct(HttpActionContext actionContext)
        {
            // desired response
            string DesiredResponse = "Dummyproduct deleted succesfully";
            string UndesiredResponse = "Dummyproduct could not be found";
            string productName = actionContext.Request.Headers.GetValues("ProductName").First();

            using (DBModelContainer db = new DBModelContainer())
            {
                IQueryable<PRODs> dummyproducts = db.PRODs.Where(s => s.Prod_Name == productName);

                if (dummyproducts.FirstOrDefault() != null)
                {
                    try
                    {
                        foreach (var dummyproduct in dummyproducts)
                        {
                            db.PRODs.Remove(dummyproduct);
                        }
                    }
                    catch (Exception e)
                    {
                        return e;
                    }
                }

                // return desired response
                return DesiredResponse;
            }

            // return desired response
            return UndesiredResponse;
        }
    }
}