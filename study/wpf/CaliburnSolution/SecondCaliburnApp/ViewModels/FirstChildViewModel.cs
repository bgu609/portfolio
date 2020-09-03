using Caliburn.Micro;
using System.Windows;

namespace SecondCaliburnApp.ViewModels
{
    public class FirstChildViewModel : Conductor<object>
    {
        public void FirstClicked()
        {
            MessageBox.Show("Hello World");
        }
    }
}
