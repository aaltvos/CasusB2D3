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
            String handgeb = actionContext.Request.Headers.GetValues("Handgeb_ID").First();
            int keuzehandgeb = System.Convert.ToInt32(handgeb);
            List<SupHandGebModel> subhandgeblist = new List<SupHandGebModel>();
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                //Hieronder bevind zich de SQL qeury voor het ophalen van subhandelingsgebied
                //Select * from SUB_GEB
                //Where Sub_ID in 
                        //(Select SUB_GEB_Sub_ID from HAND_SUB_GEB_PROD
                        //Where HAND_GEB_Hand_ID = keuzehandgeb)

                //Hieronder de query voor ophalen van subhandelingsgebied in linq
                var innerQuery = (from fb in dbModel.HAND_SUB_GEB_PROD where  fb.HAND_GEB.Hand_ID == keuzehandgeb select fb.SUB_GEB.Sub_ID);
                var query = (from f in dbModel.SUB_GEB where innerQuery.Contains(f.Sub_ID) select f);

                
                foreach(var a in query)
                {
                    SupHandGebModel b = new SupHandGebModel();
                    b.Sub_ID = a.Sub_ID;
                    b.Sub_Name = a.Sub_Name;
                    b.Sub_IMG = a.Sub_IMG;

                    subhandgeblist.Add(b);
                   
                    Console.WriteLine(subhandgeblist);
                }
                return subhandgeblist;
            }
        }

    }
}