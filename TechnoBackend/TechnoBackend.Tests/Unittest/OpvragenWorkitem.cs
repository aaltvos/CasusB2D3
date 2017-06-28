using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Collections.Generic;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class OpvragenWorkitem
    {
        [TestMethod]
        public void OphalenVanDezeZjwik()
        {
            var request = WebRequest.CreateHttp("http://localhost:51516/api/WorkitemOpvragen");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            var code = response.StatusCode;

            Assert.AreEqual(HttpStatusCode.OK,code);
           }
    }
}
