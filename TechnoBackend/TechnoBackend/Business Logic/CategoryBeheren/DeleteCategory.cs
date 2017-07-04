using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.CategoryBeheren
{
    public class DeleteCategory
    {
        public static HttpStatusCode DelCategory(int catid)
        {

            DBModelContainer db = new DBModelContainer();

            var currentcategory = db.CATs.Where(s => s.CAT_Id == catid).FirstOrDefault();
            if (currentcategory != null)
            {
                db.CATs.Remove(currentcategory);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return HttpStatusCode.InternalServerError;
                }

            }
            return HttpStatusCode.InternalServerError;
        }
    }
}