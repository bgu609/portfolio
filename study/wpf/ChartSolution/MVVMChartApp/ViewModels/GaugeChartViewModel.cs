using Caliburn.Micro;
using System.Threading;

namespace MVVMChartApp.ViewModels
{
    public class GaugeChartViewModel : Conductor<object>
    {
        double angValue;
        public double AngValue
        {
            get => angValue;
            set
            {
                //angValue => value;
                NotifyOfPropertyChange(() => AngValue);
            }
        }

        public Timer CustomTimer { get; set; }

        public GaugeChartViewModel()
        {
            //CustomTimer = new Timer(TickCallBack);
        }
    }
}
