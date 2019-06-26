using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Account
    {
        int _Id;
        double _Balance;
        public Account(int id, double balance)
        {
            this._Id = id;
            this._Balance = balance;
         }

        public int Id
        {
            get
            {
                return _Id;
            }
        }

        public void WithDraw(double amount)
        {
            _Balance -= amount;
        }

        public void Deposit(double amount)
        {
            _Balance += amount;
        }
    }
}
