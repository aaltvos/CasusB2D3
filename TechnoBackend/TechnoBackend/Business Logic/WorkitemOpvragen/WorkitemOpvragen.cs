using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.WorkitemOpvragen
{
    public class WorkitemOpvragen
    {
        public static IList<PRODs>GetWorkItem()
        {
            List<PRODs> prodList = new List<PRODs>();
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                foreach (var x in dbModel.PRODs)
                {
                    PRODs y = new PRODs();
                    y.PRODs_ID = x.Prod_ID;
                    y.PRODs_Name = x.Prod_Name;
                    y.PRODs_Dat = x.Prod_Dat.ToString();

                    prodList.Add(y);

                    

                   
                }
                return prodList;
            }

        }
    }
}