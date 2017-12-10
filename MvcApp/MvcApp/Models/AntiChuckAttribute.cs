using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcNov17.Models
{
 
    public class AntiChuckAttribute : ValidationAttribute, IClientValidatable
    {
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
            ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule AntiChuck = new ModelClientValidationRule
            {
                ErrorMessage = ErrorMessageString,
                ValidationType = "antichuck"
            };
            yield return AntiChuck;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.ToString().ToUpper()=="CHUCK")
            {
                return new ValidationResult(ErrorMessage??"Seul Chuck peut passer ce control");
            }
            return null;
        }

    }
}