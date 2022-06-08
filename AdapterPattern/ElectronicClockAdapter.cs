using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class ElectronicClockAdapter:ITimer
    {
        private ElectronicClock _clock;

        public ElectronicClockAdapter(ElectronicClock clock)
        {
            _clock = clock;
        }

        public int GetTime()
        {
            return _clock.Minutes * 60 + _clock.Seconds;
        }

        public void SetTimer(int seconds)
        {
            _clock.SetTime(seconds/60, seconds%60);
        }
    }
}
