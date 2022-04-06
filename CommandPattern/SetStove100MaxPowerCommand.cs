using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class SetStove100MaxPowerCommand : ICommand
    {
        Stove stove;
        public SetStove100MaxPowerCommand(Stove stove)
        {
            this.stove = stove;
        }
        public void Execute()
        {
            stove.Set100MaxPower();
        }

        public void Undo()
        {
            stove.PowerOff();
        }
    }
}
