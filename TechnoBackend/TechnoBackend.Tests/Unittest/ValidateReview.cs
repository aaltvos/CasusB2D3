using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Text;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class ValidateReview
    {
        [TestMethod]
        public void LoadAll()
        {
            string data = "{}";
            
            var body = UTF8Encoding.UTF8.GetBytes(data);
            var testCreateNews = WebRequest.CreateHttp("http://localhost:51516/api/ValidateReview");
            testCreateNews.Method = "GET";
            testCreateNews.Headers.Add("Token", "TOKENNN");

            var stream = testCreateNews.GetRequestStream();
            stream.Write(body, 0, body.Length);
            var response = testCreateNews.GetResponse();
        }

    }

}
