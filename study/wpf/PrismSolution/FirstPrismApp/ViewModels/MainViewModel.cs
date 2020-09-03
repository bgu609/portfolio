using Prism.Commands;
using Prism.Mvvm;
using System;

namespace FirstPrismApp.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        private bool isEnabled;
        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                SetProperty(ref isEnabled, value);
                ExecuteCommand.RaiseCanExecuteChanged();
            }
        }

        private string updateText;
        public string UpdateText
        {
            get => updateText;
            set => SetProperty(ref updateText, value);
        }

        public DelegateCommand ExecuteCommand { get; set; }
        public DelegateCommand ObservesPropertyCommand { get; private set; }
        public DelegateCommand ObservesCanExecuteCommand { get; private set; }
        public DelegateCommand<string> ExecuteGenericCommand { get; private set; }

        public MainViewModel()
        {
            title = "Prism Unity Application";

            ExecuteCommand = new DelegateCommand(Execute, CanExecute);
            ObservesPropertyCommand = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => IsEnabled);
            ObservesCanExecuteCommand = new DelegateCommand(Execute).ObservesCanExecute(() => IsEnabled);
            ExecuteGenericCommand = new DelegateCommand<string>(ExecuteGeneric).ObservesCanExecute(() => IsEnabled);
        }

        private void ExecuteGeneric(string obj)
        {
            UpdateText = obj;
        }

        private void Execute()
        {
            UpdateText = $"Update: {DateTime.Now}";
        }

        private bool CanExecute()
        {
            return IsEnabled;
        }
    }
}
