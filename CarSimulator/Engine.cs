using System.Threading;

namespace CarSimulator
{
    public class Engine
    {
        private const double Multiplier = 100 * 3.785411784 / 1.609344;
        private const double DefaultTankVolume = 60.0;
        private const double DefaultFuelEfficiencyMultiplier = 0.0025;
        private const int DefaultSpeed = 100;

        private double _engineCapacity;
        private double _fuelLevel;
        private readonly double _tankVolume;
        private readonly double _fuelEfficiency;

        public Engine(double engineCapacity, double fuelLevel, double tankVolume = DefaultTankVolume)
        {
            _engineCapacity = engineCapacity;
            _fuelLevel = fuelLevel > tankVolume ? tankVolume : fuelLevel;
            _tankVolume = tankVolume;
            _fuelEfficiency = _tankVolume * DefaultFuelEfficiencyMultiplier;
        }
        
        public double FuelLevel => _fuelLevel;

        public double GetCurrentTankCapacity()
        {
            return _tankVolume - _fuelLevel;
        }

        public double GetMPG(double lpkm)
        {
            if (lpkm > 0) return Multiplier / lpkm;
            return -1;
        }

        public double GetLPK(double mpg)
        {
            if (mpg > 0) return Multiplier / mpg;
            return -1;
        }

        public void TankUp(double fuelAmount)
        {
            _fuelLevel += fuelAmount;
        }

        public void Operate(int distance)
        {
            _fuelLevel -= _fuelEfficiency * distance;
            Thread.Sleep(DefaultSpeed * distance);
        }
        
        public bool CanOperate()
        {
            return _fuelLevel > 0;
        }

        public bool FuelLevelWarning(double threshold)
        {
            return threshold > _fuelLevel / _tankVolume;
        }
    }
}