using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class AccountManager
    {
        Account _FromAccount;
        Account _ToAccount;
        double _amountToTranser;
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._FromAccount = fromAccount;
            this._ToAccount = toAccount;
            this._amountToTranser = amountToTransfer;
        }

        public void Tranfser()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "Is trying to acquire lock on " + _FromAccount.Id.ToString());
            lock (_FromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on " + _FromAccount.Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + "Suspended for 1 Second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + "back in Action trying to acquire lock on" + _ToAccount.Id.ToString());
                lock (_ToAccount)
                {
                    Console.WriteLine("This code will not be executed");
                    _FromAccount.WithDraw(_amountToTranser);
                    _ToAccount.Deposit(_amountToTranser);
                }
            }
        }

        public void TransferWithoutDeadLock()
        {
            object _lock1, _lock2;
            if (_FromAccount.Id < _ToAccount.Id)
            {
                _lock1 = _FromAccount;
                _lock2 = _ToAccount;
            }
            else
            {
                _lock1 = _ToAccount;
                _lock2 = _FromAccount;
            }
            Console.WriteLine(Thread.CurrentThread.Name + "Is trying to acquire lock on " + ((Account)_lock1).Id.ToString());
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on " + ((Account)_lock1).Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + "Suspended for 1 Second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + "back in Action trying to acquire lock on" + ((Account)_lock2).Id.ToString());
                lock (_lock2)
                {
                    Console.WriteLine("This code will not be executed");
                    _FromAccount.WithDraw(_amountToTranser);
                    _ToAccount.Deposit(_amountToTranser);

                    Console.WriteLine(Thread.CurrentThread.Name + "Transffered Amount " + _amountToTranser.ToString() + "From" + _FromAccount.Id.ToString() + " to " + _ToAccount.Id.ToString());
                }
            }
        }
    }
}
