using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.EOLDControleren
{
    public class ShowEOLD
    {
        public ShowEOLD(DateTime product_validation_date)
        {
            this.product_validation_date = product_validation_date;
        }

        // List of properties with get and setters for data encapsulation
        // PROD_Val_Dat

        private DateTime _product_validation_date;

        public DateTime product_validation_date
        {
            get { return _product_validation_date; }
            set { _product_validation_date = value; }
        }
    }
}