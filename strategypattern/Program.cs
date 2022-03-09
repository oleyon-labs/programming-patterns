using System;

namespace strategypattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Coder coder = new Coder(new VernamCoder());
            char[] message = "abcz23".ToCharArray();
            var encoded = coder.Encode(message);
            Console.WriteLine(encoded);
            Console.WriteLine(coder.Decode(encoded));
        }
    }
}
