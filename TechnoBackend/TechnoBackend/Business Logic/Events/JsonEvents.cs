using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.Events
{
    public class JsonEvents
    {
        [JsonProperty(PropertyName = "Event_ID")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "Event_Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Event_Body")]
        public string Body { get; set; }

        [JsonProperty(PropertyName = "Event_Address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "Event_Link")]
        public string Link { get; set; }
    }
}