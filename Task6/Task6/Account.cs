using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Account
    {

        public string name { get; set; }
        public double balance { get; set; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.name = name;
            this.balance = balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return $"[Account: {name}: {balance}";
        }

        public static Account operator+ (Account lhs , Account rhs)
        {
            return new Account(lhs.name + rhs.name ,lhs.balance+rhs.balance);
        }

    }
}
