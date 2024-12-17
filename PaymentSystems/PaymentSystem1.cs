namespace PaymentSystems
{
    public class PaymentSystem1 : IPaymentSystem
    {
        private readonly IHashAlgorithm _hashAlgorithm;

        public PaymentSystem1(IHashAlgorithm hashAlgorithm)
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


            string hash = _hashAlgorithm.ComputeHash(order.Id.ToString());
            string link = $"pay.system1.ru/order?amount={order.Amount}RUB&hash={hash}";

            return link;
        }
    }
}