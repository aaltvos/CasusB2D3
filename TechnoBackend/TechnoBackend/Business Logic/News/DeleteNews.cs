using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.News
{
    public class DeleteNews
    {
        public static string DeleteArticle(int newsid)
        {

            DBModelContainer db = new DBModelContainer();
            var currentarticle = db.NEWS.Where(s => s.News_Id == newsid).FirstOrDefault();
            if (currentarticle != null)
            {
                db.NEWS.Remove(currentarticle);
                try
                {

                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return (e.ToString());

                }
                return ("Article with ID :" + newsid + "has been deleted");
            }
            return ("The Article could not be found in the databse");
        }
    }
}