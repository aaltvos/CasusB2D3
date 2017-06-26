using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnoBackend.Business_Logic.WorkitemOpvragen
{
    public partial class PRODs
    {
        public int PRODs_ID { get; set; }
        public string PRODs_Name { get; set; }
        public string PRODs_Dat { get; set; }
        public string PRODs_Spec { get; set; }
        public string PRODs_Validator { get; set; }
    }
}