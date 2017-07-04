using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoBackend.Login;
using TechnoBackend.DatabaseModel;
using TechnoBackend.Business_Logic.ProductaanvraagUpdaten;
using System.Net;
using System.IO;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class BeoordelenProductaanvraag
    {
        [TestMethod]
        public void Productaanvraag_Updaten(int Product_ID, string token)
        {
            //TestData aanmaken
            var TestProductCreate = "{'Product_ID':'6'}";

            //TestToken verkrijgen
            var testtoken = UsecaseLogin.TestMethodLogin();


            var body = UTF8Encoding.UTF8.GetBytes(TestProductCreate);
            var testCreateNews = WebRequest.CreateHttp("http://localhost:51516/api/BeoordelenProductaanvraag");
            testCreateNews.Method = "POST";
            testCreateNews.Headers.Add("Token", testtoken);
            var stream = testCreateNews.GetRequestStream();
            stream.Write(body, 0, body.Length);
            var response = testCreateNews.GetResponse();

            var encoding = Encoding.UTF8;
            var reader = new StreamReader(response.GetResponseStream(), encoding);
            string responseText = reader.ReadToEnd();

            //Het resultaat.
            var expected = "\"Het product is beoordeeld\"";

            //Vergelijking resultaten.
            Assert.AreEqual(expected, responseText);



        }
    }
}
