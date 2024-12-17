using System.Security.Cryptography;
using System.Text;

namespace PaymentSystems
{
    public class SHA1HashAlgorithm : IHashAlgorithm
    {
        public string ComputeHash(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using (var sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                StringBuilder stringBuilder = new StringBuilder();

                foreach (byte @byte in hashBytes)
                {
                    stringBuilder.Append(@byte.ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}