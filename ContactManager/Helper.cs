using System;
using System.Collections.Generic;

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

        public static void SortList(List<Person> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int j = i;
                Person temp = list[j];
                while ((j > 0) && list[j - 1].CompareTo(temp) > 0)
                {
                    list[j] = list[j - 1];
                    j--;
                }
                list[j] = temp;
            }
        }
    }
}