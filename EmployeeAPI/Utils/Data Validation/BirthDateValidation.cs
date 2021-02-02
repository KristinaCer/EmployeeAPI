using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Utils.DataValidation
{
    public class BirthDateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dt;
            bool parsed = DateTime.TryParse((string)value, out dt);
            if (!parsed)
            {
                return false;
            }
            int age = calculateAge(dt);
            if ( age > 70 || age < 18)
            {
                return false;
            }
            return true;
        }

        public int calculateAge(DateTime dt)
        {
            var today = DateTime.Today;
            var age = today.Year - dt.Year;
            // Go back to the year in which the person was born in case of a leap year
            if (dt.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
