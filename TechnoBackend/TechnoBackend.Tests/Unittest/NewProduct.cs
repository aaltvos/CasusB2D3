using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnoBackend.Login;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class NewProduct
    {
        [TestMethod]
        public void ProductNew()
        {
            string jsondir = "F:/Development/Github/CasusB2D3/TechnoBackend/TechnoBackend.Tests/Unittest/newProduct.json";
            StreamReader openfile = new StreamReader(jsondir);
            string json = openfile.ReadToEnd();
            var jsonasbyte = Encoding.UTF8.GetBytes(json);
            var request = WebRequest.CreateHttp("http://localhost:51516/api/NewProduct");
            request.Method = "POST";
            var stream = request.GetRequestStream();
            stream.Write(jsonasbyte, 0, json.Length);


            var response = (HttpWebResponse)request.GetResponse();
            var responseCode = response.StatusCode;
            var expected = HttpStatusCode.OK;
            Assert.AreEqual(responseCode, expected);
        }
    }
}
// getest op 27-06-17