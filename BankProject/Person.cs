<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Person
    {
        public string Name { get; protected set; }
        public string Username { get; protected set; }
        protected string Password { get; private set; }

        public Person(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
        }

        public bool Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            return Username == username && Password == password;
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Person
    {
        public string Name { get; protected set; }
        public string Username { get; protected set; }
        protected string Password { get; private set; }

        public Person(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
        }

        public bool Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            return Username == username && Password == password;
        }
    }
>>>>>>> 36a61ded760ae6a4b2eefb4774c2a1e956a36dbe
}