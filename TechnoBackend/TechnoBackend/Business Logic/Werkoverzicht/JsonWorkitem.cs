using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.Werkoverzicht
{
    public class JsonWorkitem
    {
        [JsonProperty(PropertyName = "id")]
        private object id;

        [JsonProperty(PropertyName = "item")]
        private object item;

        public JsonWorkitem(object id, object item)
        {
            this.id = id;
            this.item = item;
        }
    }
}