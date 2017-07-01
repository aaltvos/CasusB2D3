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
        //POST
        public HttpResponseMessage Post()
        {
            var message = NewAccount.CreateAccount(ActionContext);
            var response = Request.CreateResponse(message);

            return response;
        }

        public HttpResponseMessage Delete(int id)
        {
            var message = OldAccount.DeleteAccount(id);
            var response = Request.CreateResponse(message);
            return response;
        }
    }
}