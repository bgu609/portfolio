using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using FirstPrismApp.Views;
using Prism.Modularity;
using Prism.Mvvm;
using FirstPrismApp.ViewModels;

namespace FirstPrismApp
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<SubModule.ModuleLoader>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<MainView, MainViewModel>();
        }
    }
}
