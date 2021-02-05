using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Utils.DataValidation
{
    public class SalaryValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if((double)value < 0)
            {
                return false;
            }
            return true;
        }
    }
}
