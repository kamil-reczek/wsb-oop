using System;
using System.Text;
using CarSimulator.Animations;

namespace CarSimulator
{
    public class Car
    {
        private const char DefaultTrueFlag = 'Y';
        private const double DefaultFuelLevelWarningThreshold = 0.1;
        private string _make;
        private string _model;
        private Engine _engine;
        private CarAnimation _ca;
        private Dashboard _da;
        private int _distanceCounter;

        public int DistanceCounter => _distanceCounter;

        public string Make => _make;

        public string Model => _model;

        public Car(string make, string model, Engine engine)
        {
            _make = make;
            _model = model;
            _engine = engine;
            _ca = new CarAnimation();
            _da = new Dashboard(this, _engine);
            _distanceCounter = 0;
        }

        public Car(string make, string model, double engineCapacity, double fuelLevel, double tankVolume) :
            this(make, model, new Engine(engineCapacity, fuelLevel, tankVolume))
        {
        }

        public Car(string make, string model, double engineCapacity, double fuelLevel) :
            this(make, model, new Engine(engineCapacity, fuelLevel))
        {
        }

        public void Drive(int tripDistance)
        {
            int i = 0;
            while (tripDistance > 0 && _engine.CanOperate())
            {
                if (_engine.FuelLevelWarning(DefaultFuelLevelWarningThreshold))
                {
                    if (Helper.GetBool(
                        $"Fuel level is below {DefaultFuelLevelWarningThreshold:0%}! \nPress {DefaultTrueFlag} if you want to tank up the car? ",
                        DefaultTrueFlag))
                    {
                        TankUp();
                    }
                }

                _engine.Operate(1);
                i++;
                tripDistance--;
                _distanceCounter++;
                Console.Clear();
                Console.WriteLine(_da.GetDashboard());
                Console.WriteLine();
                Console.WriteLine(_ca.Animate());
            }

            Console.WriteLine(_engine.CanOperate() ? "Arrived!" : "There is no more fuel left!");
        }

        private void TankUp()
        {
            string msg = $"You can tank up to {_engine.GetCurrentTankCapacity()} liters ";
            double fuelAmount = Helper.GetDouble(msg, 0, _engine.GetCurrentTankCapacity());
            _engine.TankUp(fuelAmount);
        }
    }
}