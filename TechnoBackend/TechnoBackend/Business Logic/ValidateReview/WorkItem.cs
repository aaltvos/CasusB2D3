using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.ValidateReview
{
    public class WorkItem
    {
        private readonly PRODs _product;

        private WorkItem(PRODs product)
        {
            _product = product;
            Debug.WriteLine("[WorkItem] - id=" + product.Prod_ID);
        }

        public string Accept(string token)
        {
            DBModelContainer database = new DBModelContainer();
            PRODs current = database.PRODs.Where(p => p.Prod_ID == _product.Prod_ID).First();
            if (current != null)
            {
                SESSIONS session = database.SESSIONS.Where(s => s.SESSIONS_Token == token).First();
                if (session == null) return "{\"status\":\"Error\", \"message\":\"No session found\"}";

                USERs user = database.USERs.Where(s => s.USER_Id == session.USER_Id.USER_Id).First();
                if (user == null) return "{\"status\":\"Error\", \"message\":\"No user found\"}";

                current.Prod_Validator = user.USER_Name;
                current.Prod_Val_Dat = DateTime.Now;

                database.SaveChanges();
                return "{\"status\":\"Success\"}";
            }

            return "{\"status\":\"Error\", \"message\":\"WorkItem not found\"}";
        }

        public string Deny()
        {
            DBModelContainer database = new DBModelContainer();
            PRODs current = database.PRODs.Where(p => p.Prod_ID == _product.Prod_ID).First();
            if (current != null)
            {
                // This is the part where an email would be send stating the WorkItem has been denied

                database.PRODs.Remove(current);
                database.SaveChanges();
                return "{\"status\":\"Success\"}";
            }

            return "{\"status\":\"Error\", \"message\":\"WorkItem not found\"}";
        }

        public string ToJson()
        {
            string result = "";
            result += "{";
            result += "\"id\":\"" + _product.Prod_ID + "\",";
            result += "\"name\":\"" + _product.Prod_Name + "\",";
            result += "\"dat\":\"" + _product.Prod_Dat + "\",";
            result += "\"size\":\"" + _product.Prod_Size + "\",";
            result += "\"weight\":\"" + _product.Prod_Weight + "\",";
            result += "\"cost\":\"" + _product.Prod_Cost + "\",";
            result += "\"covered\":\"" + _product.Prod_Covered + "\",";
            result += "\"avail\":\"" + _product.Prod_Avail + "\",";
            result += "\"desc\":\"" + _product.Prod_Desc + "\",";
            result += "\"spec\":\"" + _product.Prod_Spec + "\",";
            result += "\"req\":\"" + _product.Prod_Req + "\",";
            result += "\"mov\":\"" + _product.Prod_Mov + "\",";
            result += "\"views\":\"" + _product.Prod_Views + "\",";
            result += "\"validator\":\"" + _product.Prod_Validator + "\",";
            result += "\"val_dat\":\"" + _product.Prod_Val_Dat + "\"";
            result += "}";
            return result;
        }

        public static List<WorkItem> LoadAll()
        {
            List<WorkItem> result = new List<WorkItem>();

            DateTime now = DateTime.Now;

            DBModelContainer database = new DBModelContainer();
            IQueryable<PRODs> products = null;
            try
            {
                products = database.PRODs.Where(p => 
                    String.IsNullOrEmpty(p.Prod_Validator) 
                    || now.Year - p.Prod_Val_Dat.Year >= 3
                );
            } catch (Exception e)
            {
                Debug.WriteLine("[WorkItem::LoadAll] - " + e.ToString());
            }

            if (products != null)
                foreach (PRODs product in products)
                    result.Add(new WorkItem(product));

            return result;
        }

    }

}