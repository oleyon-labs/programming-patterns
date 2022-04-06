using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class TurnLightsOnCommand : ICommand
    {
        Lights lights;
        public TurnLightsOnCommand(Lights lights)
        {
            this.lights = lights;
        }
        public void Execute()
        {
            lights.On();
        }

        public void Undo()
        {
            lights.Off();
        }
    }
}
