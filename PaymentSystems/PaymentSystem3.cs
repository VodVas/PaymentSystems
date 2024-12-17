namespace PaymentSystems
{
    public class PaymentSystem3 : IPaymentSystem
    {
        private readonly IHashAlgorithm _hashAlgorithm;
        private readonly string _secretKey;

        public PaymentSystem3(IHashAlgorithm hashAlgorithm, string secretKey)
        {
            if (hashAlgorithm == null)
            {
                throw new ArgumentNullException(nameof(hashAlgorithm));
            }

            if (secretKey == null)
            {
                throw new ArgumentNullException(nameof(secretKey));
            }

            _hashAlgorithm = hashAlgorithm;
            _secretKey = secretKey;
        }

        public string GetPayingLink(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            string input = $"{order.Amount}{order.Id}{_secretKey}";
            string hash = _hashAlgorithm.ComputeHash(input);
            string link = $"system3.com/pay?amount={order.Amount}&currency=RUB&hash={hash}";

            return link;
        }
    }
}