using System;

namespace Factory
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