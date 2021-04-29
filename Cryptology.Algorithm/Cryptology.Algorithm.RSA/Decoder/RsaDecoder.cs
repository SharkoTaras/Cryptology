using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Cryptology.Core.Decoder;
using Cryptology.Rsa.Model;

namespace Cryptology.Rsa.Decoder
{
    public class RsaDecoder : IDecoder
    {
        private PrivateKey Key;

        #region Constructors
        public RsaDecoder(PrivateKey key)
        {
            Key = key;
        }

        #endregion

        #region IDecoder
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode(string code)
        {
            var text = new StringBuilder();
            foreach (var item in code)
            {
                var c = BigInteger.ModPow((int)item, Key.D, Key.N);
                text.Append((char)c);
            }

            return text.ToString();
        }
        #endregion
    }
}
