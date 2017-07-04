using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Http.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TechnoBackend.Business_Logic.EOLDControleren;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class EOLDC
    {
        [TestMethod]
        public void CreateDummyProduct()
        {
            // add dummy product
            string testData =
                "{'validation_date':'" + DateTime.Today.ToString() + "'}";

            // Fetch token and encode testData
            string token = UsecaseLogin.TestMethodLogin();
            byte[] body = UTF8Encoding.UTF8.GetBytes(testData);

            // load and establish connection
            var connectionRequest = WebRequest.CreateHttp("http://localhost:51516/api/EOLDC");
            connectionRequest.Method = "POST";
            connectionRequest.Headers.Add("Token", token);

            // listen to connection stream
            var connectionStream = connectionRequest.GetRequestStream();
            connectionStream.Write(body, 0, body.Length);

            // get response
            var connectionResponse = connectionRequest.GetResponse();

            // create reader and read stream
            var connectionReader = new StreamReader(connectionResponse.GetResponseStream(), Encoding.UTF8);

            // assert data
            var expected = "\"Dummy data created\"";
            Assert.AreEqual(expected, connectionReader.ReadToEnd());
        }

        //public static string TestDummyProduct()
        //{
        //    // load and establish connection

        //    // assert data

        //    // compare fetched data with test data
        //    return "placeholder";        
        //}

        //public void DeleteDummyProduct()
        //{
        //    // load and establish connection

        //    // assert data

        //    // delete dummy product
        //}

    }


}
