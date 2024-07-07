using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme27Lesson2
{
    internal class BankAccount
    {
        public  decimal AddMoney(decimal balance,decimal addSum)
        {
            return balance + addSum;
        }
        public  decimal WithdrawMoney(decimal balance,decimal subSum)
        {
            return balance - subSum;
        }
        public  void PrintBalance( decimal balance)
        {
            Console.WriteLine("Текущий баланс: "+balance);
        }
    }
}
