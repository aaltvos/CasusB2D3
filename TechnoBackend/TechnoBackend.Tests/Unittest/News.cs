using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Http.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TechnoBackend.Business_Logic.News;

namespace TechnoBackend.Tests.Unittest
{
    [TestClass]
    public class News
    {
        [TestMethod]
        public void NewsCreate()
        {
            var testdataCreate = "{'ArticleID':'1','ArticleTitle':'testCreateNewsTitle','ArticleBody':'testCreateNewsBody','ArticleIMG':'testCreateNewsImg','ArticleLINK':'testCreateNewsUrl'}";
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
            var reader = new StreamReader(response.GetResponseStream(), encoding);
            string responseText = reader.ReadToEnd();
            

            var expected = "\"Article Added succesfully\"";

            Assert.AreEqual(expected,responseText);



        }

        [TestMethod]
        public JsonNews[] testShowNews(int skip = 1)
        {
            var token = UsecaseLogin.TestMethodLogin();
            if (skip == 0)
            {
                NewsCreate();
                NewsCreate();
                NewsCreate();
            }
            

            var testCreateNews = WebRequest.CreateHttp("http://localhost:51516/api/News/3");
            testCreateNews.Method = "GET";
            testCreateNews.Headers.Add("Token", token);
            var response = testCreateNews.GetResponse();

            var encoding = Encoding.UTF8;
            var reader = new StreamReader(response.GetResponseStream(), encoding);
            string responseText = reader.ReadToEnd();
            var responselist =  JsonConvert.DeserializeObject<JsonNews[]>(responseText);
            int expected = 3;
            Assert.AreEqual(expected,responselist.Count());
            return responselist;
        }

        [TestMethod]
        public void DeleteNews()
        {
            var beforeMax = maxarticle();
            var token = UsecaseLogin.TestMethodLogin();
            //If running together with test show news set test show news to 1 otherwise to 0
            var toBeDeleted = testShowNews(0);
            foreach (var article in toBeDeleted)
            {
                var testCreateNews = WebRequest.CreateHttp("http://localhost:51516/api/News/" + article.ID);
                testCreateNews.Method = "DELETE";
                testCreateNews.Headers.Add("Token", token);
                var response = testCreateNews.GetResponse();

                var encoding = Encoding.UTF8;
                var reader = new StreamReader(response.GetResponseStream(), encoding);
                string responseText = reader.ReadToEnd();
                var expected = "\"Article with ID :" + article.ID + "has been deleted\"";
             
                Assert.AreEqual(expected, responseText);
            }
            var afterMax = maxarticle();
            Assert.AreEqual(Convert.ToInt32(beforeMax),Convert.ToInt32(afterMax));
        }

        public string maxarticle()
        {
            var token = UsecaseLogin.TestMethodLogin();
            var testCreateNews = WebRequest.CreateHttp("http://localhost:51516/api/News/");
            testCreateNews.Method = "GET";
            testCreateNews.Headers.Add("Token", token);
            var response = testCreateNews.GetResponse();

            var encoding = Encoding.UTF8;
            var reader = new StreamReader(response.GetResponseStream(), encoding);
            string responseText = reader.ReadToEnd();
            return responseText;
        }

    }
}
