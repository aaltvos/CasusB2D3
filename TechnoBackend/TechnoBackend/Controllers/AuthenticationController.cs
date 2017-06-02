﻿using System.Collections.Generic;
using TechnoBackend.DatabaseModel;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using TechnoBackend.Login;

namespace TechnoBackend.Controllers
{
    public class AuthenticationController : ApiController
    {
        [BasicAuthentication]
        public HttpResponseMessage Get()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;

            return Request.CreateResponse(SessionCheck.GetToken(username));
        }

        // GET: api/Authentication/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Authentication
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Authentication/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Authentication/5
        public void Delete(int id)
        {
        }
    }
}
