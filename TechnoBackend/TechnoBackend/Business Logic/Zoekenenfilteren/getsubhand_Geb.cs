using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Zoekenenfilteren
{
    public class getsubhand_Geb
    {
        public static IList<SubhandModel> GetSupHand_Geb()
        {
            List<SubhandModel> subhandgeblist = new List<SubhandModel>();
            DBModelContainer dbModel = new DBModelContainer();
            var x = from fb in dbModel.HAND_SUB_GEB_PROD where fb.HAND_GEB == 0 select fb.SUB_GEB;
            var result = from f in dbModel.SUB_GEB where x.Contains(f.SUB_GEB) select f;


            newsmax = (from news in db.NEWS where news.News_Id >= 1 select news.News_Id).Max();
            {
                foreach (var a in dbModel.HAND_SUB_GEB_PROD) ;
            }
            return;
        }
    }
}