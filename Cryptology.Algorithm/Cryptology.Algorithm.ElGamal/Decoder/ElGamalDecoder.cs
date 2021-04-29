using System.Runtime.CompilerServices;
using Cryptology.Core.Decoder;
using Cryptology.ElGamal.Models;

namespace Cryptology.Rail.Decoder
{
    public class ElGamalDecoder : IDecoder
    {
        private PrivateKey privateKey;
        #region Constructors
        public ElGamalDecoder(PrivateKey privateKey)
        {
            this.privateKey = privateKey;
        }

        #endregion

        #region Properties

        #endregion

        #region IDecoder

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode(string code)
        {
            for (var i = 0; i < code.Length; i += 2)
            {

            }

            return string.Empty;
        }

        #endregion

    }
}
