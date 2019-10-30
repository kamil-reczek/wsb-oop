using System;
using System.Text;

namespace CarSimulator.Animations
{
    public class Dashboard
    {
        private const int GaugeRange = 25;
        
        private Engine _engine;
        private Car _car;
        

        public Dashboard(Car car, Engine engine)
        {
            _engine = engine;
            _car = car;
        }

        private string GetCarMakeAndModel()
        {
            return _car.Make + " " + _car.Model;
        }

        private double GetFuelLevel()
        {
            return _engine.FuelLevel/(_engine.GetCurrentTankCapacity() + _engine.FuelLevel);
        }

        private string GetFuelGauge()
        {
            StringBuilder gauge = new StringBuilder("[");
            double fuelLevel = GetFuelLevel() * GaugeRange;
            for (int i = 1; i <= GaugeRange; i++)
            {
                gauge.Append(i <= fuelLevel ? "#" : "-");
            }
            gauge.Append("]");
            return gauge.ToString();
        }
        
        public string GetDashboard()
        {
            return $"{GetCarMakeAndModel()}\n" +
                   $"Fuel: {GetFuelLevel():0%}\t{GetFuelGauge()}\n" +
                   $"Distance counter: {_car.DistanceCounter}";
        }
    }
}