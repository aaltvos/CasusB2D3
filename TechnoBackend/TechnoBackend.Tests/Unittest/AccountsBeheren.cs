using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Net;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class AccountsBeheren
    {
        [TestMethod]
        public void TestMethodNewAccount()
        {
            string AccountData = "{'USER_Name': 'Psyduck', 'USER_PW':'Welkom123', 'USER_Sec': 1}";

            var body = UTF8Encoding.UTF8.GetBytes(AccountData);
            var testNewAccount = WebRequest.CreateHttp("http://localhost:51516/api/AccountsBeheren");
            testNewAccount.Method = "POST";

            var stream = testNewAccount.GetRequestStream();
            stream.Write(body, 0, body.Length);

            //Antwoord !
            var response = (HttpWebResponse)testNewAccount.GetResponse();
            //Verwachte waarde : expected .... en uitkomst is de statuscode van de response !
            var expected = HttpStatusCode.OK;
            var code = response.StatusCode;
            // bla ba

            Assert.AreEqual(expected, code);

        }
    }
}
