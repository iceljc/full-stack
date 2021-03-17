using System;
using System.Collections.Generic;
using System.Text;
using MySystem.Utility.Exceptions;

namespace MySystem.Data.Models
{
    class Employee
    {
        private int age;
        private int lowerAge = 18, upperAge = 60;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public int Age 
        {
            get { return age; }
            set 
            {
                age = value;
                if (age < lowerAge || age > upperAge)
                {
                    throw new AgeException(lowerAge, upperAge);
                }
            }
        }
    }
}
