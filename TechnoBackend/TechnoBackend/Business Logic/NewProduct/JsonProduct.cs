using Newtonsoft.Json;
using System;

namespace TechnoBackend.Business_Logic.NewProduct
{
    public class JsonProduct
    {
        [JsonProperty(PropertyName = "productid")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime date { get; set; }

        [JsonProperty(PropertyName = "size")]
        public string size { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public string weight { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public string cost { get; set; }

        [JsonProperty(PropertyName = "covered")]
        public bool covered { get; set; }

        [JsonProperty(PropertyName = "avail")]
        public string avail { get; set; }

        [JsonProperty(PropertyName = "desc")]
        public string description { get; set; }

        [JsonProperty(PropertyName = "spec")]
        public string spec { get; set; }

        [JsonProperty(PropertyName = "req")]
        public string req { get; set; }

        [JsonProperty(PropertyName = "mov")]
        public string movieurl { get; set; }
    }
}
    