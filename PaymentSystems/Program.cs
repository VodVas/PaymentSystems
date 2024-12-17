namespace PaymentSystems
{
    internal class Program
    {
        static void Main()
        {
            Order order = new Order(12345, 12000);

            IPaymentSystem system1 = new PaymentSystem1(new MD5HashAlgorithm());
            IPaymentSystem system2 = new PaymentSystem2(new MD5HashAlgorithm());
            IPaymentSystem system3 = new PaymentSystem3(new SHA1HashAlgorithm(), "SecretKey123");

            Console.WriteLine(system1.GetPayingLink(order));
            Console.WriteLine(system2.GetPayingLink(order));
            Console.WriteLine(system3.GetPayingLink(order));
        }
    }
}