using System.Collections.Generic;
using System.Linq;
using Cryptology.Core.Encoder;
using Cryptology.Core.Extensions;
using Cryptology.Rail.Model;

namespace Cryptology.Rail.Encoder
{
    public class RailEncoder : IEncoder
    {
        #region Constructors
        public RailEncoder(uint key, bool fromTop = false)
        {
            Key = key;
            FromTop = fromTop;
        }

        #endregion

        #region Properties

        public uint Key { get; }

        public bool FromTop { get; }

        #endregion

        #region IEncoder

        public byte[] Encode(string str)
        {
            var data = new List<RailCellData>();
            for (var i = 0u; i < str.Length; i++)
            {
                if (char.IsLetter(str[(int)i]))
                {
                    data.Add(new RailCellData
                    {
                        Letter = char.ToLower(str[(int)i]),
                        NumberInText = i,
                        RailNumber = FromTop ? Key - (i % Key) : i % Key
                    });
                }
            }

            var code = data.OrderByDescending(d => d.RailNumber).ThenBy(d => d.NumberInText).Select(d => d.Letter).ToArray();

            return new string(code).ToBytes();
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
