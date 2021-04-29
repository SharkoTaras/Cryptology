using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Cryptology.Core.Encoder;
using Cryptology.Rsa.Model;

namespace Cryptology.Rsa.Encoder
{
    public class RsaEncoder : IEncoder
    {
        private PublicKey Key;

        #region Constructors
        public RsaEncoder(PublicKey key)
        {
            Key = key;
        }

        #endregion

        #region IEncoder
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Encode(string text)
        {
            var code = new StringBuilder();
            foreach (var item in text)
            {
                var m = BigInteger.ModPow((int)item, Key.E, Key.N);
                code.Append((char)m);
            }

            return code.ToString();
        }
        #endregion
    }
}
