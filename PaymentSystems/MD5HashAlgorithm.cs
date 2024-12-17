using System.Security.Cryptography;
using System.Text;

namespace PaymentSystems
{
    public class MD5HashAlgorithm : IHashAlgorithm
    {
        public string ComputeHash(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                foreach (byte @byte in hashBytes)
                {
                    sb.Append(@byte.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}