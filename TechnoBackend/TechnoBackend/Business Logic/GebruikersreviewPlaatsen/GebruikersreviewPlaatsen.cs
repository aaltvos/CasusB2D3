﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnoBackend.DatabaseModel;
using System.Diagnostics;

namespace TechnoBackend.Business_Logic.GebruikersreviewPlaatsen
{ 
    public class Review
    {
        private readonly PRODs _productId;
        private Review(Int32 productId, Int32 UserId, string ReviewText)
        {
            Int32 _productId = productId;
            Int32 _UserId = UserId;
            string _ReviewText = ReviewText;
        }
        public string CreateReview(string token, string TextualContent)
        {
            using (DBModelContainer database = new DBModelContainer())
            {
                //querry for most recent review
                Int32 RevId = Convert.ToInt32(database.REVs.OrderByDescending(u => u.REV_ID).FirstOrDefault());
                ++RevId;

                SESSIONS session = database.SESSIONS.Where(s => s.SESSIONS_Token == token).First();
                if (session == null) return "{\"status\":\"Error\", \"message\":\"No Session found\"}";

                USERs user = database.USERs.Where(s => s.USER_Id == session.USER_Id.USER_Id).First();
                if (user == null) return "{\"status\":\"Error\", \"message\":\"No User found\"}";

                //create new object to add in the database
                Review NewReview = new Review(RevId, user.USER_Id, TextualContent);
                database.REVs.Add(new REVs()
                {
                    REV_ID = RevId;
                    

                });

                database.SaveChanges();
                return "Reviewdata collected";
            }
            
        }
            
    }
}