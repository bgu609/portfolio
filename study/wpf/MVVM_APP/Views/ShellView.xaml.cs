using MahApps.Metro.Controls;
using MVVM_APP.ViewModels;

namespace WpfApplication
{
    public partial class ShellView : MetroWindow
    {
        public ShellView()
        {
            InitializeComponent();
            this.DataContext = new ShellViewModel();
        }
    }
}