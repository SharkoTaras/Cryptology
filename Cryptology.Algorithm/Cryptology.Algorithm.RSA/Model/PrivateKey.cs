using System.Numerics;

namespace Cryptology.Rsa.Model
{
    public sealed class PrivateKey
    {
        #region Constructors
        public PrivateKey()
        {
        }

        public PrivateKey(BigInteger n, BigInteger d)
        {
            N = n;
            D = d;
        }
        #endregion

        #region Properties
        public BigInteger N { get; set; }

        public BigInteger D { get; set; }
        #endregion
    }
}
