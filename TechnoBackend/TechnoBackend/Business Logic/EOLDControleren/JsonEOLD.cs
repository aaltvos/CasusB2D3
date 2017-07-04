using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnoBackend.Business_Logic.EOLDControleren
{
    public class JsonEOLD
    {
        [JsonProperty(PropertyName = "validation_date")]
        public string Val_Dat { get; set; }

    }
}