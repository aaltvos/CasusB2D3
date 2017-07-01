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
            //var UserID = (from sessions in db.SESSIONS select sessions.USER_Id.USER_Id).First(); //where sessions.SESSIONS_Token == Token 
            //var CurrentUserQuery = db.USERs.Where(s => s.USER_Id == UserID);
            //var currentUser = CurrentUserQuery.FirstOrDefault<USERs>();
            USERs user = new USERs()
            {
                USER_PW = "somepassword",
                USER_Name = "Kay",
                USER_Id = 1,
                USER_Email = "example@example.com",
                USER_Sec = 3,
                USER_Val_dat = DateTime.Now,
                USER_Made_Work = "string"
            };
            //USERs user = (from x in db.USERs where x.USER_Name == "Kay" select x).First();
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
                Prod_Val_Dat = DateTime.Parse(json.valdate),
                Prod_Val_User = user
            };
            try
            {
                db.PRODs.Add(product);
                db.SaveChanges();
            }
            catch
            {
                return HttpStatusCode.InternalServerError;
            }
            sendEmail newEmail = new sendEmail();
            newEmail.sendAll(3);
            return HttpStatusCode.OK;
        }
    }
}