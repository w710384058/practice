using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimmy
{
    internal class BankAccount
    {
        private double _balance;

        public double Balance
        {
            get {return _balance; }
            set {_balance =  value < 0 ? 0:value; }
        }
        
        public BankAccount(double balance) 
        {
            Balance = balance;
        }
    }
}
