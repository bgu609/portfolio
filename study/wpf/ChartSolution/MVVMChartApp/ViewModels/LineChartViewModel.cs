using Caliburn.Micro;
using LiveCharts;

namespace MVVMChartApp.ViewModels
{
    public class LineChartViewModel : Conductor<object>
    {
        ChartValues<double> lineValues { get; set; }

        public  ChartValues<double> LineValues
        {
            get => lineValues;
            set
            {
                lineValues = value;
                NotifyOfPropertyChange(() => LineValues);
            }
        }

        public LineChartViewModel()
        {
            DisplayName = "LineChartViewModel";
            InitializeChartData();
        }

        private void InitializeChartData()
        {
            LineValues = new ChartValues<double> { 3, 5, 6.7, 12.4, 0, 7, 9, 4.5 };
        }
    }
}
