using System;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;

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

            JArray Amount_Of_Events = JArray.Parse(responseText);
            var Total_Amount_Of_Events = Amount_Of_Events.Count;
            var value = Total_Amount_Of_Events;    
            Assert.AreEqual(2, value);


        }
    }
}
