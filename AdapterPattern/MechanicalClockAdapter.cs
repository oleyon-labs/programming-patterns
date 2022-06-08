using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class MechanicalClockAdapter : ITimer
    {
        private MechanicalClock _clock;

        public MechanicalClockAdapter(MechanicalClock clock)
        {
            _clock = clock;
        }

        public int GetTime()
        {
            return (int)(_clock.Turns * MechanicalClock.MechanicalClockInterval);
        }

        public void SetTimer(int seconds)
        {
            _clock.UnWind();
            _clock.WindUp(seconds / (double)MechanicalClock.MechanicalClockInterval);
        }
    }
}
