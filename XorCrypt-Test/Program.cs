using Crypt;
using System;

namespace XorCrypt_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Test1";
            Console.WriteLine("Text: " + text);
            var xoredText = Xor.XorString(text);
            Console.WriteLine("Xored: " + xoredText);
            var enxoredText = Xor.XorString(xoredText);
            Console.WriteLine("Enxored: " + Xor.XorString(xoredText));
            Console.WriteLine("Equals: " + enxoredText.Equals(text));

            Console.ReadKey();
        }
    }
}
