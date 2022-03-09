using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategypattern
{
    class AtbashCoder : ICoder
    {
        const int shift = 26;
        public char[] Decode(char[] message)
        {
            return Encode(message);
            //char[] EncodedMessage = new char[message.Length];
            //for (int i = 0; i < message.Length; i++)
            //{
            //    if (isSymbol((char)message[i]))
            //        EncodedMessage[i] = (char)((int)'z' - (message[i] - 'a'));
            //    else
            //        EncodedMessage[i] = message[i];
            //}
            //return EncodedMessage;
        }

        public char[] Encode(char[] message)
        {
            char[] EncodedMessage = new char[message.Length];
            for(int i = 0; i < message.Length; i++)
            {
                if (isSymbol((char)message[i]))
                    EncodedMessage[i] = (char)((int)'z' - (message[i]-'a'));
                else
                    EncodedMessage[i] = message[i];
            }
            return EncodedMessage;
        }

        //EncodeSymbol(char s)
        //{
        //    if(isSymbol(s))
        //    {
        //        return 
        //    }
        //    return s;
        //}
        public bool isSymbol(char s)
        {
            if (s >= 'A' && s <= 'Z' || s >= 'a' && s <= 'z')
                return true;
            else return false;
        }
    }
}
