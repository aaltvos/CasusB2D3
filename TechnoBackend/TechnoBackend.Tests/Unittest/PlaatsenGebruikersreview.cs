using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Net;
using System.Linq;
using System.Diagnostics;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class PlaatsenGebruikersreview
    {
        [TestMethod]
        public void TestGebruikersreviewPlaatsen()
        {
            string test = "{\"review\": \"testreview testreview testreview\"}";
            var iets = Encoding.UTF8.GetBytes(test);
            var request = WebRequest.CreateHttp("http://localhost:51516/api/GebruikersreviewPlaatsen");
            request.Method = "POST";
            var stream = request.GetRequestStream();
            stream.Write(iets, 0, iets.Length);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Debug.WriteLine("RESPONSE!!!!@!:"+ response);
            var result = response.Headers.Equals(HttpStatusCode.OK);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
