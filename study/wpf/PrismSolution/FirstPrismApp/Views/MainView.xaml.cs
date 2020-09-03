//using Prism.Ioc;
//using Prism.Regions;
using System.Windows;

namespace FirstPrismApp.Views
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : Window
    {
        //IContainerExtension _container;
        //IRegionManager _regionManager;
        //IRegion _region;
        //SubViewA _viewA;
        //SubViewB _viewB;

        public MainView()//IContainerExtension container, IRegionManager regionManager)
        {
            InitializeComponent();
            //_container = container;
            //_regionManager = regionManager;
            //Loaded += MainView_Loaded;
        }

        //private void MainView_Loaded(object sender, RoutedEventArgs e)
        //{
        //    _viewA = _container.Resolve<SubViewA>();
        //    _viewB = _container.Resolve<SubViewB>();
        //    _region = _regionManager.Regions["ContentRegion"];
        //    _region.Add(_viewA);
        //    _region.Add(_viewB);
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    _region.Activate(_viewA);
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    _region.Deactivate(_viewA);
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    _region.Activate(_viewB);
        //}

        //private void Button_Click_3(object sender, RoutedEventArgs e)
        //{
        //    _region.Deactivate(_viewB);
        //}
    }
}
