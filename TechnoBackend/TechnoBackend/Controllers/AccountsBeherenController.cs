using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using TechnoBackend.Business_Logic.Accounts_Beheren;
using TechnoBackend.DatabaseModel;


namespace TechnoBackend.Controllers
{
    public class AccountsBeherenController : ApiController
    {
        // POST 
        public HttpResponseMessage Post()
        {
                    try
                    {
                        var message = NewAccount.CreateAccount();
                        var response = Request.CreateResponse(message);
                        return response;
                    }
                    catch (Exception ex)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                    }
        }

        //Delete
        public HttpResponseMessage Delete(int id)
        {
            var message = OldAccount.DeleteAccount(id);
            var response = Request.CreateResponse(message);
            return response;
        }
    }
}