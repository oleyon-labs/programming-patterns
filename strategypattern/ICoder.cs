using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategypattern
{
    interface ICoder
    {
        char[] Encode(char[] message);
        char[] Decode(char[] message);
    }
}
