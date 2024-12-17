namespace PaymentSystems
{
    public interface IHashAlgorithm
    {
        string ComputeHash(string input);
    }
}