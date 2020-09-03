using Caliburn.Micro;
using MVVMChartApp.ViewModels;
using System.Windows;

namespace MVVMChartApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
