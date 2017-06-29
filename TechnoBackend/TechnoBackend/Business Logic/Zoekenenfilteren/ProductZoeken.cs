using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;
using System.Linq;

namespace TechnoBackend.Business_Logic.ProductZoeken
{
    public class ProductZoeken
    {
        public static IList<handGebModel> GetHand_Geb()
        {
            List<handGebModel> Productenlijst = new List<handGebModel>();
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                //dbModel.HAND_GEB.Select(x => new lcclsAccDueList { * }).ToList();
                foreach (var a in dbModel.HAND_GEB)
                {
                    handGebModel b = new handGebModel();
                    b.Prod_ID = a.Prod_ID;
                    b.Prod_Name = a.Prod_Name;
                    b.Prod_Cost = a.Prod_Cost;


                    handgeblist.Add(b);
                }
                return handgeblist;
            }


        }
    }
}