using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.Event
{
    public class JsonEvent
    {
        public class JsonNews
        {
            [JsonProperty(PropertyName = "EventID")]
            public string ID { get; set; }

            [JsonProperty(PropertyName = "EventName")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "EventBody")]
            public string Body { get; set; }

            [JsonProperty(PropertyName = "EventAddress")]
            public string Address { get; set; }

            [JsonProperty(PropertyName = "EventLink")]
            public string Link { get; set; }
        }
    }
}