using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Reflection.Emit;
using System.Web.WebPages;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Login;
using TechnoBackend.Business_Logic.ProductaanvraagUpdaten;

namespace TechnoBackend.Controllers
{
    public class ProductaanvraagBeoordelenController : ApiController
    {
        // GET api/<controller>
        public HttpResponseMessage Get(int Product_ID)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 1)
            {
                try
                {
                    var message = ProductaanvraagUpdaten.Productaanvraag_Updaten(Product_ID, token); 
                    Request.Headers.Add("Token", newtoken.Item1);
                    var response = Request.CreateResponse(message);
                    return response;
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Session not found");

            //DBModelContainer db = new DBModelContainer();
            //List<PRODs> OnbeoordeeldeProductaanvragen = new List<PRODs>();
            //var OnbeoordeeldeProductaanvragenQuery = db.PRODs.Where(User_Sec.Prod_Val_User < 3);
            //foreach (var OP in OnbeoordeeldeProductaanvragenQuery)
            //{
            //    OnbeoordeeldeProductaanvragen.Add(OP);
            //}
            //return OnbeoordeeldeProductaanvragen;
        }

        // PUT api/<controller>/5
        
            /*
        public HttpResponseMessage Get(int Prod_ID)
        {
            var token = ActionContext.Request.Headers.GetValues("Token").First();
            var newtoken = SessionCheck.Check(token);
            if (newtoken.Item1 != "no session" && newtoken.Item2 >= 1)
            {
                var message = WerkoverzichtStart.WorkItemsFetchen(id);
                Request.Headers.Add("Token", newtoken.Item1);
                var response = Request.CreateResponse(message);
                return response;
            }
            return Request.CreateResponse("Invalid action");
        }*/
    }
}