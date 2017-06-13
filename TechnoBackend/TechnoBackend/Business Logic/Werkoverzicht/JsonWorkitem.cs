using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.Werkoverzicht
{
    public class JsonWorkitem
    {
        [JsonProperty(PropertyName = "Itemname")]
        public string Itemname { get; set; }

        [JsonProperty(PropertyName = "Validation")]
        public string Validation { get; set; }

        [JsonProperty(PropertyName = "ValidationDate")]
        public string ValidationDate { get; set; }
    }
}