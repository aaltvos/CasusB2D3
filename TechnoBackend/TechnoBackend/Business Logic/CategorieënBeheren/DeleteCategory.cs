using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.CategorieënBeheren
{
    public class DeleteCategory
    {
        public static string DelCategory(int catid)
        {

            DBModelContainer db = new DBModelContainer();
            var currentcategory = db.CAT.Where(s => s.CAT_Id == catid).FirstOrDefault();
            if (currentcategory != null)
            {
                db.CAT.Remove(currentcategory);
                try
                {

                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return (e.ToString());

                }
                return ("Category with ID :" + catid + "has been deleted");
            }
            return ("The Category could not be found in the databse");
        }
    }
}