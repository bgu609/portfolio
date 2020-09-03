using Caliburn.Micro;
using System;

namespace MVVMChartApp.ViewModels
{
    internal class MainViewModel : Conductor<object>
    {
        public void ExitProgram()
        {
            Environment.Exit(0);
        }

        public void Load_LineChart()
        {
            ActivateItem(new LineChartViewModel());
        }

        public void Load_GaugeChart()
        {
            ActivateItem(new GaugeChartViewModel());
        }
    }
}
