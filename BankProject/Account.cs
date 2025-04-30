using System;
using System.Collections.Generic;

namespace BankProject
{
    public class Account
    {
        private decimal balance;
        private List<string> history = new List<string>();
        private Client owner;

        public decimal Balance => balance;

        public Account(Client owner)
        {
            this.owner = owner;
            balance = 0;
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0) return false;

            balance += amount;
            history.Add($"Deposited: {amount} EGP on {DateTime.Now}");
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > balance) return false;

            balance -= amount;
            history.Add($"Withdrew: {amount} EGP on {DateTime.Now}");
            return true;
        }

        public bool Transfer(Client receiver, decimal amount)
        {
            if (receiver == null || amount <= 0 || amount > balance) return false;

            balance -= amount;
            history.Add($"Transferred: {amount} EGP to {receiver.Name} on {DateTime.Now}");

            receiver.ClientAccount.ReceiveTransfer(owner.Username, amount);
            return true;
        }

        private void ReceiveTransfer(string senderUsername, decimal amount)
        {
            balance += amount;
            history.Add($"Received: {amount} EGP from {senderUsername} on {DateTime.Now}");
        }

        public List<string> GetHistory()
        {
            return new List<string>(history);
        }
    }
}