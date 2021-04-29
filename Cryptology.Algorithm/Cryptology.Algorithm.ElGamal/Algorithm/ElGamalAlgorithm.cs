using System.Runtime.CompilerServices;
using Cryptology.Core.Algorithm;
using Cryptology.ElGamal.Models;
using Cryptology.Rail.Decoder;
using Cryptology.Rail.Encoder;

namespace Cryptology.Rail.Algorithm
{
    public class ElGamalAlgorithm : IAlgorithm
    {
        #region Constructors
        public ElGamalAlgorithm()
        {
            Encoder = new ElGamalEncoder();
            Decoder = new ElGamalDecoder(new PrivateKey(1));
        }

        #endregion

        #region Properties
        public uint Key { get; }

        public bool FromTop { get; }

        public ElGamalEncoder Encoder { get; private set; }

        public ElGamalDecoder Decoder { get; private set; }
        #endregion

        #region IAlgorithm
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode(string code) => Decoder.Decode(code);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Encode(string text) => Encoder.Encode(text);
        #endregion
    }
}
