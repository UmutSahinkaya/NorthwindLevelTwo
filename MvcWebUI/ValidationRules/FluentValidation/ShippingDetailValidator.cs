using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MvcWebUI.Models;

namespace MvcWebUI.ValidationRules.FluentValidation
{
 public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
 {
  public ShippingDetailValidator()
  {
     RuleFor(s => s.FirstName).NotEmpty().WithMessage("Adı Gereklidir");
     RuleFor(s => s.FirstName).MinimumLength(2);
     //RuleFor(s => s.FirstName).Must(StartWithA);
     RuleFor(s => s.LastName).NotEmpty();
     RuleFor(s => s.Address).NotEmpty();
     RuleFor(s => s.Age).NotEmpty();
     RuleFor(s => s.City).NotEmpty().When(s => s.Age < 18);
     

     
  }
  private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
