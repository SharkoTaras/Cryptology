using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cryptology.Core.Decoder;
using Cryptology.Core.Extensions;
using Cryptology.Core.Utils;

namespace Criptology.Affine.Decoder
{
    public class AffineDecoder : IDecoder
    {
        #region Constructors
        public AffineDecoder(uint alpha, uint betta)
        {
            Alpha = alpha;
            Betta = betta;
            M = (uint)Utils.LetterNumbers.Count;
        }


        #endregion

        #region Properties
        public uint Alpha { get; }

        public uint Betta { get; }

        public uint M { get; }
        #endregion

        #region IDecoder
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode(byte[] bytes)
        {
            var outData = new StringBuilder();
            char decryptedLetter;
            uint charCode;
            var text = bytes.FromBytes();
            foreach (var c in text)
            {
                if (char.IsLetter(c))
                {
                    charCode = Utils.LetterNumbers[c];
                    decryptedLetter = Utils.LetterNumbers.Where((k, v) => v == D(charCode)).First().Key;
                    outData.Append(decryptedLetter.ToString());
                }
                else
                {
                    outData.Append(c);
                }
            }
            return outData.ToString();
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Private Methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private uint D(uint y)
        {
            return CalcualteReverseKey() * (y + M - Betta) % M;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private uint CalcualteReverseKey()
        {
            var reverseKey = 1u;
            while (reverseKey++ * Alpha % M != 1)
            {
            }

            return reverseKey;
        }
        #endregion
    }
}
