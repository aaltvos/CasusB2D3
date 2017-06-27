using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.Werkoverzicht
{
    public class JsonWorkitem
    {
        [JsonProperty(PropertyName = "product_id")]
        private int product_id;

        [JsonProperty(PropertyName = "product_name")]
        private string product_name;

        public JsonWorkitem(int product_id, string product_name)
        {
            this.product_id = product_id;
            this.product_name = product_name;
        }
    }
}