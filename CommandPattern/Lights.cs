using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Lights
    {
        public void On()
        {
            Console.WriteLine("lights on");
        }
        public void Off()
        {
            Console.WriteLine("lights off");
        }
    }
}
