using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BikeShopApp
{
    /// <summary>
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void EmailSupport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contact.xaml", UriKind.RelativeOrAbsolute));
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/testPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void LiveSupport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Discussion.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ProductManagement.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
