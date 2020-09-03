using Caliburn.Micro;
using MvvmDialogs;
using System;
using System.Collections.Generic;
using System.Windows;
using ThirdCaliburnApp.Helpers;
using ThirdCaliburnApp.ViewModels;

namespace ThirdCaliburnApp
{
    public class Bootstrapper :BootstrapperBase
    {
        private SimpleContainer container;

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void Configure()
        {
            container = new SimpleContainer();
            container.Singleton<IWindowManager, WindowManager>();
            container.RegisterInstance(typeof(IDialogService), null, new DialogService(dialogTypeLocator: new DialogTypeLocator()));
            container.PerRequest<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}
