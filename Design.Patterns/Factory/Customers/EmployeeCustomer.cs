using Factory.Customers.Interfaces;

namespace Factory.Customers
{
    public class EmployeeCustomer : ICustomer
    {
        public int CalculateDiscount()
        {
            return 40;
        }
    }
}