using System.Globalization;
using System.Runtime.CompilerServices;
using Cryptology.Core.Encoder;

namespace Cryptology.Rail.Encoder
{
    public class ElGamalEncoder : IEncoder
    {
        #region Constructors
        public ElGamalEncoder()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region IEncoder

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Encode(string text)
        {
            return string.Empty;
        }

        #endregion
    }
}
