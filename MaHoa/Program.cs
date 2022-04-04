using System;
using System.Text;

namespace App.Helpers
{
    public static class ExtensionMethods
    {
        public static string EncodeString(this string value)
        {
            var valueBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(valueBytes);
        }
        public static byte[] EncodeBaseByte(this string value)
        {
            byte[] valueBytes = Encoding.UTF8.GetBytes(value);
            System.Text.Encoding.UTF8.GetString(valueBytes);
            Console.Write("Ma hoa Byte: ");
            for (int i = 0; i < valueBytes.Length - 1; i++)
            {
                Console.Write(valueBytes[i]+" ");
            }
            Console.Write("\n");
            return valueBytes;
        }

        public static string DecodeString(this string value)
        {
            var valueBytes = System.Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(valueBytes);
        }
        public static string DecodeByte(this byte[] value)
        {
            var valueBytes = System.Text.Encoding.UTF8.GetString(value);
            return valueBytes;
        }
    }
}


namespace MaHoa
{
    using App.Helpers;
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Pitagon Da Bestz";
            string base64EncodedString = password.EncodeString();
            byte[] byteEncodeded = password.EncodeBaseByte();
            string stringDecode = base64EncodedString.DecodeString();
            string byteDecode = byteEncodeded.DecodeByte();
            Console.WriteLine("Ma hoa string : {0}",base64EncodedString);
            Console.WriteLine("Giai ma string : {0}", stringDecode);
            Console.WriteLine("Giai ma byte : {0}", byteDecode);
            Console.ReadKey();
        }

       
    }
}

