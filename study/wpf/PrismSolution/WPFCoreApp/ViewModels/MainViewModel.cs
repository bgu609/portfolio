using Prism.Mvvm;

namespace WPFCoreApp.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public MainViewModel()
        {
            title = "Prism Unity Application";
        }
    }
}
