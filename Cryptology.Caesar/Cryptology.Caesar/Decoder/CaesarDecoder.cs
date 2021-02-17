using System.Text;
using Cryptology.Core.Decoder;
using Cryptology.Core.Extensions;

namespace Cryptology.Caesar.Decoder
{
    public class CaesarDecoder : IDecoder
    {
        #region Constructors
        public CaesarDecoder()
        {
            this.Shift = default;
            this.Encoding = Encoding.UTF8;
        }

        public CaesarDecoder(int shift, Encoding encoding)
        {
            this.Shift = shift;
            this.Encoding = encoding;
        }

        public CaesarDecoder(int shift) : this(shift, Encoding.UTF8)
        {
        }
        #endregion

        #region Properties
        public int Shift { get; set; }

        public Encoding Encoding { get; set; }
        #endregion

        public string Decode(byte[] bytes)
        {
            var str = bytes.FromBytes(this.Encoding);
            var sb = new StringBuilder();
            foreach (var letter in str)
            {
                if (char.IsLetter(letter))
                {
                    sb.Append(letter.Shift(-this.Shift));
                }
                else
                {
                    sb.Append(letter);
                }
            }
            return sb.ToString();
        }
    }
}
