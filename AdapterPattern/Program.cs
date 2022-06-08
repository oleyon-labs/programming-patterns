using AdapterPattern;

ITimer clock = new MechanicalClockAdapter(new MechanicalClock());
clock.SetTimer(125);
Console.WriteLine(clock.GetTime());

clock = new ElectronicClockAdapter(new ElectronicClock());
clock.SetTimer(125);
Console.WriteLine(clock.GetTime());