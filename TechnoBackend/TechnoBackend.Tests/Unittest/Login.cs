using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;

namespace TechnoBackend.Tests
{
    [TestClass]
    public class UsecaseLogin
    {
        [TestMethod]
        public static string TestMethodLogin()
        {
            string test = "{ 'Username':'Henk','Password':'Knabbel'}";
            var iets = Encoding.UTF8.GetBytes(test);
            var request = WebRequest.CreateHttp("http://localhost:51516/api/Authentication");
            request.Method = "POST";
            var stream = request.GetRequestStream();
            stream.Write(iets, 0, iets.Length);
            var response = request.GetResponse();
            var result = response.Headers.GetValues("Token").First();
            Assert.AreEqual(100, result.Length);
            return result;
        }
        [TestMethod]
        public void TestMethodLoginWrong()
        {
            string test = "{ 'Username':'Henk','Password':'Knabbe'}";
            var iets = Encoding.UTF8.GetBytes(test);
            var request = WebRequest.CreateHttp("http://localhost:51516/api/Authentication");
            request.Method = "POST";
            var stream = request.GetRequestStream();
            stream.Write(iets, 0, iets.Length);
                
            Assert.ThrowsException<WebException>(() =>
            {
                var response = request.GetResponse();
            });
        }
    }
}