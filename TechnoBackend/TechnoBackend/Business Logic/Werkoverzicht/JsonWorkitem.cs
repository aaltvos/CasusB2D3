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
        private int id;

        [JsonProperty(PropertyName = "item")]
        private string item;

        public JsonWorkitem(int id, string item)
        {
            this.id = id;
            this.item = item;
        }
    }
}