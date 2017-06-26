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
            JsonProduct json = JsonConvert.DeserializeObject<JsonProduct>(actionContext.Request.Content.ReadAsStringAsync().Result);
            //string Token = actionContext.Request.Headers.GetValues("Token").First();
            //var UserID = (from sessions in db.SESSIONS where sessions.SESSIONS_Token == Token select sessions.USER_Id.USER_Id).First();
            //var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
            //var currentUser = CurrentUserQuery.FirstOrDefault<USERs>();

            PRODs product = new PRODs()
            {
                Prod_ID = json.id,
                Prod_Name = json.name,
                Prod_Dat = DateTime.Parse(json.date),
                Prod_Size = json.size,
                Prod_Weight = json.weight,
                Prod_Cost = json.cost,
                Prod_Covered = json.covered,
                Prod_Avail = json.avail,
                Prod_Desc = json.description,
                Prod_Spec = json.spec,
                Prod_Req = json.req,
                Prod_Mov = json.movieurl,
                Prod_Views = json.views,
                Prod_Val_Dat = DateTime.Parse(json.valdate)
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