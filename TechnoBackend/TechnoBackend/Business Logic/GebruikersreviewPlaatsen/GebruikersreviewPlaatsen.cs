using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;
using System.Diagnostics;
using System.Net;
using System.Web.Http.Controllers;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.GebruikersreviewPlaatsen
{ 
    public static class Review
    {
        // private static readonly PRODs ;
        //private Review(Int32 productId, Int32 UserId, string ReviewText)
        //{
        //    Int32 _productId = productId;
        //    Int32 _UserId = UserId;
        //    string _ReviewText = ReviewText;
        //}
        public static HttpStatusCode CreateReview(HttpActionContext actionContext) //string token
        {
            using (DBModelContainer database = new DBModelContainer())
            {
                //querry for most recent review
                int RevId;
                try
                {
                    RevId = Convert.ToInt32(database.REVs.OrderByDescending(u => u.REV_ID).FirstOrDefault());
                }
                catch
                {
                    RevId = 0; 
                }

                Jsonreview json = JsonConvert.DeserializeObject<Jsonreview>(actionContext.Request.Content.ReadAsStringAsync().Result);
                database.REVs.Add(new REVs()
                {
                    REV_ID = RevId,
                    REV_text = json.review
                });
                try
                {
                    database.SaveChanges();
                    return HttpStatusCode.OK;
                }
                catch
                {
                    return HttpStatusCode.InternalServerError;
                }
            }
        }
    }
}