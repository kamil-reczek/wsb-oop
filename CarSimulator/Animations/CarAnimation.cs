using System.Text;

namespace CarSimulator.Animations
{
    public class CarAnimation
    {
        private const string indent = "\t\t";
        
        private Wheel _backWheel;
        private Wheel _frontWheel;
        private Road _road;
        
        public CarAnimation()
        {
            _road = new Road();
            _backWheel = new Wheel();
            _frontWheel = new Wheel();
        }

        public string Animate()
        {
            StringBuilder chassis = new StringBuilder($"+----{_backWheel.Move()}----------------{_frontWheel.Move()}------+");
            StringBuilder body = new StringBuilder();
            body.Append(indent);
            body.Append(" _________________ ").Append("\n");
            body.Append(indent);
            body.Append("|                 \\").Append("\n");
            body.Append(indent);
            body.Append("|                  \\_________").Append("\n");
            body.Append(indent);
            body.Append("|                            \\").Append("\n");
            body.Append(indent);
            body.Append(chassis).Append("\n");
            return body.ToString() + _road.Move();
        }
    }
}