using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class CheckingAccount : Account
    {
        private decimal FeesRate = 0.1m;
        public CheckingAccount(Client owner) : base(owner) {}
        public void ApplyFees()
        {
            decimal Fees = Balance * FeesRate;
            Balance -= Fees;
            history.Add($"Fees taken \"{Fees}EGP \"on {DateTime.Now}");
        }
    } 
}
