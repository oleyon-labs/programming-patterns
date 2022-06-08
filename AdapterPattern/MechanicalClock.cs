using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class MechanicalClock
    {
        public const int MechanicalClockInterval = 30;
        public double Turns { get; private set; }
        public MechanicalClock()
        {
            Turns = 0;
        }

        public void UnWind()
        {
            Turns = 0;
        }

        public void WindUp(double turns)
        {
            this.Turns += turns;
        }
    }
}
