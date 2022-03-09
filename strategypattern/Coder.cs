using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategypattern
{
    class Coder
    {
        ICoder coder;
        public Coder(ICoder coder)
        {
            this.coder = coder;
        }
        public char[] Encode(char[] message)
        {
            return coder.Encode(message);
        }
        public char[] Decode(char[] message)
        {
            return coder.Decode(message);
        }
    }
}
