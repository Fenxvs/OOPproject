
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Client
    {
        public string Name { get; private set; }
        public string Username { get; private set; }
        protected string Password { get; private set; }
        public Gender gender;
        public CheckingAccount ClientAccount { get; private set; }
        public IslamicSavingAccount ISA { get; private set; }
        public Client(string Name, Gender gender, string Username, string Password) 
        {
            this.Name = Name;
            this.gender = gender;
            this.Username = Username;
            this.Password = Password;
        }
        public void OpenCA()
        {
            ClientAccount = new CheckingAccount(this);
        }
        public void OpenISA()
        {
            ISA = new IslamicSavingAccount(this);
        }
    }
}