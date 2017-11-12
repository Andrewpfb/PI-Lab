using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_1.Models
{
    public class DateValidAttr:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateForValidate;
            DateTime.TryParse(value.ToString(),out dateForValidate);
            bool check = false;
            check = dateForValidate < DateTime.Now ? true : false;
            DateTime ada = DateTime.Now.AddYears(-120);
            check = DateTime.Now.Year - dateForValidate.Year < 120 ? true : false;
            return (dateForValidate < DateTime.Now & DateTime.Now.Year-dateForValidate.Year < 120 ? true : false);
        }
        public override string FormatErrorMessage(string name)
        {
            return String.Format(
               "{0} введена неверно.", name);
        }
    }
}