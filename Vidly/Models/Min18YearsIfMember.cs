﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if(customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if(customer.Birthdate == null)
                return new ValidationResult("Date of birth field can't be empty for member customers.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return age < 18 
                ? new ValidationResult("Member customers must be over 18 years of age.") 
                : ValidationResult.Success;
        }
    }
}