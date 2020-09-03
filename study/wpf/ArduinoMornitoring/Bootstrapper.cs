using ArduinoMornitoring.ViewModels;
using Caliburn.Micro;
using System.Windows;

namespace ArduinoMornitoring
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
