using System;

namespace ContactManager
{
    public static class Helper
    {
        
        public static int ReadPositiveInt(string msg)
        {
            int result = 0;
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out result) && result > 0) break;
                Console.WriteLine("Input is not an positive integer, try again");
            }

            return result;
        }
        
        public static void DisplayMainMenu()
        {
            Console.WriteLine("----- CONTACT MANAGER MENU -----");
            Console.WriteLine($"[1] Display all contacts");
            Console.WriteLine($"[2] View contact details");
            Console.WriteLine($"[3] Exit");
        }
    }
}