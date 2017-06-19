using System;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class News
    {
        [TestMethod]
        public void NewsCreate()
        {
            /*var testdataCreate = "{'ArticleID':'1','ArticleTitle':'Henk','ArticleBody':'Knabbel','ArticleIMG':'IMG','ArticleLINK':'URL'}";
            string LoginData = "{ 'Username':'Henk','Password':'Knabbel'}";

            var checkreturn = SessionCheck.GetToken("Henk");
            var token = checkreturn.Item1;

            var body = UTF8Encoding.UTF8.GetBytes(testdataCreate);
            var testCreateNews = WebRequest.CreateHttp("http://localhost:51516/api/News");
            testCreateNews.Method = "POST";
            testCreateNews.Headers.Add("Token",token);
            var stream = testCreateNews.GetRequestStream();
            stream.Write(body,0,body.Length);
            var response = testCreateNews.GetResponse();

            //TODO: Decode response message to get body


            var expected = "Article Added succesfully";

            Assert.AreEqual(response,expected);


    */
        }
    }
}
