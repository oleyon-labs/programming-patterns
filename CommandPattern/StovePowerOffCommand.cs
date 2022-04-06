using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class StovePowerOffCommand : ICommand
    {
        Stove stove;
        public StovePowerOffCommand(Stove stove)
        {
            this.stove = stove;
        }
        public void Execute()
        {
            stove.PowerOff();
        }

        public void Undo()
        {
            stove.Set50MaxPower();
        }
    }
}
