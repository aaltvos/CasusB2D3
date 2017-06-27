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
        DBModelContainer db = new DBModelContainer();
        USERs account = new USERs();



        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        
        public ActionResult PostCreateAccount([FromBody] CreateAccount account)
        {
            if (ModelState.IsValid)
            {

                db.USERs.Add(account);
                db.SaveChanges();
                return "account added";
            }

            return 
        }

        public string CreateAccount()
        {
            
        }

    }
}