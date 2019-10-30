namespace CarSimulator.Animations
{
    public class Wheel : IMovable
    {
        private int counter;

        public Wheel()
        {
            counter = 0;
        }

        public string Move()
        {
            counter++;
            string result = "";
            switch (counter % 4)
            {
                case (0):
                    result = "/";
                    break;
                case (1):
                    result = "—";
                    break;
                case (2):
                    result = "\\";
                    break;
                case (3):
                    result = "|";
                    break;
            }
            return result;
        }
    }
}