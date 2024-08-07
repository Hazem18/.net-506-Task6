using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class SavingsAccount : Account
    {
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0)
            : base(name , balance)
        {
            this.intRate=intRate;
        }

        public double intRate { get; set; }

        public override bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                balance+= balance * intRate;
                return true;
            }
        }
        public override string ToString()
        {
            return base.ToString()+$": Int rate: {intRate * 100}%.]";
        }


    }
}
