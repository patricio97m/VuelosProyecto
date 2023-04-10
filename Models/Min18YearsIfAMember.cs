using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Fecha de cumpleaños requerida");
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age > 18)
                ? ValidationResult.Success
                : new ValidationResult("El cliente debe tener mínimo 18 años para adquirir una membresía");
        }
    }
}