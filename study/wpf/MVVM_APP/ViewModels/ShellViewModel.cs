using MVVM_APP.Models;
using System;
using System.Windows;
using System.Windows.Input;

namespace MVVM_APP.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        #region 멤버 변수
        private string inFirstName;
        private string inLastName;
        private string inEmail;
        private DateTime? inDate;

        private string outFirstName;
        private string outLastName;
        private string outEmail;
        private string outDate;

        private string outAdult;
        private string outBirthday;
        private string outZodiac; // 2020-07-27 16:43 신규 추가
        private string outChnZodiac; // 2020-07-27 16:43 신규 추가

        public string InFirstName
        {
            get => inFirstName;
            set
            {
                inFirstName = value;
                RaisePropertyChanged("InFirstName");
            }
        }

        public string InLastName
        {
            get => inLastName;
            set
            {
                inLastName = value;
                RaisePropertyChanged("InLastName");
            }
        }

        public string InEmail
        {
            get => inEmail;
            set
            {
                inEmail = value;
                RaisePropertyChanged("InEmail");
            }
        }

        public DateTime? InDate
        {
            get => inDate;
            set
            {
                inDate = value;
                RaisePropertyChanged("InDate");
            }
        }

        public string OutFirstName
        {
            get => outFirstName;
            set
            {
                outFirstName = value;
                RaisePropertyChanged("OutFirstName");
            }
        }

        public string OutLastName
        {
            get => outLastName;
            set
            {
                outLastName = value;
                RaisePropertyChanged("OutLastName");
            }
        }

        public string OutEmail
        {
            get => outEmail;
            set
            {
                outEmail = value;
                RaisePropertyChanged("OutEmail");
            }
        }

        public string OutDate
        {
            get => outDate;
            set
            {
                outDate = value;
                RaisePropertyChanged("OutDate");
            }
        }

        public string OutAdult
        {
            get => outAdult;
            set
            {
                outAdult = value;
                RaisePropertyChanged("OutAdult");
            }
        }

        public string OutBirthday
        {
            get => outBirthday;
            set
            {
                outBirthday = value;
                RaisePropertyChanged("OutBirthday");
            }
        }

        public string OutZodiac // 2020-07-27 16:43 신규 추가
        {
            get => outZodiac;
            set
            {
                outZodiac = value;
                RaisePropertyChanged("OutZodiac");
            }
        }

        public string OutChnZodiac // 2020-07-27 16:43 신규 추가
        {
            get => outChnZodiac;
            set
            {
                outChnZodiac = value;
                RaisePropertyChanged("OutChnZodiac");
            }
        }
        #endregion

        ICommand clickCommand;
        public ICommand ClickCommand => clickCommand ?? (clickCommand = new RelayCommand<object>(
                o => Click(), o => IsClick()
            ));

        public void Click()
        {
            try
            {
                DateTime date = inDate ?? DateTime.Now;
                Person person = new Person(inFirstName, inLastName, inEmail, date);

                OutFirstName = person.FirstName;
                OutLastName = person.LastName;
                OutEmail = person.Email;
                OutDate = person.Date.ToShortDateString();
                OutAdult = $"{person.IsAdult}";
                OutBirthday = $"{person.IsBirthday}";
                OutZodiac = person.Zodiac; // 2020-07-27 16:43 신규 추가
                OutChnZodiac = person.ChnZodiac; // 2020-07-27 16:43 신규 추가
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        public bool IsClick()
        {
            return !string.IsNullOrEmpty(inFirstName) &&
                   !string.IsNullOrEmpty(inLastName) &&
                   !string.IsNullOrEmpty(inEmail) &&
                   !string.IsNullOrEmpty(inDate.ToString());
        }
    }
}
