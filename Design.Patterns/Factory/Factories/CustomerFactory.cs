using System;
using Factory.Customers;
using Factory.Customers.Interfaces;
using Factory.Enum;

namespace Factory.Factories
{
    public class CustomerFactory
    {
        public ICustomer CreateCustomer(CustomerType customerType)
        {
            return customerType switch
            {
                CustomerType.Employee => new EmployeeCustomer(),
                CustomerType.Student => new StudentCustomer(),
                CustomerType.Standard => new StandardCustomer(),
                _ => throw new ArgumentOutOfRangeException(nameof(customerType), customerType, null)
            };
        }
    }
}