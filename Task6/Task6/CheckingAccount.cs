using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class CheckingAccount : Account
    {
         public CheckingAccount(string name = "Unnamed Account", double balance = 0.0) : base (name , balance) { }


        public override bool Withdraw(double amount)
        {
           if (amount < 0)
                return false;
           else if (balance - amount <= 0)
                return false;
           else
            {
                balance -= amount + 1.5;
                return true;
            }

        }

        public override string ToString()
        {
            return base.ToString()+$": Withdraw fee: {1.5}$]";
        }
    }
}
