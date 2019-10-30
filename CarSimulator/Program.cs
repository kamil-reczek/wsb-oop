using System;

namespace CarSimulator
{
    class MainClass
    {
        private static void MainLoop()
        {
            Car car = new Car("VW", "Passeratti", 1.8, 10);
            car.Drive(100);
        }
        
        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}