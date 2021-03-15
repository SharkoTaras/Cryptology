using System.Runtime.CompilerServices;
using System.Text;
using Cryptology.Caesar.Algorithm;
using Cryptology.Core.Encoder;
using Cryptology.Core.Extensions;
using Cryptology.Core.Utils;

namespace Cryptology.Vijender.Encoder
{
    public class VijenderEncoder : IEncoder
    {
        #region Private Fields

        private CaesarAlgorithm CaesarAlgorithm;

        #endregion

        #region Constructors
        public VijenderEncoder(string key)
        {
            Key = key;
            CaesarAlgorithm = new CaesarAlgorithm();
        }


        #endregion

        #region Properties

        public string Key { get; }

        #endregion

        #region IEncoder
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] Encode(string str)
        {
            var code = new StringBuilder();

            var j = 0;
            foreach (var letter in str)
            {
                CaesarAlgorithm.Shift = (int)Utils.LetterNumbers[Key[j++]];
                var bytes = CaesarAlgorithm.Encode(letter.ToString());
                code.Append(bytes.FromBytes());
                if (j >= Key.Length)
                {
                    j = 0;
                }
            }
            return code.ToString().ToBytes();

        }
        #endregion
        #region Overrides
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
