using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.CategoryBeheren
{
    public class JsonCategory
    {
        [JsonProperty(PropertyName = "CategoryID")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "CategoryName")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "CategoryIMG")]
        public string Img { get; set; }
    }
}