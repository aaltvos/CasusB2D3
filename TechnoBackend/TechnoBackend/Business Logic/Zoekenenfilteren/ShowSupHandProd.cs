using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Zoekenenfilteren
{
    public class ShowSupHandProd
    {
        public static IList<showsuphandprodModel> GetSubHand_Prod(HttpActionContext ActionContext)
        {
            List<showsuphandprodModel> subhandprodlist = new List<showsuphandprodModel>();
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                string subhandgeb = ActionContext.Request.Headers.GetValues("Sub_ID").First();
                int keuzesubhandgeb = System.Convert.ToInt32(subhandgeb);

                //where Prod_ID in 
                //       (select PROD_Prod_ID from HAND_SUB_GEB_PROD
                //       where SUB_GEB_Sub_ID = 0)

                //Select * from SUB_GEB
                //Where Sub_ID in 
                //(Select SUB_GEB_Sub_ID from HAND_SUB_GEB_PROD
                //Where HAND_GEB_Hand_ID = keuzehandgeb)
                //var innerQuery = (from fb in dbModel.HAND_SUB_GEB_PROD where fb.HAND_GEB.Hand_ID == keuzehandgeb select fb.SUB_GEB.Sub_ID);
                //var query = (from f in dbModel.SUB_GEB where innerQuery.Contains(f.Sub_ID) select f);

                var innerQuery = (from fb in dbModel.HAND_SUB_GEB_PROD where fb.SUB_GEB.Sub_ID == keuzesubhandgeb select fb.PROD.Prod_ID);
                var query = (from f in dbModel.PRODs where innerQuery.Contains(f.Prod_ID) select f);
               
                foreach (var a in query)
                    {
                        showsuphandprodModel b = new showsuphandprodModel();
                        b.Prod_Name = a.Prod_Name;
                        b.Prod_Dat = a.Prod_Dat;
                        b.Prod_Desc = a.Prod_Desc;

                    // Product IMG momenteel niet in DB
                    //    b.Prod_IMG = a.Prod_Img;

                        subhandprodlist.Add(b);
                    }
                return subhandprodlist;
            }

        }
    }
}