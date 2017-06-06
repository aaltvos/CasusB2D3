using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.News
{
    public class JsonNews
    {
        [JsonProperty(PropertyName = "ArticleName")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "ArticleBody")]
        public string Password { get; set; }
    }
}