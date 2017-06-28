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
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                List<PRODs> workItemList = new List<PRODs>();
                foreach (var row in dbModel.PRODs)
                {
                    // Iedere rij wordt een nieuwe instantie Product
                    PRODs y = new PRODs();

                    y.PRODs_ID = row.Prod_ID;
                    y.PRODs_Name = row.Prod_Name;
                    y.PRODs_Dat = row.Prod_Dat.ToString();
                    y.PRODs_Spec = row.Prod_Spec;

                    if(row.Prod_Val_User.USER_Sec < 4)
                    {
                        workItemList.Add(y);
                    }
                }
                return workItemList;
            }
        }
    }
}