using System.Runtime.CompilerServices;

namespace Cryptology.Core.Utils
{
    public class Checker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Ensure(bool condition, string message = null)
        {
            if (!condition)
            {
                ExeptionHelper.Throw(message);
            }
        }
    }
}
