using Caliburn.Micro;
using SecondCaliburnApp.Commons;
using SecondCaliburnApp.Models;
using System.Data.SqlClient;

namespace SecondCaliburnApp.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
                NotifyOfPropertyChange(() => CanClearName);
            }
        }

        string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
                NotifyOfPropertyChange(() => CanClearName);
            }
        }

        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }

        public ShellViewModel()
        {
            DisplayName = "Second Caliburn App";
            FirstName = "GW";

            People = new BindableCollection<PersonModel>();
            People.Add(new PersonModel { LastName = "Gates", FirstName = "Bill" });
            People.Add(new PersonModel { LastName = "Corey", FirstName = "Tim" });
            People.Add(new PersonModel { LastName = "Jobs", FirstName = "Steve" });
        }

        public BindableCollection<PersonModel> People { get; set; } // 콤보박스에 들어가는 사람 리스트

        private PersonModel selectedPerson;

        public PersonModel SelectedPerson
        {
            get => selectedPerson;
            set
            {
                selectedPerson = value;
                LastName = selectedPerson.LastName;
                FirstName = selectedPerson.FirstName;
                NotifyOfPropertyChange(() => SelectedPerson);
                NotifyOfPropertyChange(() => CanClearName);
            }
        }

        public void ClearName()
        {
            this.FirstName = this.LastName = string.Empty;
        }

        public bool CanClearName
        {
            get => !(string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName));
        }

        public void LoadPage1()
        {
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPage2()
        {
            ActivateItem(new SecondChildViewModel());
        }

        private void InitComboBox()
        {
            using(SqlConnection conn = new SqlConnection(StaticInfos.CONNSTR))
            {
                conn.Open();
                string strQuery = InnerQry.GET_People_QRY;
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var temp = new PersonModel { FirstName = reader["FirstName"].ToString(), LastName = reader["LastName"].ToString() };
                    People.Add(temp);
                }
            }
        }
    }
}
