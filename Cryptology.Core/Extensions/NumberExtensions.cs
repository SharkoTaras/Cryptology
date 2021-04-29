using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Cryptology.Core.Extensions
{
    public static class NumberExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPrime(this int number)
        {
            var m = number / 2;
            for (var i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsCoPrime(this int a, int b) => GCD(a, b) == 1;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsCoPrime(this int a, BigInteger b) => GCD(a, b) == 1;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsCoPrime(this BigInteger a, BigInteger b) => GCD(a, b) == 1;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GCD(this int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            if (a == b)
            {
                return a;
            }

            if (a > b)
            {
                return GCD(a - b, b);
            }

            return GCD(a, b - a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BigInteger GCD(this BigInteger a, BigInteger b)
        {
            var gcdd = BigInteger.GreatestCommonDivisor(a, b);
            return gcdd;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BigInteger GCD(this int a, BigInteger b)
        {
            return BigInteger.GreatestCommonDivisor(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MultiplicativeInverse(this int e, int fi)
        {
            double result;
            var k = 1;
            while (true)
            {
                result = (1 + (k * fi)) / (double)e;
                if ((Math.Round(result, 5) % 1) == 0) //integer
                {
                    return (int)result;
                }
                else
                {
                    k++;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MultiplicativeInverse(this BigInteger e, int fi)
        {
            double result;
            var k = 1;
            while (true)
            {
                result = (1 + (k * fi)) / (double)e;
                if ((Math.Round(result, 5) % 1) == 0) //integer
                {
                    return (int)result;
                }
                else
                {
                    k++;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MultiplicativeInverse(this BigInteger e, BigInteger fi) => e.MultiplicativeInverse((int)fi);
    }
}

