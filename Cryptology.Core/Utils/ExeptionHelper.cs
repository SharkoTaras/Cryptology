using System;
using System.Runtime.CompilerServices;

namespace Cryptology.Core.Utils
{
    public static class ExeptionHelper
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowIf(bool condition, string message = null)
        {
            if (condition)
            {
                throw new Exception(message);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowIfNull<T>(T obj, string message = null)
        {
            if (obj is null)
            {
                throw new System.ArgumentNullException("obj", message);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Throw(string message = null) => throw new Exception(message);
    }
}
