using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Http.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TechnoBackend.Business_Logic.Werkoverzicht;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class Werkoverzicht
    {
        [TestMethod]
        public void CreateDummyProduct()
        {

            // add dummy product
            string testData = 
                "{'name':'DummyProduct'," +
                "'date':'"+DateTime.Today.ToString()+"'," +
                "'size':'1234'," +
                "'weight':'1234'," +
                "'covered':'true'," +
                "'availability':'Netherlands'," +
                "'description':'the best test product you will ever see'," +
                "'requirments':'root permission'," +
                "'movie':'/content/movies/dummyproduct.mp4'," +
                "'views':'1'," +
                "'validation_date':'"+DateTime.Today.ToString()+"'}";

            // Fetch token and encode testData
            string token = UsecaseLogin.TestMethodLogin();
            byte[] body = UTF8Encoding.UTF8.GetBytes(testData);

            // load and establish connection
            var connectionRequest = WebRequest.CreateHttp("http://localhost:51516/api/WerkoverzichtTonen");
            connectionRequest.Method = "POST";
            connectionRequest.Headers.Add("Token", token);

            // listen to connection stream
            var connectionStream = connectionRequest.GetRequestStream();
            connectionStream.Write(body, 0, body.Length);

            // get response
            WebResponse connectionResponse = connectionRequest.GetResponse();

            // create reader and read stream
            var connectionReader = new StreamReader(connectionResponse.GetResponseStream(), Encoding.UTF8);

            // assert data
            var expected = "\"Dummy data created\"";
            Assert.AreEqual(expected, connectionReader.ReadToEnd());
        }



        [TestMethod]
        public void TestDummyProduct()
        {

            // Fetch token
            string token = UsecaseLogin.TestMethodLogin();
            string productName = "DummyProduct";

            // load and establish connection
            var connectionRequest = WebRequest.CreateHttp("http://localhost:51516/api/WerkoverzichtTonen");
            connectionRequest.Method = "GET";
            connectionRequest.Headers.Add("Token", token);
            connectionRequest.Headers.Add("ProductName", productName);

            // get response
            var connectionResponse = connectionRequest.GetResponse();

            // create reader and read stream
            var connectionReader = new StreamReader(connectionResponse.GetResponseStream(), Encoding.UTF8);
            string response = connectionReader.ReadToEnd();
            var responseList = JsonConvert.DeserializeObject<Workitem[]>(response);

            // expected result
            var responseItem = responseList.First();
            string expected = responseItem.product_name;
            
            // compare fetched data with test data
            Assert.AreEqual(expected, productName);
        }



        [TestMethod]
        public void DeleteDummyProduct()
        {

            // Fetch token and encode testData
            string token = UsecaseLogin.TestMethodLogin();
            string productName = "DummyProduct";

            // load and establish connection
            HttpWebRequest connectionRequest = WebRequest.CreateHttp("http://localhost:51516/api/WerkoverzichtTonen");
            connectionRequest.Method = "DELETE";
            connectionRequest.Headers.Add("Token", token);
            connectionRequest.Headers.Add("ProductName", productName);

            // get response
            WebResponse connectionResponse = connectionRequest.GetResponse();

            // create reader and read stream
            StreamReader connectionReader = new StreamReader(connectionResponse.GetResponseStream(), Encoding.UTF8);

            // expected result
            string expected = "\"Dummyproduct deleted succesfully\"";

            // Assert expected wtih received data
            Assert.AreEqual(expected, connectionReader.ReadToEnd());
        }
    }
}
