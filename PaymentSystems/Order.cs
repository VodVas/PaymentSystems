namespace PaymentSystems
{
    public class Order
    {
        public int Id { get; private set; }
        public int Amount { get; private set; }

        public Order(int id, int amount)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID заказа не может быть отрицательным", nameof(id));
            }

            if (amount <= 0)
            {
                throw new ArgumentException("Сумма не может быть отрицательной", nameof(amount));
            }

            Id = id;
            Amount = amount;
        }
    }
}