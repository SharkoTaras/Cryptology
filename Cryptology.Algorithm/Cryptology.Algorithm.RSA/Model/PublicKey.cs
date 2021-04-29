using System.Numerics;

namespace Cryptology.Rsa.Model
{
    public sealed class PublicKey
    {
        #region Constructors
        public PublicKey()
        {
        }

        public PublicKey(BigInteger n, BigInteger e)
        {
            N = n;
            E = e;
        }
        #endregion

        #region Properties
        public BigInteger N { get; set; }

        public BigInteger E { get; set; }
        #endregion
    }
}
