using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class IslamicSavingAccount : Account
    {
        public IslamicSavingAccount(Client owner) : base(owner) {}
        public decimal ProfitRate = 0.15m;
        public void ApplyProfit()
        {
            decimal profit = Balance * ProfitRate;
            Balance += profit;
            history.Add($"Profit added \"{profit}EGP \"on {DateTime.Now}");
        }
    }
}
