using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.Login;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.NewProduct
{
    public class Form
    {
        Product product;
        public Form()
        {
            
        }
        public Product createProduct(int id, string name, DateTime date, string size, string weight,
            string cost, bool covered, string avail, string desc, string spec, string req, string mov)
        {
            product = new Product(id, name, date, size, weight, cost, covered, avail, desc, spec, req, mov);
            return product;
        }
        public void insertProduct(Product product)
        {
            using (DBModelContainer db = new DBModelContainer())
            {
                try
                {
                    PRODs dbProd = new PRODs()
                    {
                        Prod_ID = product.id,
                        Prod_Name = product.name,
                        Prod_Dat = product.date,
                        Prod_Size = product.size,
                        Prod_Weight = product.weight,
                        Prod_Cost = product.cost,
                        Prod_Covered = product.covered,
                        Prod_Avail = product.avail,
                        Prod_Desc = product.desc,
                        Prod_Spec = product.spec,
                        Prod_Req = product.req,
                        Prod_Mov = product.mov,
                        Prod_Views = product.views,
                        Prod_Validator = product.validator,
                        Prod_Val_Dat = product.valDate
                    };
                    db.PRODs.Add(dbProd);
                }
                catch
                {
                    // catch exception!?
                }
            }
    }
}