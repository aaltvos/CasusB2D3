using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class ValidateReview
    {
        [TestMethod]
        public void LoadAll()
        {
            string data = "test123";
            
            var body = UTF8Encoding.UTF8.GetBytes(data);
            var testCreateNews = WebRequest.CreateHttp("http://localhost:51516/api/ValidateReview");
            testCreateNews.Method = "POST";
            testCreateNews.Headers.Add("Token", "TOKENNN");

            var stream = testCreateNews.GetRequestStream();
            stream.Write(body, 0, body.Length);
            var response = testCreateNews.GetResponse();
        }

    }

}
