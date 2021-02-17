using System.Runtime.CompilerServices;
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
        private Encoding encoding;
        private int shift;

        #region Constructors
        public CaesarAlgorithm()
        {
            this.decoder = new CaesarDecoder();
            this.encoder = new CaesarEncoder();
            this.Shift = default;
            this.Encoding = Encoding.UTF8;
        }

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
        public int Shift
        {
            get
            {
                return this.shift;
            }
            set
            {
                if (value != this.shift)
                {
                    this.shift = value;
                    this.decoder.Shift = value;
                    this.encoder.Shift = value;
                }
            }
        }

        public Encoding Encoding
        {
            get
            {
                return this.encoding;
            }

            set
            {
                if (this.encoding != value)
                {
                    this.encoding = value;
                    this.encoder.Encoding = value;
                    this.decoder.Encoding = value;
                }
            }
        }
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode(byte[] bytes)
        {
            return this.decoder.Decode(bytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] Encode(string str)
        {
            return this.encoder.Encode(str);
        }
    }
}
