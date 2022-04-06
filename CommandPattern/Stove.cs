using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Stove
    {
        public enum State { Off, Half,Max}
        public State state { get; private set; }
        public void Set50MaxPower()
        {
            state=State.Half;
            Console.WriteLine("stove 50 max power");
        }
        public void Set100MaxPower()
        {
            state = State.Max;
            Console.WriteLine("stove 100 max power");
        }
        public void PowerOff()
        {
            state = State.Off;
            Console.WriteLine("stove power off");
        }
    }
}
