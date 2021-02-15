using System.Text;
using Cryptology.Caesar.Decoder;
using Cryptology.Caesar.Encoder;
using Cryptology.Core.Algorithm;

namespace Cryptology.Caesar.Algorithm
{
    public class CaesarAlgorithm : IAlgorithm
    {
        private readonly CaesarDecoder decoder;
        private readonly CaesarEncoder encoder;

        #region Constructors
        public CaesarAlgorithm(int shift, Encoding encoding)
        {
            this.Shift = shift;
            this.Encoding = encoding;
            this.decoder = new CaesarDecoder(this.Shift, encoding);
            this.encoder = new CaesarEncoder(this.Shift, encoding);
        }

        public CaesarAlgorithm(int shift) : this(shift, Encoding.UTF8)
        {
        }
        #endregion

        #region Properties
        public int Shift { get; }

        public Encoding Encoding { get; }
        #endregion

        public string Decode(byte[] bytes)
        {
            return this.decoder.Decode(bytes);
        }

        public byte[] Encode(string str)
        {
            return this.encoder.Encode(str);
        }
    }
}
