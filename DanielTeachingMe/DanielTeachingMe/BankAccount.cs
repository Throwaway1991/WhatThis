using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielTeachingMe
{
    public class BankAccount
    {
        private Guid _accountNumber;
        private decimal _balance;
        private int _ownerId;

        //Constructor - constructor will be class name with no return type specified
        public BankAccount()
        {
            _accountNumber = Guid.NewGuid();
        }
       
        /// <summary>
        /// Returns the account number (read only)
        /// </summary>
        public Guid AccountNumber
        {
            get { return _accountNumber; }
        }

        public decimal Balance
        {
            get { return _balance; }
        }
        /// <summary>
        /// Returns the owner Id (read only). If set there, then write.
        /// </summary>
        public int OwnerId
        {
            get { return _ownerId; }
        }

        /// <summary>
        /// Generates a new ownerId value.  TODO: Future lessons refactor
        /// </summary>
        /// <returns></returns>
        public int SignUp()
        {
            Random random = new Random();

            _ownerId = random.Next();

            return _ownerId;
        }

        /// <summary>
        /// Sets the account balance
        /// </summary>
        /// <param name="amount"></param>
        public void SetBalance(decimal amount)
        {
            _balance = amount;
        }

        /// <summary>
        /// Adds an amount of money to the account
        /// </summary>
        /// <param name="amount"></param>
        public void AddFunds(decimal amount)
        {
            _balance += amount; //shorthand for balance = balance + amount;
        }

        /// <summary>
        /// Transfers money to another account
        /// </summary>
        /// <param name="toAccount"></param>
        /// <returns>-1 if unsuccessful 0 if success</returns>
        public int TransferMoney(decimal amountToTransfer, BankAccount toAccount)
        {
            if (null == toAccount || _balance < amountToTransfer)
                return -1;

            _balance -= amountToTransfer;
            toAccount.AddFunds(amountToTransfer);

            return 0;
        }
    }
}
