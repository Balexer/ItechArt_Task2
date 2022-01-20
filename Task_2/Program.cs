using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargo volvo = new Cargo(5, 12, 20, 200, 160, 10000, "Volvo");
            
            volvo.Info();
            volvo.CheckCapacity(6);


        }
    }
}