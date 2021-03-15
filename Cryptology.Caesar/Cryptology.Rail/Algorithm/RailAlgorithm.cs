using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cryptology.Core.Algorithm;
using Cryptology.Core.Extensions;
using Cryptology.Rail.Decoder;
using Cryptology.Rail.Encoder;
using Cryptology.Rail.Model;

namespace Cryptology.Rail.Algorithm
{
    public class RailAlgorithm : IAlgorithm
    {
        #region Constructors
        public RailAlgorithm(uint key, bool fromTop = false)
        {
            Key = key;
            FromTop = fromTop;
            Encoder = new RailEncoder(Key, FromTop);
            Decoder = new RailDecoder(Key, FromTop);
        }

        #endregion

        #region Properties
        public uint Key { get; }
        public bool FromTop { get; }
        #endregion

        #region IAlgorithm
        public string Decode(byte[] bytes)
        {
            var code = bytes.FromBytes();
            //var rfp = new string[Key, code.Length];

            //for (var x = 0; x < rfp.Length; x++)
            //{
            //    for (var y = 0; y < rfp; y++)
            //    {
            //        rfp[x][y] = ".";
            //    }
            //}       

            //// arrange accroding to fence rail
            //var count = 0;
            //var c = 1;
            //int a = 0, b = 0;
            //int init = (2 * key) - 2;
            //a = init - 2;
            //b = 2;
            //for (var i = 0; i < rfp.length; i++)
            //{
            //    c = 0;
            //    for (var u = i; u < rfp[i].length;)
            //    {
            //        if (count != text.length())
            //        {
            //            if (i == 0 || i == key - 1)
            //            {
            //                rfp[i][u] = "" + text.charAt(count);
            //                u = u + init;
            //            }
            //            else
            //            {
            //                rfp[i][u] = "" + text.charAt(count);
            //                if (c % 2 == 0)
            //                {
            //                    u = u + a;
            //                }
            //                else if (c % 2 == 1)
            //                {
            //                    u = u + b;
            //                }

            //                c++;
            //            }
            //            count++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    if (i != 0 && i != key - 1)
            //    {
            //        a = a - 2;
            //        b = b + 2;
            //    }
            //}

            ////display
            //System.out.println("\n\nDecrypting..list into table");

            //for (var i = 0; i < rfp.length; i++)
            //{
            //    for (var u = 0; u < rfp[i].length; u++)
            //    {
            //        System.out.print(rfp[i][u] + " ");
            //    }
            //    System.out.println();
            //}

            //var move = 1;
            //count = 0;
            //String sb = "";
            //for (var i = 0; i < text.length(); i++)
            //{
            //    if ((move % 2) != 0)
            //    {
            //        sb = sb + rfp[count][i];
            //        if (count == (key - 1))
            //        {
            //            move = 2;
            //            count = (key - 2);
            //        }
            //        else
            //        {
            //            count++;
            //        }
            //    }
            //    else if ((move % 2) == 0)
            //    {
            //        sb = sb + rfp[count][i];
            //        if (count == 0)
            //        {
            //            move = 1;
            //            count = 1;
            //        }
            //        else
            //        {
            //            count--;
            //        }
            //    }

            //}

            return default;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] Encode(string str) => Encoder.RailEncoder(str)
        #endregion

        #region Overrides
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
