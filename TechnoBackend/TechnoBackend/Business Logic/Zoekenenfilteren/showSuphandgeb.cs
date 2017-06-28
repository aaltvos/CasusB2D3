using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace TechnoBackend.Business_Logic.Zoekenenfilteren
{
    public class showSuphandgeb
    {
        public static IList<SupHandGebModel> GetSupHand_Geb(HttpActionContext actionContext)
        {
            String handgeb = actionContext.Request.Headers.GetValues("Handgeb").First();
            int handgeb2 = System.Convert.ToInt32(handgeb);
            List<SupHandGebModel> subhandgeblist = new List<SupHandGebModel>();
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                var innerQuery = (from fb in dbModel.HAND_SUB_GEB_PROD where  fb.HAND_GEB == handgeb2 select fb);
                var query = (from f in dbModel.SUB_GEB where innerQuery.Contains(f.Sub_ID) select f);

                foreach(var a in query)
                {
                    SupHandGebModel b = new SupHandGebModel();
                    b.Sub_ID = a.Sub_ID;
                    b.Sub_Name = a.Sub_Name;
                    b.Sub_IMG = a.Sub_IMG;

                    subhandgeblist.Add(b);
                }
                return subhandgeblist;
            }
        }

    }
}