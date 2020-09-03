using Caliburn.Micro;
using System.Windows;

namespace StartCaliburnApp.ViewModels
{
    class ShellViewModel : PropertyChangedBase, IHaveDisplayName
    {
        string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get => !string.IsNullOrEmpty(Name);
        }

        public string DisplayName { get; set; }

        public ShellViewModel()
        {
            DisplayName = "Basic Caliburn App";
        }

        public void SayHello()
        {
            MessageBox.Show($"Hello {name}");
        }
    }
}
