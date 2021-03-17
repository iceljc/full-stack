using System;
using System.Collections.Generic;
using System.Text;

namespace MySystem.Utility.Exceptions
{
    class AgeException : ApplicationException
    {
        private int ageLower = 0, ageUpper = 0;

        public AgeException()
        {

        }

        public AgeException(int lowerAge, int upperAge)
        {
            ageLower = lowerAge;
            ageUpper = upperAge;
        }

        public override string Message
        {
            get 
            {
                return "Age must between " + ageLower + " and " + ageUpper;
            }
        }
    }
}
