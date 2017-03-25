// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// ======================================

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace medicme.ViewModels
{
    public class PatientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

   
    }




    public class PatientViewModelValidator : AbstractValidator<PatientViewModel>
    {
        public PatientViewModelValidator()
        {
            RuleFor(register => register.Name).NotEmpty().WithMessage("Patient name cannot be empty");
            RuleFor(register => register.Gender).NotEmpty().WithMessage("Gender cannot be empty");
        }
    }
}
