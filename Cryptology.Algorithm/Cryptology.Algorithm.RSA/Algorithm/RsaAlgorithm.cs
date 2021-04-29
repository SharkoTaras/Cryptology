using System.Numerics;
using System.Runtime.CompilerServices;
using Cryptology.Core.Algorithm;
using Cryptology.Core.Extensions;
using Cryptology.Rsa.Decoder;
using Cryptology.Rsa.Encoder;
using Cryptology.Rsa.Model;

namespace Cryptology.Rsa.Algorithm
{
    public class RsaAlgorithm : IAlgorithm
    {
        #region Private fields
        private RsaDecoder Decoder;
        private RsaEncoder Encoder;
        private BigInteger P;
        private BigInteger Q;
        #endregion

        #region Constructors
        public RsaAlgorithm(BigInteger p, BigInteger q)
        {
            P = p;
            Q = q;
            Init();
            Decoder = new RsaDecoder(PrivateKey);
            Encoder = new RsaEncoder(PublicKey);
        }
        #endregion

        #region Properties
        public PublicKey PublicKey { get; set; }

        public PrivateKey PrivateKey { get; set; }
        #endregion

        #region IAlgorithm
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode(string code) => Decoder.Decode(code);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Encode(string text) => Encoder.Encode(text);
        #endregion

        private void Init()
        {
            var n = BigInteger.Multiply(P, Q);
            var phin = BigInteger.Multiply(P - 1, Q - 1);

            BigInteger e = default;
            for (var i = 3; i < phin; i++)
            {
                if (i.IsCoPrime(phin))
                {
                    e = i;
                    break;
                }
            }
            BigInteger d = default;
            for (var i = 2; i < phin; i++)
            {
                if ((i * e) % phin == 1)
                {
                    d = i;
                    break;
                }
            }

            PublicKey = new PublicKey(n, e);
            PrivateKey = new PrivateKey(n, d);

            var t = (e * d) % phin;
        }
    }
}
