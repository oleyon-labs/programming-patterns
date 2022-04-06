using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class TurnLightsOffCommand : ICommand
    {
        Lights lights;
        public TurnLightsOffCommand(Lights lights)
        {
            this.lights = lights;
        }
        public void Execute()
        {
            lights.Off();
        }

        public void Undo()
        {
            lights.On();
        }
    }
}
