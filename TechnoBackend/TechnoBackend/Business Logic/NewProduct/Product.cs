using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnoBackend.Business_Logic.NewProduct
{
    public class Product
    {
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public string name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime date
        {
            get { return date; }
            set { date = value; }
        }
        public string size
        {
            get { return size; }
            set { size = value; }
        }
        public string weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public bool covered
        {
            get { return covered; }
            set { covered = value; }
        }
        public string avail
        {
            get { return avail; }
            set { avail = value; }
        }
        public string desc
        {
            get { return desc; }
            set { desc = value; }
        }
        public string spec
        {
            get { return spec; }
            set { spec = value; }
        }
        public string req
        {
            get { return req; }
            set { req = value; }
        }
        public string mov
        {
            get { return mov; }
            set { mov = value; }
        }
        public int views //not in struct
        {
            get { return views; }
            set { views = value; }
        }
        public string validator //not in struct
        {
            get { return validator; }
            set { validator = value; }
        }
        public DateTime valDate
        {
            get { return valDate; }
            set { valDate = value; }
        }

        public Product(int id, string name, DateTime date, string size, string weight,
            string cost, bool covered, string avail, string desc, string spec, string req, string mov)
        {
            id = this.id;
            name = this.name;
            date = this.date;
            size = this.size;
            weight = this.weight;
            cost = this.cost;
            covered = this.covered;
            avail = this.avail;
            desc = this.desc;
            spec = this.spec;
            req = this.req;
            mov = this.mov;
            // int views = this.views;
            // string validator = this.validator
            DateTime valDate = this.valDate;
        }
    }
}