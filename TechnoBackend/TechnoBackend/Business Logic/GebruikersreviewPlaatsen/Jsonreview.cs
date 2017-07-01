using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnoBackend.Business_Logic.GebruikersreviewPlaatsen
{
    public class Jsonreview
    {
        [JsonProperty(PropertyName = "review")]
        public string review { get; set; }
    }
}