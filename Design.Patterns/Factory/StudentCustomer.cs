namespace Factory
{
    public class StudentCustomer : ICustomer
    {
        public int CalculateDiscount()
        {
            return 20;
        }
    }
}