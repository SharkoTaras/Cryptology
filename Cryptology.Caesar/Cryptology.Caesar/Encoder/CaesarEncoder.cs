using System.Runtime.CompilerServices;
using System.Text;
using Cryptology.Core.Encoder;
using Cryptology.Core.Extensions;

namespace Cryptology.Caesar.Encoder
{
    public class CaesarEncoder : IEncoder
    {
        #region Constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CaesarEncoder()
        {
            this.Shift = default;
            this.Encoding = Encoding.UTF8;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CaesarEncoder(int shift, Encoding encoding)
        {
            this.Shift = shift;
            this.Encoding = encoding;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CaesarEncoder(int shift) : this(shift, Encoding.UTF8)
        {
        }
        #endregion

        #region Properties
        public int Shift { get; set; }

        public Encoding Encoding { get; set; }
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] Encode(string str)
        {
            var sb = new StringBuilder(str.Length);
            foreach (var letter in str)
            {
                if (char.IsLetter(letter))
                {
                    sb.Append(letter.Shift(this.Shift));
                }
                else
                {
                    sb.Append(letter);
                }
            }

            return sb.ToString().ToBytes(this.Encoding);
        }
    }
}
