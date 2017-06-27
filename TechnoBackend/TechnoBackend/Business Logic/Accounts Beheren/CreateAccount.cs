using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Newtonsoft.Json;
using TechnoBackend.DatabaseModel;

namespace TechnoBackend.Business_Logic.Accounts_Beheren
{

    public class CreateAccount
    {
        string SelectAccount;
        CreateAccount account = new CreateAccount();
        DBModelContainer db = new DBModelContainer();

        //properties 

        public int USER_Id { get; set; }
        public string USER_Name { get; set; }
        public string USER_PW { get; set; }
        public int USER_Sec { get; set; }
        public DateTime USER_Val_dat { get; set; }


        // controleren of de gebruiker een username + pw ingeeft
        public void CheckInput()
        {
            if (string.IsNullOrEmpty(account.USER_Name) && string.IsNullOrEmpty(account.USER_PW))
            {
                System.Diagnostics.Debug.WriteLine("Empty form");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(account.USER_Name + account.USER_PW);
            }
        }

        // controle of de er een security lvl is ingesteld, als dit niet het geval is wordt deze standaard op 1 ingesteld.
        public void CheckSec()
        {

            if (account.USER_Sec == 0 || account.USER_Sec > 4 || account.USER_Sec < 1)
            {
                account.USER_Sec = 1;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(account.USER_Sec); //kan weg
            }
        }


        // Elk account heeft een verloopdatum, deze is datum van aanmaken + 500 dgn 
        public void SetDate()
        {
            DateTime now = DateTime.Now;
            DateTime enddate = now.AddDays(500);
            account.USER_Val_dat = enddate;
        }

        // account wordt weggeschreven in de DB
        USERs NewUser = new USERs()
        {
            // USER_Id
            USER_Name = account.USER_Name,
            USER_PW = account.USER_PW,
            USER_Sec = account.USER_Sec,
            USER_Val_dat = account.USER_Val_dat
        };
        try
        {
            db.USERs.add(NewUser);
            db.savechanges();
        }

    }


/*


        public void AddAccount()
        {
            INSERT INTO USERs(USER_Name, USER_PW, USER_Sec, USER_Val_dat)
                    VALUES(account.USER_Name, account.USER_PW, account.USER_Sec, account.USER_Val_dat);
        }


        public void DeleteAccount()
        {
            DELETE from USERs
                WHERE USER_Name = SelectAccount;
        }

    */




    }

    

}
