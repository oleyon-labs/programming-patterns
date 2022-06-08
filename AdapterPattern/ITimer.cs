using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal interface ITimer
    {
        public void SetTimer(int seconds);
        public int GetTime();
    }
}
