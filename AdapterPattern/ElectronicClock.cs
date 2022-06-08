using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class ElectronicClock
    {
        public int Seconds { get; private set; }
        public int Minutes { get; private set; }
        public ElectronicClock()
        {
            Seconds = 0;
            Minutes = 0;
        }

        public void SetTime(int minutes, int seconds)
        {
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}
