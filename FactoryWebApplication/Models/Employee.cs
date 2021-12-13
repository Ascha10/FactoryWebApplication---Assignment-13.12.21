using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryWebApplication.Models
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int yearOfBirth;
        public string phone;

        Employee() { }
        public Employee(string firstName, string lastName, int yearOfBirth, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.phone = phone;
        }
    }
}