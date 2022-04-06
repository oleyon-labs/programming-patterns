namespace CommandPattern;
internal class Program
{
    static void Main(string[] args)
    {
        RemoteControl rc = new RemoteControl();
        Stove stove = new Stove();
        Lights lights = new Lights();
        rc.SetCommand(0, new TurnLightsOnCommand(lights));
        rc.SetCommand(1, new TurnLightsOffCommand(lights));
        rc.SetCommand(2, new SetStove50MaxPowerCommand(stove));
        rc.SetCommand(3, new StovePowerOffCommand(stove));



        bool isNotExiting = true;
        while(isNotExiting)
        {
            Console.WriteLine("Кнопки 1..4");
            Console.WriteLine("5 отмена");
            Console.WriteLine("6 выход");
            int choice = int.Parse(Console.ReadLine()!);
            if(choice == 6)
                isNotExiting = false;
            else if(choice == 5)
            {
                rc.Undo();
            }
            else if(choice >= 1 && choice<=4)
            {
                choice--;
                rc.PressButton(choice);
            }
        }
    }
}