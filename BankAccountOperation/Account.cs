using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOperation
{
    class Account
    {
        public string accountNumber;
        public string customerName;
        public double balance;


        public double DepositMoney(double depositAmount)
        {
            balance = balance + depositAmount;
            return balance;

        }

        public double WithdrawMoney(double withdrawAmount)
        {
            balance = balance - withdrawAmount;
            return balance;

        }

        public string Report()
        {
            return customerName + "," + "Your account Number: " + accountNumber + " and Balance :" + balance.ToString();

        }
    }
}
