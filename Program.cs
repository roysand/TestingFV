// See https://aka.ms/new-console-template for more information

using FluentValidation.Results;using TestingFV.Domain;
using TestingFV.Util;

Console.WriteLine("Hello, World!");

var cus = new Customer("Roy", "SandMan");
ValidateCustomer(cus);

cus = new Customer("R", "Sand");
ValidateCustomer(cus);

bool ValidateCustomer(Customer cus)
{
    var cusValidator = new CustomerValidator();

    var cusValResult = cusValidator.Validate(cus);

    if(! cusValResult.IsValid) 
    {
        foreach(var failure in cusValResult.Errors)
        {
            Console.WriteLine("Property " + failure.PropertyName + "failed validation. Error was: " + failure.ErrorMessage + " attempted value: " + failure.AttemptedValue);
        }
    }
    else
    {
        Console.WriteLine("No errors found");
    }

    return cusValResult.IsValid;
}
