//Разработать программу, которая создаёт аккаунт пользователя в банке (вкладчика).
//Позволяет вносить на счёт деньги, снимать деньги и закрывать счёт. Предусмотреть предупреждения о снятии больше, чем на балансе и т.п.
using System;
using System.Collections.Generic;

namespace _BankAcc
{
    class Program
    {
        static void Main()
        {
            var select = "";
            Account account = new Account();
            do
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("S - ссоздать аккаунт");
                Console.WriteLine("E - Внести деньги");
                Console.WriteLine("I - Снять деньги");
                Console.WriteLine("С - Закрыть счёт");
                Console.WriteLine("P - Печатать счёт");
                Console.WriteLine("Q - Выход");
                select = Console.ReadLine();

                if (select == "S" || select == "s")
                {
                    Console.WriteLine("Введите имя");
                    account.firstName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию");
                    account.lastName = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения");
                    account.SetDateOfBirth(DateTime.Parse(Console.ReadLine()));
                    account.SetCreatDate(DateTime.Now);
                    Console.WriteLine("Введите сумму");
                    account.SetSumOfMoney(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Введите наименование валюты");
                    account.currency = Console.ReadLine();
                }if(select=="E"||select=="e")
                {
                    Console.WriteLine("Введите сумму");
                    account.SetSumOfMoney(Convert.ToInt32(Console.ReadLine()));
                }if(select=="i"||select=="I")
                {
                    Console.WriteLine("Введите сумму");
                    account.SetSumOfMoney(Convert.ToInt32(Console.ReadLine()));
                }
                if (select == "c" || select == "C")
                {
                    account.firstName = "";
                    account.lastName = "";
                    account.SetCreatDate(DateTime.Now);
                    account.SetDateOfBirth(DateTime.Now);
                    account.currency = "";
                    account.SetSumOfMoney(0);
                }
                if (select == "P" || select == "p")
                {
                    PrintAcc(account);
                }
                else 
                { Console.WriteLine("Неверная команда");
                }

            } while (select!="Q"||select!="q"); 
        }
        static void PrintAcc(Account acc)
        {
            Console.WriteLine(acc.firstName);
            Console.WriteLine(acc.lastName);
            Console.WriteLine(acc.GetDateOfBirth());
            Console.WriteLine(acc.GetCreatDate());
            Console.WriteLine(acc.GetSumOfMoney());
            Console.WriteLine(acc.currency);
        }
    }
}
