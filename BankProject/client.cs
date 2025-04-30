using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Client : Person
    {
        public Account ClientAccount { get; private set; }
        public Client(string name, string username, string password) : base(name, username, password)
        {
            ClientAccount = new Account(this);
        }
    }
}