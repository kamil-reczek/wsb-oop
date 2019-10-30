using System;

namespace CarSimulator
{
    public class Helper
    {
        public static double GetDouble(string msg, double begin, double end)
        {
            do
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out var result) && result >= begin && result <= end) return result;
                Console.WriteLine($"Wrong input - provide double in range [{begin}, {end}]");
            }
            while (true);
        }

        public static bool GetBool(string msg, char trueFlag)
        {
            Console.Write(msg);
            if (!char.TryParse(Console.ReadLine(), out var result)) return false;
            return (trueFlag.ToString().ToUpper()).Equals(result.ToString().ToUpper());
        }
    }
}