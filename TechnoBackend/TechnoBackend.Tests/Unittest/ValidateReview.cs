using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

/**
 * @Author Patrick
 * */
namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class ValidateReview
    {
        [TestMethod]
        public void TestValidateReviewLoadAllEmpty()
        {
            var call = WebRequest.CreateHttp("http://localhost:51516/api/ValidateReview");
            call.Method = "GET";
            call.Headers.Add("Token", UsecaseLogin.TestMethodLogin());
            
            var response = call.GetResponse();

            string responseText = "";
            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                responseText = reader.ReadToEnd();

            Assert.AreEqual(responseText, "{\"status\":\"Error\", \"message\":\"No WorkItems could be loaded\"}");
        }

        [TestMethod]
        public void TestValidateReviewSelectInvalidId()
        {
            var call = WebRequest.CreateHttp("http://localhost:51516/api/ValidateReview/id=-1");
            call.Method = "GET";
            call.Headers.Add("Token", UsecaseLogin.TestMethodLogin());

            var response = call.GetResponse();

            string responseText = "";
            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                responseText = reader.ReadToEnd();
            
            Assert.AreEqual(responseText, "{\"status\":\"Error\", \"message\":\"Invalid id\"}");
        }

    }

}
