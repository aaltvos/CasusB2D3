using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Net;
using System.IO;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class Category
    {
        [TestMethod]
        public void CreateCategory()
        {
            string jsondir = "C:/Users/Jim/Source/Repos/CasusB2D3/TechnoBackend/TechnoBackend.Tests/Unittest/CategoryCreate.json";
            StreamReader openfile = new StreamReader(jsondir);
            string json = openfile.ReadToEnd();
            var encoding = Encoding.UTF8.GetBytes(json);
            var request = WebRequest.CreateHttp("http://localhost:51516/api/CategoryBeheren");
            request.Method = "POST";
            var stream = request.GetRequestStream();
            stream.Write(encoding, 0, encoding.Length);

            var response = (HttpWebResponse)request.GetResponse();
            var code = response.StatusCode;
            var expected = HttpStatusCode.OK;
            Assert.AreEqual(expected, code);

        }

        [TestMethod]
        public void DeleteCategory()
        {
            string jsondir = "C:/Users/Jim/Source/Repos/CasusB2D3/TechnoBackend/TechnoBackend.Tests/Unittest/CategoryDelete.json";
            StreamReader openfile = new StreamReader(jsondir);
            string json = openfile.ReadToEnd();
            var encoding = Encoding.UTF8.GetBytes(json);
            var request = WebRequest.CreateHttp("http://localhost:51516/api/CategoryBeheren");
            request.Method = "DELETE";
            var stream = request.GetRequestStream();
            stream.Write(encoding, 0, encoding.Length);

            var response = (HttpWebResponse)request.GetResponse();
            var code = response.StatusCode;
            var expected = HttpStatusCode.OK;
            Assert.AreEqual(expected, code);

        }
    }
}
