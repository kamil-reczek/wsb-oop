using System;

namespace ContactManager
{
    public static class MainClass
    {
        private static void MainLoop()
        {
            bool exit = false;
            Console.WriteLine("----- CONTACT MANAGER -----");
            ContactManager cm = new ContactManager();
            cm.NumberOfContacts = Helper.ReadPositiveInt("Provide number of entries");
            cm.ReadContacts();
            while (!exit)
            {
                Helper.DisplayMainMenu();
                switch (Helper.ReadPositiveInt("Select"))
                {
                    case 1:
                        cm.DisplayAllContacts();
                        break;
                    case 2:
                        var num = Helper.ReadPositiveInt("Provide contact number");
                        cm.DisplayContactDetails(num - 1);
                        break;
                    case 3:
                        exit = true;
                        break;
                }
            }
        }

        public static void Main(string[] args)
        {
            MainLoop();
        }
    }
}