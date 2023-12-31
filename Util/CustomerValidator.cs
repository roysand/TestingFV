﻿using FluentValidation;
using TestingFV.Domain;

namespace TestingFV.Util;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(v => v.FirstName).Length(2, 20);
        RuleFor(v => v.LastName).Length(5, 40);
    }
}