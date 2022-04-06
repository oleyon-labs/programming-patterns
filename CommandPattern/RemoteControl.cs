using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class RemoteControl
    {
        ICommand[] commands;
        ICommand latCommand;
        public RemoteControl()
        {
            NoCommand noCommand = new NoCommand();
            commands = new ICommand[4];
            latCommand = noCommand;
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i] = noCommand;
            }
        }
        public void SetCommand(int button, ICommand command)
        {
            commands[button] = command;
        }
        public void PressButton(int button)
        {
            commands[button].Execute();
            latCommand = commands[button];
        }
        public void Undo()
        {
            latCommand.Undo();
        }
    }
}
