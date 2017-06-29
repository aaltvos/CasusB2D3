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
        public int Event_ID { get; set; }

        [JsonProperty(PropertyName = "Event_Name")]
        public string Event_Name { get; set; }

        [JsonProperty(PropertyName = "Event_Body")]
        public string Event_Body { get; set; }

        [JsonProperty(PropertyName = "Event_Address")]
        public string Event_Address { get; set; }

        [JsonProperty(PropertyName = "Event_Link")]
        public string Event_Link { get; set; }

        [JsonProperty(PropertyName = "USERs_USER_Id")]
        public int USERs_USER_Id { get; set; }
    }
}