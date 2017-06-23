using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;
using System.Linq;

namespace TechnoBackend.Business_Logic.Zoekenenfilteren
{
    public class ShowHandelingsgebieden
    {
        public static IList<handGebModel> GetHand_Geb()
        {
            List<handGebModel> handgeblist = new List<handGebModel>();
            using (DBModelContainer dbModel = new DBModelContainer())
            {
                //dbModel.HAND_GEB.Select(x => new lcclsAccDueList { * }).ToList();
                foreach(var a in dbModel.HAND_GEB)
                {
                    handGebModel b = new handGebModel();
                    b.Hand_ID = a.Hand_ID;
                    b.Hand_IMG = a.Hand_IMG;
                    b.Hand_Name = a.Hand_Name;


                    handgeblist.Add(b);
                }
                return handgeblist;
            }


        }
    }
}