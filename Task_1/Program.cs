using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer("I5", "16GB", "240GB", 2 );
            
            computer.Info();
            computer.TurningOn();
            computer.TurningOn();
            computer.TurningOff();
            computer.TurningOff();
            computer.TurningOn();
            computer.TurningOff();
            computer.TurningOn();
            computer.TurningOff();
            computer.TurningOn();
            computer.TurningOff();
        }
    }
}