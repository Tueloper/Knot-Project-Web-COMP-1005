//using FluentValidation;
//using KnoxLogic.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace KnoxLogic.Validator
//{
//    public class Knot_SignUp_API_Validator:AbstractValidator<Knot_SignUp_API>
//    {
//        public Knot_SignUp_API_Validator()
//        {
//            RuleFor(p => p.Name)
//                .NotEmpty()
//                .WithMessage("Name is required")
//                .MaximumLength(20)
//                .WithMessage("Name is required");

//            RuleFor(p => p.Email)
//                .NotEmpty()
//                .WithMessage("Email is required")
//                .EmailAddress()
//                .WithMessage("Email address is not valid. Recheck");

//            RuleFor(p => p.Password)
//                .NotEmpty()
//                .WithMessage("Password is required")
//                .MaximumLength(10)
//                .WithMessage("Password must be at least 6 characters long");
//        }
//    }
//}
