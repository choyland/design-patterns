using Factory.Customers.Interfaces;

namespace Factory.Customers
{
    public class StudentCustomer : ICustomer
    {
        public int CalculateDiscount()
        {
            return 20;
        }
    }
}