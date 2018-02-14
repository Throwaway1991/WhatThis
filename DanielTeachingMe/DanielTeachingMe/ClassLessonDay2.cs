using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DanielTeachingMe
{
    public class ClassLessonDay2
    {
        public void ExecuteDay2Lesson()
        {
            BankAccount matthewsAccount = new BankAccount();
            BankAccount danielsAccount = new BankAccount();

            matthewsAccount.SignUp();
            Thread.Sleep(1000);
            danielsAccount.SignUp();

            Console.WriteLine("Matt's account number: {0}\r\nMatt's owner id: {1}", matthewsAccount.AccountNumber, matthewsAccount.OwnerId);
            Console.WriteLine("Daniel's account number: {0}\r\nDaniel's owner id: {1}", danielsAccount.AccountNumber, danielsAccount.OwnerId);

            matthewsAccount.SetBalance(200.00M);
            danielsAccount.SetBalance(100.00M);

            ShowBalances(matthewsAccount, danielsAccount);

            matthewsAccount.TransferMoney(50.00M, danielsAccount);

            ShowBalances(matthewsAccount, danielsAccount);
        }

        private void ShowBalances(BankAccount account1, BankAccount account2)
        {
            Console.WriteLine("Matthew's money: {0}", account1.Balance.ToString("c2"));
            Console.WriteLine("Daniel's money: {0}", account2.Balance.ToString("c2"));
        }
    }
}
