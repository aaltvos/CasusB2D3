using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.Accounts_Beheren
{
    public class JsonAccount
    {
        /*   
          [JsonProperty(PropertyName = "USER_Id")]
          public int id { get; set; }

          [JsonProperty(PropertyName = "USER_name")]
          public string name { get; set; }

          [JsonProperty(PropertyName = "USER_PW")]
          public string pw { get; set; }

          [JsonProperty(PropertyName = "USER_Sec")]
          public int sec { get; set; }

          [JsonProperty(PropertyName = "USER_Val_Dat")]
          public DateTime val_dat { get; set; }

      */

        [JsonProperty(PropertyName = "USER_Email ")]
        public string mail = " kutzooi";

        [JsonProperty(PropertyName = "USER_Name ")]
        public string name = " eerappel";

        [JsonProperty(PropertyName = "USER_PW ")]
        public string pw = "eerappel123";

        [JsonProperty(PropertyName = " USER_Sec")]
        public int sec = 2;

        [JsonProperty(PropertyName = " USER_Val_dat")]
        public DateTime val_dat = DateTime.Now;
    }
}