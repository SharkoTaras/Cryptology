using System.Runtime.CompilerServices;
using Cryptology.Core.Decoder;

namespace Cryptology.Rail.Decoder
{
    public class RailDecoder : IDecoder
    {
        #region Constructors
        public RailDecoder(uint key, bool fromTop = false)
        {
            Key = key;
            FromTop = fromTop;
        }

        #endregion

        #region Properties

        public uint Key { get; }

        public bool FromTop { get; }

        #endregion

        #region IDecoder

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode(byte[] bytes)
        {
            return default;
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
