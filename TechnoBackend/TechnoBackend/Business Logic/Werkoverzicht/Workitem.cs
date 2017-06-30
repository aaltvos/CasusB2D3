using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TechnoBackend.Business_Logic.Werkoverzicht
{
    public class Workitem
    {
        
        // Must have information
        public Workitem(
            int product_id,
            string product_name,
            DateTime product_date,
            string product_size,
            string product_weight,
            string product_cost,
            bool? product_covered,
            string product_availability,
            string product_description,
            string product_specification,
            string product_requirements,
            string product_movie,
            long? product_views,
            DateTime product_validation_date
            )
        {
            this.product_id = product_id;
            this.product_name = product_name;
            this.product_date = product_date;
            this.product_size = product_size;
            this.product_weight = product_weight;
            this.product_cost = _product_cost;
            this.product_covered = product_covered;
            this.product_availability = product_availability;
            this.product_description = product_description;
            this.product_specification = product_specification;
            this.product_requirements = product_requirements;
            this.product_movie = product_movie;
            this.product_views = product_views;
            this.product_validation_date = product_validation_date;
        }

        // List of properties with get and setters for data encapsulation
        // contains foreign key '_product_validation_user_id' to pass user_id to front-end

        // PROD_ID

        private int _product_id;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        // PROD_Name
        
        private string _product_name;

        public string product_name
        {
            get { return _product_name; }
            set { _product_name = value; }
        }

        // PROD_Dat
        
        private DateTime _product_date;

        public DateTime product_date
        {
            get { return _product_date; }
            set { _product_date = value; }
        }

        // PROD_Size
        
        private string _product_size;

        public string product_size
        {
            get { return _product_size; }
            set { _product_size = value; }
        }

        // PROD_Weight
        
        private string _product_weight;

        public string product_weight
        {
            get { return _product_weight; }
            set { _product_weight = value; }
        }

        // PROD_Cost
        
        private string _product_cost;

        public string product_cost
        {
            get { return _product_cost; }
            set { _product_cost = value; }
        }

        // PROD_Covered
        
        private bool? _product_covered;

        public bool? product_covered
        {
            get { return _product_covered; }
            set { _product_covered = value; }
        }

        // PROD_Avail
        
        private string _product_availability;

        public string product_availability
        {
            get { return _product_availability; }
            set { _product_availability = value; }
        }

        // PROD_Desc
        
        private string _product_description;

        public string product_description
        {
            get { return _product_description; }
            set { _product_description = value; }
        }

        // PROD_Spec
        
        private string _product_specification;
            
        public string product_specification
        {
            get { return _product_specification; }
            set { _product_specification = value; }
        }

        // PROD_req
        
        private string _product_requirements;

        public string product_requirements
        {
            get { return _product_requirements; }
            set { _product_requirements = value; }
        }

        // PROD_Mov
        
        private string _product_movie;

        public string product_movie
        {
            get { return _product_movie; }
            set { _product_movie = value; }
        }

        // PROD_Views
        
        private long? _product_views;
                
        public long? product_views
        {
            get { return _product_views; }
            set { _product_views = value; }
        }

        // PROD_Val_Dat
        
        private DateTime _product_validation_date;

        public DateTime product_validation_date
        {
            get { return _product_validation_date; }
            set { _product_validation_date = value; }
        }
    }
}