using MvvmDialogs.DialogTypeLocators;
using System;
using System.ComponentModel;

namespace ThirdCaliburnApp.Helpers
{
    public class DialogTypeLocator : IDialogTypeLocator
    {
        public Type Locate(INotifyPropertyChanged viewModel)
        {
            Type viewModelType = viewModel.GetType();

            string dialogFullName = viewModelType.FullName;
            dialogFullName = dialogFullName.Substring(0, dialogFullName.Length - "Model".Length);

            return viewModelType.Assembly.GetType(dialogFullName);
        }
    }
}
