namespace Lab6_64050028
{
    public class DelinquentCustomer : Customer
    {
        public override string CreateMail()
        {
            return "Delinquent Customer";
        }
    }
}