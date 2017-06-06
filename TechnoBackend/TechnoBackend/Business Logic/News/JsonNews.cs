using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.News
{
    public class JsonNews
    {
        [JsonProperty(PropertyName = "ArticleID")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "ArticleTitle")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "ArticleBody")]
        public string Body { get; set; }

        [JsonProperty(PropertyName = "ArticleIMG")]
        public string Img { get; set; }

        [JsonProperty(PropertyName = "ArticleLINK")]
        public string Link { get; set; }
    }
}