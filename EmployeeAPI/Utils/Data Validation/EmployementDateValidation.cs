using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Utils.DataValidation
{
    public class EmployementDateValidation : ValidationAttribute

    {
        public override bool IsValid(object value)
        {
            DateTime dt;
            bool parsed = DateTime.TryParse((string)value, out dt);
            if (!parsed)
            {
                return false;
            }
            if(DateTime.Compare(dt, DateTime.Now) > 0)
            {
                return false;
            }
            if (DateTime.Compare(dt, new DateTime(2000, 01, 01)) < 0)
            {
                return false;
            }
            return true;
        }
    }
}
