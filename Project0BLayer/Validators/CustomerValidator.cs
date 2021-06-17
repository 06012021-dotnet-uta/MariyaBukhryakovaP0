using FluentValidation;
using Project0BLayer.AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preoject_O.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {

            RuleFor(p => p.CustomerFirstName).Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("{PropertyName} is is Empty").Length(2, 50)
            .WithMessage("{PropertyName} is not a valid length ").
            Must(ValidNameEntry).WithMessage("{PropertyName} contians invalid characters");

            RuleFor(p => p.CustomerLastName).Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("{PropertyName} is is Empty").Length(2, 50)
            .WithMessage("{PropertyName} is not a valid length ").
            Must(ValidNameEntry).WithMessage("{PropertyName} contians invalid characters");

            RuleFor(p => p.AccountUserName).Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("{PropertyName} is is Empty ").Length(2, 50)
            .WithMessage("{PropertyName} is not a valid length ");

            RuleFor(p => p.PassWord).Cascade(CascadeMode.Stop)
          .NotEmpty().WithMessage("{PropertyName} is is Empty ").Length(2, 500)
          .WithMessage("{PropertyName} is not a valid length ");

            RuleFor(p => p.CustomerEmail).Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("{PropertyName} is is Empty").Length(6, 50)
            .WithMessage("{PropertyName} is not a valid length ").
            Must(ValidEmailEntry).WithMessage("{PropertyName} is not in a valid format");

            RuleFor(p => p.CustomerStreet).Cascade(CascadeMode.Stop)
           .NotEmpty().WithMessage("{PropertyName} is is Empty ").Length(3, 100)
           .WithMessage("{PropertyName} is not a valid length ");


            RuleFor(p => p.CustomerCity).Cascade(CascadeMode.Stop)
           .NotEmpty().WithMessage("{PropertyName} is is Empty ").Length(3, 50)
           .WithMessage("{PropertyName} is not a valid length ")
           .Must(ValidNameEntry).WithMessage("{PropertyName} contians invalid characters");

            RuleFor(p => p.CustomerState).Cascade(CascadeMode.Stop)
           .NotEmpty().WithMessage("{PropertyName} is is Empty ").Length(2)
           .WithMessage("{PropertyName} is not a valid length ")
           .Must(ValidNameEntry).WithMessage("{PropertyName} contians invalid characters");

            RuleFor(p => p.AcStore)
             .Must(ValidNumberEntry).WithMessage("{PropertyName} contians invalid selection");
        }

        protected bool ValidNameEntry(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);

        }

        protected bool ValidEmailEntry(string email)
        {
            email = email.Replace(" ", "");

            return email.Contains('@');

        }

        protected bool ValidNumberEntry(int input)
        {
            if (input < 1 || input > 5000)
            {
                return false;
            }
            return true;

        }
    }
}
