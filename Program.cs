// See https://aka.ms/new-console-template for more information

using FluentValidation.Results;using TestingFV.Domain;
using TestingFV.Util;

Console.WriteLine("Hello, World!");

var cus = new Customer("Roy","Sand",new DateOnly(1962,7,10));
cus = new Customer("R","Sand",new DateOnly(1962,7,10));

ValidateCustomer(cus);

bool ValidateCustomer(Customer cus)
{
    var cusValidator = new CustomerValidator();

    var cusValResult = cusValidator.Validate(cus);

    if(! cusValResult.IsValid) 
    {
        foreach(var failure in cusValResult.Errors)
        {
            Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
        }
    }
    else
    {
        Console.WriteLine("No errors found");
    }

    return cusValResult.IsValid;
}
