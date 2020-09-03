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
using BusinessLogic;

namespace BikeShopApp
{
    /// <summary>
    /// testPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class testPage : Page
    {
        

        public testPage()
        {
            InitializeComponent();
            //InitListboxMethod();
        }
        /*
        private void InitListboxMethod()
        {
            Random rand = new Random();
            string[] names = { "aaa", "bbb", "ccc", "ddd", "eee" };
            List<Car> car = new List<Car>();

            for (int i = 0; i < 10; i++)
            {
                byte r = (byte)(25 - i*25);
                byte g = (byte)(25 * i);
                byte b = (byte)(0);
                int idx = rand.Next(names.Length);
                car.Add(new Car()
                {
                    Speed = i * 10,
                    Color = Color.FromRgb(r,g,b),
                    //Driver = new Human() { Name = names[idx], HasDrivingLicense = true }
                });
            }
            ListBox1.DataContext = car;
            ComboBox1.DataContext = car;
        }*/

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Human h = new Human();
            h.Name = "nick";
            h.HasDrivingLicense = true;

            Car car2 = new Car();
            car2.Speed = 100;
            car2.Color = Colors.Blue;
            car2.Driver = h.Name;

            DataContext = car2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button click");
        }

        /*
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider.Value = (int)slider.Value;
        }*/
    }
}
