using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Cryptology.Algorithm.DiffieHellman.Algorithm
{
    public class DiffieHellmanAlgorithm
    {
        private BigInteger P;
        private BigInteger G;

        #region Constructors
        public DiffieHellmanAlgorithm(BigInteger p)
        {
            P = p;
            G = GetPRoot(P);
        }
        #endregion

        #region Properties
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public BigInteger ModPow(BigInteger exponent, BigInteger modulus) => BigInteger.ModPow(G, exponent, modulus);
        #endregion

        #region Private Methods
        private BigInteger GetPRoot(BigInteger p)
        {
            for (BigInteger i = 0; i < p; i++)
            {
                if (IsPRoot(p, i))
                {
                    return i;
                }
            }

            return 0;
        }

        private bool IsPRoot(BigInteger p, BigInteger a)
        {
            if (a == 0 || a == 1)
            {
                return false;
            }

            BigInteger last = 1;
            var set = new HashSet<BigInteger>();
            for (BigInteger i = 0; i < p - 1; i++)
            {
                last = BigInteger.ModPow(BigInteger.Multiply(last, a), 1, p);
                if (set.Contains(last)) // Если повтор
                {
                    return false;
                }

                set.Add(last);
            }
            return true;
        }
        #endregion
    }
}
