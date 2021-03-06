﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class _95DeadLock
    {

        //Creating a Dead lock this program won't finish its execution because of the dead lock.
        public static void Main()
        {
            Console.WriteLine("Main Started");
            Account accountA = new Account(101, 5000);
            Account accountB = new Account(102, 6000);
            AccountManager accountManagerA = new AccountManager(accountA, accountB, 100);
            Thread T1 = new Thread(accountManagerA.Tranfser);
            T1.Name = "T1";
            AccountManager accountManagerB = new AccountManager(accountB, accountA, 200);
            Thread T2 = new Thread(accountManagerB.Tranfser);
            T2.Name = "T2";

            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();
            Console.WriteLine("Main Thread Completed");
        }
    }
}
