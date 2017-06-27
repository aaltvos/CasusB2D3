using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.ProfielBewerken
{
    public class JsonProfielBewerken
    {
        [JsonProperty(PropertyName = "User_id")]
        public int USER_Id { get; set; }

        [JsonProperty(PropertyName = "User_name")]
        public string USER_Name { get; set; }

        [JsonProperty(PropertyName = "User_PW")]
        public string USER_PW { get; set; }

        [JsonProperty(PropertyName = "User_email")]
        public string USER_Email { get; set; }
    }
}