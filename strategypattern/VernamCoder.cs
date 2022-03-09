using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategypattern
{
    class VernamCoder : ICoder
    {
        List<char> key = new();
        public char[] Decode(char[] message)
        {
            char[] DecodedMessage = new char[message.Length];
            if (message.Length<=key.Count)
            {
                
                for (int i = 0; i < message.Length; i++)
                {
                    DecodedMessage[i] = (char)(message[i] ^ key[i]);
                }
            }
            return DecodedMessage;
        }

        public char[] Encode(char[] message)
        {
            Random generator = new();
            char[] EncodedMessage = new char[message.Length];
            for(int i=0;i<message.Length;i++)
            {
                if(key.Count<i+1)
                {
                    key.Add((char)generator.Next(0, 256));
                }
                EncodedMessage[i] = (char)(message[i] ^ key[i]);
            }
            return EncodedMessage;
        }
    }
}
