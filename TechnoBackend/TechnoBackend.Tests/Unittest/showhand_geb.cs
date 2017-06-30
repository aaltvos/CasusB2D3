using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class showhand_geb
    {
        [TestMethod]
        public void showhandgeb()
        {
            //Calls the test method login to obtain a token so i get access to see events
            var token = UsecaseLogin.TestMethodLogin();
        
            var test_showhandgeb = WebRequest.CreateHttp("http://localhost:51516/api/Productzoekenenfilteren");
            test_showhandgeb.Method = "GET";
            test_showhandgeb.Headers.Add("Token", token);

            //Obtains the event_list from the class ShowEvents and is stored as variable: response
            var response = test_showhandgeb.GetResponse();

            //The event_list gets encoded so its readable and is stored as variable: responseText
            var encoding = Encoding.UTF8;
            var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding);
            string responseText = reader.ReadToEnd();

            //The variable: responseText gets changed to a array so its possible to count the amount of events
            //The counted outcome will be stored in variable: expected
            JArray amount_of_events = JArray.Parse(responseText);
            var total_amount_of_events = amount_of_events.Count;
            var expected = total_amount_of_events;

            //Here will be checked if the amount of the returned event_list is correct
            Assert.AreEqual(7, expected);

        }
        
    }
}
