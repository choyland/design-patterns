using System;
using Factory.Enum;
using Factory.Factories;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of customer are you? [E] for employee, [STU] for student or [STA] for standard");
            var input = Console.ReadLine();
            var customerType = GetCustomerTypeFromString(input);

            var concreteInstanceOfCustomer = new CustomerFactory().CreateCustomer(customerType);
            var percentageDiscount = concreteInstanceOfCustomer.CalculateDiscount();

            Console.WriteLine($"You get {percentageDiscount}% discount at ASOS!");
            Console.ReadLine();
        }

        private static CustomerType GetCustomerTypeFromString(string customerTypeAsString)
        {
            return customerTypeAsString.ToLower() switch
            {
                "e" => CustomerType.Employee,
                "stu" => CustomerType.Student,
                "sta" => CustomerType.Standard,
                _ => throw new ArgumentOutOfRangeException(nameof(customerTypeAsString), customerTypeAsString, null)
            };
        }
    }
}
