using System.Text;

namespace Cryptology.Core.Extensions
{
    public static class StringExtenstions
    {
        public static byte[] ToBytes(this string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        public static byte[] ToBytes(this string str)
        {
            return str.ToBytes(Encoding.UTF8);
        }
    }
}
