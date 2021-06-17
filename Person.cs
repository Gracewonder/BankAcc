using System;
using System.Collections.Generic;
using System.Text;

namespace _BankAcc
{
    public class Person
    {
        public string firstName;
        public string lastName;
        protected DateTime _dateOfBirth;

        public DateTime GetDateOfBirth()
        {
            return _dateOfBirth;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            var dateNow = DateTime.Now;
            if (dateOfBirth>dateNow||dateOfBirth<dateNow.AddYears(-100))
            {
                throw new Exception("Неверная дата рождения");
            }
            _dateOfBirth = dateOfBirth;
        }
        public Person() { }
        public Person(string fname,string lname, DateTime dateofbirth)
        {
            this.firstName = fname;
            this.lastName = lname;
            this._dateOfBirth = dateofbirth;
        }
        public int GetAge()
        {
            var currentDate = DateTime.Now.Year;
            return currentDate - _dateOfBirth.Year;

        }
    }
}
