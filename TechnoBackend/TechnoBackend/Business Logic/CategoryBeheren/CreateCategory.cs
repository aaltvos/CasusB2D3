using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;
using System.Net;

namespace TechnoBackend.Business_Logic.CategoryBeheren
{
    public class CreateCategory
    {
        public static HttpStatusCode AddCategory(HttpActionContext actionContext)
        {
            DBModelContainer db = new DBModelContainer();

            //Decoding Json to Object
            var json = actionContext.Request.Content.ReadAsStringAsync().Result;
            JsonCategory newCategory = JsonConvert.DeserializeObject<JsonCategory>(json);

            CAT category = new CAT()
            {
                CAT_Name = newCategory.Name,
                CAT_IMG = newCategory.Img,
            };
            try
            {
                db.CATs.Add(category);
                db.SaveChanges();
            }
            catch
            {
                return HttpStatusCode.InternalServerError;
            }
            return HttpStatusCode.OK;
        }
    }
}