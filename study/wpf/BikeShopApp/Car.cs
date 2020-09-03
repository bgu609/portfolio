using System.Windows.Media;

namespace BusinessLogic
{
    public class Car : Notifier
    {
        private double speed;
        public double Speed
        {
            get => speed;
            set { speed = value; OnPropertyChanged("Speed"); }
        }

        public string Driver { get; set; }

        private Color color;
        public Color Color
        {
            get => color;
            set { color = value; OnPropertyChanged("Color"); }
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public bool HasDrivingLicense { get; set; }
    }
}
