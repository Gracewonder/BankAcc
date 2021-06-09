//Разработать программу, которая создаёт аккаунт пользователя в банке (вкладчика).
//Позволяет вносить на счёт деньги, снимать деньги и закрывать счёт. Предусмотреть предупреждения о снятии больше, чем на балансе и т.п.
using System;
using System.Collections.Generic;

namespace _BankAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.SetSumOfMoney(100);

            int sum = account.GetSumOfMoney();
            Console.WriteLine($"{sum}");
        }
    }
}
