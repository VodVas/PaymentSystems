# Payment Link Generator Project

This is a simple C# project designed to generate payment links 
for different payment systems based on specific requirements. 
The project demonstrates the use of classes, interfaces, 
and hashing algorithms to produce secure and formatted payment links.

# Hashing Algorithms

The project utilizes MD5 and SHA-1 hashing algorithms to create secure 
hashes for order identifiers and amounts.

# Example Usage
In the Main method, instances of different payment systems are created, 
and payment links are generated based on an example order:

```namespace PaymentLinkGenerator
{
    class Program
    {
        static void Main(string[] args)
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
