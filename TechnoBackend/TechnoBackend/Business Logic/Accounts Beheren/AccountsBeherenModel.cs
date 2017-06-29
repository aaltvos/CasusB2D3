using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnoBackend.Business_Logic.Accounts_Beheren
{
    public partial class User
    {
        public int USER_Id { get; set; }
        public string USER_Name { get; set; }
        public string USER_PW { get; set; }
        public int USER_Sec { get; set; }
        public DateTime USER_Val_dat { get; set; }
    }
}