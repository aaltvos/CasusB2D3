using System;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class TestShowEvents
    {
        [TestMethod]
        public void Show_Events()
        {
            var token = UsecaseLogin.TestMethodLogin();
            var test_ShowEvents = WebRequest.CreateHttp("http://localhost:51516/api/Events");
            test_ShowEvents.Method = "GET";
            test_ShowEvents.Headers.Add("Token", token);
            var response = test_ShowEvents.GetResponse();

            var encoding = Encoding.UTF8;
            var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding);
            string responseText = reader.ReadToEnd();

            var expected = "dssd";
            
            Assert.AreEqual(expected, responseText);
        }
    }
}
