using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnoBackend.Business_Logic.Werkoverzicht
{
    public class Workitems
    {
        private List<Object> WorkitemsBox = new List<object>();

        public Workitems(List<Object> WorkitemList)
        {
            this.WorkitemsBox = WorkitemList;
        }
    }
}
