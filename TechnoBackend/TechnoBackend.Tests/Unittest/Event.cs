using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TechnoBackend.Business_Logic.Event;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class Event
    {
        [TestMethod]
        public void TestCreateEvent()
        {
            var testDataCreate = "{'EventID':'1', 'EventName':'TestEventName', 'EventBody':'TestEventBody', 'EventAddress':'TestEventAddress', 'EventLink':'TestEventLink'}";
            //string loginData = "{'UserName':'Henk', 'Password':'Knabbel'}";

            var token = UsecaseLogin.TestMethodLogin();

            var body = UTF8Encoding.UTF8.GetBytes(testDataCreate);
            var testCreateEvent = WebRequest.CreateHttp("http://localhost:51516/api/Event");
            testCreateEvent.Method = "POST";
            testCreateEvent.Headers.Add("Token", token);

            var stream = testCreateEvent.GetRequestStream();
            stream.Write(body, 0, body.Length);

            var response = testCreateEvent.GetResponse();

            var encoding = System.Text.Encoding.UTF8;
            var reader = new StreamReader(response.GetResponseStream(), encoding);
            string ResponseText = reader.ReadToEnd();

            var Expected = "\"Event added succesfully\"";

            Assert.AreEqual(Expected, ResponseText);
        }

        [TestMethod]
        public void TestDeleteNews()
        {
            var token = UsecaseLogin.TestMethodLogin();

        }
    }
}
