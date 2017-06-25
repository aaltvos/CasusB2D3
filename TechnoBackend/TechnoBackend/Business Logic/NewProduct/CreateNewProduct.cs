using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.Login;
using TechnoBackend.DatabaseModel;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using System.Net;

namespace TechnoBackend.Business_Logic.NewProduct
{
    public class CreateNewProduct
    {
        public static HttpStatusCode addProduct(HttpActionContext actionContext)
        {
            DBModelContainer db = new DBModelContainer();
            var json = actionContext.Request.Content.ReadAsStringAsync().Result;
            JsonProduct jsonProduct = JsonConvert.DeserializeObject<JsonProduct>(json);

            //string Token = actionContext.Request.Headers.GetValues("Token").First();

            
            //var UserID = (from sessions in db.SESSIONS where sessions.SESSIONS_Token == Token select sessions.USER_Id.USER_Id).First();
            //var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
            //var currentUser = CurrentUserQuery.FirstOrDefault<USERs>();

            PRODs product = new PRODs()
            {
                Prod_ID = jsonProduct.id,
                Prod_Name = jsonProduct.name,
                Prod_Dat = jsonProduct.date,
                Prod_Size = jsonProduct.size,
                Prod_Weight = jsonProduct.weight,
                Prod_Cost = jsonProduct.cost,
                Prod_Covered = jsonProduct.covered,
                Prod_Avail = jsonProduct.avail,
                Prod_Desc = jsonProduct.description,
                Prod_Spec = jsonProduct.spec,
                Prod_Req = jsonProduct.req,
                Prod_Mov = jsonProduct.movieurl,
                Prod_Views = 0,
                Prod_Validator = "False",
                Prod_Val_Dat = DateTime.Now
            };
            try
            {
                db.PRODs.Add(product);
                db.SaveChanges();
                return HttpStatusCode.OK;
            }
            catch
            {
                return HttpStatusCode.InternalServerError;
                
            }

        }
    }
}