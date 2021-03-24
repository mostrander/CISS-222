using System;
using System.Text;

namespace Homework_2
{
    public static class Decoding
    {
        public static string Decode(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            string base64Decoded = Encoding.ASCII.GetString(data);
            return base64Decoded;
        }
    }
}
