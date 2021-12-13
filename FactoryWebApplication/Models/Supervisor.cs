using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryWebApplication.Models
{
    public class Supervisor
    {
        public string firstName;
        public string lastName;
        public int yearOfBirth;
        public int experience;

        Supervisor() { }
        public Supervisor(string firstName, string lastName, int yearOfBirth, int experience)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.experience = experience;
        }

    }
}