using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Net;
using System.Linq;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class PlaatsenGebruikersreview
    {
        [TestMethod]
        public static bool TestMethodGebruikersreviewPlaatsen()
        { 
            string test = "testreview testreview testreview";
            var iets = Encoding.UTF8.GetBytes(test);
            var request = WebRequest.CreateHttp("http://localhost:51516/api/GebruikersreviewPlaatsen");
            request.Method = "POST";
            var stream = request.GetRequestStream();
            stream.Write(iets, 0, iets.Length);

            var response = request.GetResponse();

            var result = response.Headers.Equals(HttpStatusCode.OK);
            
            return result;
        }
}
}
