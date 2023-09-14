using Northwind.Entitities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Olmaz!");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);

            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün Adı A İle Başlamalı!");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }


    }
}


      
        
    

