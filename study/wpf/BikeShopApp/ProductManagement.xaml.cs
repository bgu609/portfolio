using BikeShop;
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
    /// ProductManagement.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductManagement : Page
    {
        ProductsFactory factory = new ProductsFactory();

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GridProducts.ItemsSource = factory.FindProducts(txtSearch.Text);
            }
        }
    }
}
