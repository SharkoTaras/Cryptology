namespace Cryptology.ElGamal.Models
{
    public class PrivateKey
    {
        #region Constructors
        public PrivateKey(ulong x)
        {
            X = x;
        }

        #endregion

        #region Properties
        public ulong X { get; }
        #endregion
    }
}
