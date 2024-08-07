using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class TrustAccount : Account
    {
        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0)
            : base(name, balance)
        {
            this.intRate=intRate;
            years = new List<int>();
        }

        public double intRate { get; set; }

        public List<int> years;
        public int withdarwCounter { get; set; }
        public override bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else if (amount >= 5000)
            {
                balance += amount + 50;
                balance+= balance * intRate;
                return true;
            }
            else
            {
                base.Deposit(amount);
                return true;
            }
        }

        public override bool Withdraw(double amount)
        {
            double limit = balance * 0.2;
            if (amount < 0)
                return false;
            else if (balance - amount <= 0)
                return false;
            else if (amount > limit)
              return false;
            else
            {
                int y = DateTime.Now.Year;
                years.Add(y);
                if (CanWithdraw(y))
                {
                    balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public bool CanWithdraw(int year)
        {
            withdarwCounter = 0;
            foreach (int i in years)
            {
                if (i == year)
                    withdarwCounter++;
            }
            
            if(withdarwCounter <= 3)
                return true;
            else
                return false;
            
      
        }

        public override string ToString()
        {
            return base.ToString() + $": Int rate: {intRate*100}%: This year withdraws: {withdarwCounter} withdraw.]";
        }
    }
}
