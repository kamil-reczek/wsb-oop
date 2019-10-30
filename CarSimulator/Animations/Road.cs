using System;
using System.Text;

namespace CarSimulator.Animations
{
    public class Road : IMovable
    {
        private int count;

        public Road()
        {
            count = 0;
        }

        private string GetRoad(string start)
        {
            string roadPart = start + (start == "-" ? " " : "-");
            StringBuilder road = new StringBuilder();
            for (int i = 0; i < Console.BufferWidth/2; i++)
            {
                road.Append(roadPart);
            }

            return road.ToString();
        }
        
        public string Move()
        {
            count++;
            return GetRoad(count % 2 == 0 ? "-" : " ");
        }
    }
}