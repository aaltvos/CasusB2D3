﻿using System;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class TestShowEvents
    {
        [TestMethod]
        public void Show_Events()
        {
            //Calls the test method login to obtain a token so i get access to see events
            var token = UsecaseLogin.TestMethodLogin();

            //Creates a request to see all the events, the login token will be sended also to verify that user is allowed to see it
            var test_ShowEvents = WebRequest.CreateHttp("http://localhost:51516/api/Events");
            test_ShowEvents.Method = "GET";
            test_ShowEvents.Headers.Add("Token", token);

            //Obtains the event_list from the class ShowEvents and is stored as variable: response
            var response = test_ShowEvents.GetResponse();

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
            Assert.AreEqual(3, expected);
        }
    }
}
