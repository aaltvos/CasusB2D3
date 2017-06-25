using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnoBackend.Login;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class NewProduct
    {
        [TestMethod]
        public void TestMethodNewProduct()
        {
            string productData = "{'productid':'1','name':'testname','date':'24-06-2017','size':'0x0x0','weight':'0kg','cost':'0Eur','covered':'false','avail':'test','desc':'test','spec':'test','req':'test','mov':'test'}";

            var checkreturn = SessionCheck.GetToken("Henk");
            var token = checkreturn.Item1;

            var body = UTF8Encoding.UTF8.GetBytes(productData);
            var testCreateNewProduct = WebRequest.CreateHttp("http://localhost:51516/api/NewProduct");
            testCreateNewProduct.Method = "POST";
            testCreateNewProduct.Headers.Add("Token", token);
            var stream = testCreateNewProduct.GetRequestStream();
            stream.Write(body, 0, body.Length);
            var response = testCreateNewProduct.GetResponse();

            var expected = HttpStatusCode.OK;

            Assert.AreEqual(response, expected);
        }
    }
}