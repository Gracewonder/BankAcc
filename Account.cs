using System;
using System.Collections.Generic;
using System.Text;


namespace _BankAcc
{
    public class Account : Person
    {
        protected DateTime _creatDate;
        private int _sumOfMoney;
        public string currency;

        public DateTime GetCreatDate()
        {
            return _creatDate;
        }

        public void SetCreatDate(DateTime creatdate)
        {
            var dateNow = DateTime.Now;
            if (creatdate > dateNow)
            {
                throw new Exception("Неверная дата рождения");
            }
            _creatDate = creatdate;
        }

        public int GetSumOfMoney()
        {
            return _sumOfMoney;
        }
        public void SetSumOfMoney(int sumMoney)
        {
            if(sumMoney<0)
            {
                throw new Exception("Недостаточно средств");
            }
            _sumOfMoney = sumMoney;
        }

        public Account(): base() { }
        public Account(string firstname, string lastname, DateTime dateofbirth, DateTime creatDate, int sum, string curr) : base(firstname,lastname,dateofbirth)
        {
            this._creatDate = creatDate;
            this._sumOfMoney = sum;
            this.currency = curr;
        }   
    }
}
