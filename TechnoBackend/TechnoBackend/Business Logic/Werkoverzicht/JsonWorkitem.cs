using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnoBackend.Business_Logic.Werkoverzicht
{
    public class JsonWorkitem
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "date")]
        public string Dat { get; set; }

        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public string Weight { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public string Cost { get; set; }

        [JsonProperty(PropertyName = "covered")]
        public bool? Covered { get; set; }

        [JsonProperty(PropertyName = "availability")]
        public string Avail { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Desc { get; set; }

        [JsonProperty(PropertyName = "specification")]
        public string spec { get; set; }

        [JsonProperty(PropertyName = "requirements")]
        public string Req { get; set; }

        [JsonProperty(PropertyName = "movie")]
        public string Mov { get; set; }

        [JsonProperty(PropertyName = "views")]
        public long? Views { get; set; }

        [JsonProperty(PropertyName = "validation_date")]
        public string Val_Dat { get; set; }

    }
}