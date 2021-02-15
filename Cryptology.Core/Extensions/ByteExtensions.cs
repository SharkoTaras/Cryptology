using System.Text;

namespace Cryptology.Core.Extensions
{
    public static class ByteExtensions
    {
        public static string FromBytes(this byte[] bytes, Encoding encoding)
        {
            return encoding.GetString(bytes);
        }

        public static string FromBytes(this byte[] bytes)
        {
            return bytes.FromBytes(Encoding.UTF8);
        }
    }
}
