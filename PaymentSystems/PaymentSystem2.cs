namespace PaymentSystems
{
    public class PaymentSystem2 : IPaymentSystem
    {
        private readonly IHashAlgorithm _hashAlgorithm;

        public PaymentSystem2(IHashAlgorithm hashAlgorithm)
        {
            if (hashAlgorithm == null)
            {
                throw new ArgumentNullException(nameof(hashAlgorithm));
            }

            _hashAlgorithm = hashAlgorithm;
        }

        public string GetPayingLink(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            string input = $"{order.Id}{order.Amount}";
            string hash = _hashAlgorithm.ComputeHash(input);
            string link = $"order.system2.ru/pay?hash={hash}";

            return link;
        }
    }
}