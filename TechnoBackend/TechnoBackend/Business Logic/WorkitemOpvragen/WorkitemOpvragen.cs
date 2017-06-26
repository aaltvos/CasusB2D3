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
            List<PRODs> workItemList = new List<PRODs>();
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                foreach(var row in dbModel.PRODs)
                {
                    // Iedere rij wordt een nieuwe instantie Product
                    PRODs y = new PRODs();
                    y.PRODs_ID = row.Prod_ID;
                    y.PRODs_Name = row.Prod_Name;
                    y.PRODs_Dat = row.Prod_Dat.ToString();
                    y.PRODs_Spec = row.Prod_Spec;
                    y.PRODs_Validator = row.Prod_Validator;


                    //UC 3.1 Product Beoordeling, Als Product een beoordeling heeft -----> opslaan als workitem
                    //
                    // Heeft product een beoordeling check 

                    if(y.PRODs_Validator == "0")
                    {
                        workItemList.Add(y);
                        // Eventueel product op status "Wacht op validatie"
                    }
                    //UC 3.2 Check Date, Als DATUM > HUIDIGE_DATUM  ------> opslaan als workitem
                    //
                    // Datum converteren naar DateTime en vergelijken met huidige datum

                    //DateTime datumVanRij = Convert.ToDateTime(row.Prod_Dat);
                    /*if(datumVanRij <= DateTime.Now)
                    {
                        workItemList.Add(y);
                        // Eventueel product op status "Wacht op validatie"
                     }*/
                }
                return workItemList;
            }
        }
    }
}