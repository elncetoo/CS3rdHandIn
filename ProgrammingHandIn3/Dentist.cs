﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ProgrammingHandIn3
{
    [Serializable]
    public class Dentist : Person
    {
        //field
        protected int socialnr;

        //constructor
        public Dentist(string name, int age, string password, string email, int socialnr) : base(name, age, password, email)
        {
            this.SocialNr = socialnr;
            ChangeEmail(email);
        }

        public int SocialNr
        {
            get { return socialnr; }
            set { socialnr = value; }
        }

        
        //Method
        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + " Email: " + Email + " Password: " + Password + " Social Security Nr: " + SocialNr;
        }

        public override void ChangeEmail(string newEmail) //custom method that overrides the inserted email to  odont.dk and checking the regular expression
        {
            string pattern = "\\@(.*)";

            Regex rgx = new Regex(pattern);
            Email = rgx.Replace(Email, "@odont.dk");
            return;
        }

    }
}