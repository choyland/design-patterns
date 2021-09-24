using Factory.Customers.Interfaces;

namespace Factory.Customers
{
    public class StandardCustomer : ICustomer
    {
        public int CalculateDiscount()
        {
            return 0;
        }
    }
}