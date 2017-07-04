using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using TechnoBackend.DatabaseModel;


namespace TechnoBackend.Business_Logic.CategoryBeheren
{
    public class ChangeCategory
    {
        public static string UpdateCategory(int catid)
        {


            using (DBModelContainer db = new DBModelContainer())

            {
                CAT currentcategory = db.CATs.Where(s => s.CAT_Id == catid).FirstOrDefault();

                if (currentcategory != null)

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        return (e.ToString());

                    }
                return ("Category with ID :" + catid + "has been updated");


            return ("The Category could not be found in the databse");
            }
        }
    }
}