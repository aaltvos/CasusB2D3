using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace TechnoBackend.Tests
{
    [TestClass]
    public class UsecaseLogin
    {
        [TestMethod]
        public void TestMethodLogin()
        {

            var request = WebRequest.CreateHttp("http://localhost:51516/api/Authentication");
            request.Headers.Add("authorization", "Basic SGVuazpLbmFiYmVs");

            var response = request.GetResponse();
            var expected = "\"AuthenticationResponse\"";

            Stream receiveStream = response.GetResponseStream();
            Encoding encode = Encoding.GetEncoding("utf-8");
            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader derp = new StreamReader(receiveStream, encode);
            string result = derp.ReadToEnd();
            Assert.AreEqual(expected, result);
        }
    }
}