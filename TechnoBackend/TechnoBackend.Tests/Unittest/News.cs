using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Http.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class News
    {
        [TestMethod]
        public void NewsCreate()
        {
            var testdataCreate = "{'ArticleID':'1','ArticleTitle':'Henk','ArticleBody':'Knabbel','ArticleIMG':'IMG','ArticleLINK':'URL'}";
            //string LoginData = "{ 'Username':'Henk','Password':'Knabbel'}";


            var token = UsecaseLogin.TestMethodLogin();

            var body = UTF8Encoding.UTF8.GetBytes(testdataCreate);
            var testCreateNews = WebRequest.CreateHttp("http://localhost:51516/api/News");
            testCreateNews.Method = "POST";
            testCreateNews.Headers.Add("Token",token);
            var stream = testCreateNews.GetRequestStream();
            stream.Write(body,0,body.Length);
            var response = testCreateNews.GetResponse();

            var encoding = Encoding.UTF8;
            var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding);
            string responseText = reader.ReadToEnd();
            

            var expected = "\"Article Added succesfully\"";

            Assert.AreEqual(expected,responseText);



        }
    }
}
