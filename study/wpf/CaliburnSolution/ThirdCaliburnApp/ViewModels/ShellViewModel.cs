using Caliburn.Micro;
using MvvmDialogs;
using MySql.Data.MySqlClient;
using System.Dynamic;
using System.Windows;
using ThirdCaliburnApp.Models;
using static ThirdCaliburnApp.Commons;

namespace ThirdCaliburnApp.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHaveDisplayName
    {
        #region 속성
        private readonly IWindowManager windowManager;
        private readonly IDialogService nativeDialogService;

        public ShellViewModel(IWindowManager windowManager, IDialogService nativeDialogService)
        {
            this.windowManager = windowManager;
            this.nativeDialogService = nativeDialogService;

            GetEmployees();
        }

        BindableCollection<EmployeesModel> employees;
        public BindableCollection<EmployeesModel> Employees
        {
            get => employees;
            set
            {
                employees = value;
                NotifyOfPropertyChange(() => Employees);
            }
        }

        EmployeesModel seletedEmployees;
        public EmployeesModel SelectedEmployees
        {
            get => seletedEmployees;
            set
            {
                seletedEmployees = value;

                if(value!=null)
                {
                    id = value.ID;
                    empname = value.EmpName;
                    salary = value.Salary;
                    deptname = value.DeptName;
                    destination = value.Destination;
                }

                NotifyOfPropertyChange(() => SelectedEmployees);
                NotifyOfPropertyChange(() => ID);
                NotifyOfPropertyChange(() => EmpName);
                NotifyOfPropertyChange(() => Salary);
                NotifyOfPropertyChange(() => DeptName);
                NotifyOfPropertyChange(() => Destination);
                NotifyOfPropertyChange(() => CanSaveButton);
                NotifyOfPropertyChange(() => CanDelButton);
            }
        }

        int id;
        public int ID {
            get=>id;
            set
            {
                id = value;
                NotifyOfPropertyChange(() => ID);
                NotifyOfPropertyChange(() => CanSaveButton);
                NotifyOfPropertyChange(() => CanDelButton);
            }
        }

        string empname;
        public string EmpName
        {
            get => empname;
            set
            {
                empname = value;
                NotifyOfPropertyChange(() => EmpName);
                NotifyOfPropertyChange(() => CanSaveButton);
            }
        }

        decimal salary;
        public decimal Salary
        {
            get => salary;
            set
            {
                salary = value;
                NotifyOfPropertyChange(() => Salary);
                NotifyOfPropertyChange(() => CanSaveButton);
            }
        }

        string deptname;
        public string DeptName
        {
            get => deptname;
            set
            {
                deptname = value;
                NotifyOfPropertyChange(() => DeptName);
                NotifyOfPropertyChange(() => CanSaveButton);
            }
        }

        string destination;
        public string Destination
        {
            get => destination;
            set
            {
                destination = value;
                NotifyOfPropertyChange(() => Destination);
                NotifyOfPropertyChange(() => CanSaveButton);
            }
        }

        #endregion

        #region 생성자

        public ShellViewModel()
        {

        }

        #endregion

        public void GetEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(CONNSTRING))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(EmployeesTBL.SELECT_EMPLOYEES, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Employees = new BindableCollection<EmployeesModel>();
                while (reader.Read())
                {
                    var temp = new EmployeesModel
                    {
                        ID = (int)reader["id"],
                        EmpName = reader["empName"].ToString(),
                        Salary = (decimal)reader["salary"],
                        DeptName = reader["deptName"].ToString(),
                        Destination = reader["destination"].ToString()
                    };
                    Employees.Add(temp);
                }

                conn.Close();
            }
        }

        public void DelEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(CONNSTRING))
            {
                int resultsRow = 0;

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(EmployeesTBL.DELETE_EMPLOYEES, conn);

                MySqlParameter paramID = new MySqlParameter("@id", MySqlDbType.Int32);
                paramID.Value = ID;
                cmd.Parameters.Add(paramID);

                resultsRow = cmd.ExecuteNonQuery();

                if (resultsRow > 0)
                {
                    GetEmployees();
                    //MessageBox.Show("삭제했습니다!");
                    var dialogVM = new DialogViewModel();
                    dialogVM.DisplayName = "삭제했습니다!";
                    var success = windowManager.ShowDialog(dialogVM);
                }

                conn.Close();
            }
        }

        public int NewMaxID()
        {
            int MAX_ID = 0;

            using (MySqlConnection conn = new MySqlConnection(CONNSTRING))
            {
                conn.Open();

                MySqlCommand maxidx = new MySqlCommand(EmployeesTBL.MAX_INDEX_GET, conn);
                MySqlDataReader reader = maxidx.ExecuteReader();

                while (reader.Read())
                {
                    MAX_ID = (int)reader["MAX(id)"] + 1;
                }

                conn.Close();
            }

            return MAX_ID;
        }

        public bool CanSaveButton
        {
            get
            {
                return !((ID == 0) ||
                         string.IsNullOrEmpty(EmpName) ||
                         (Salary == 0) ||
                         string.IsNullOrEmpty(DeptName) ||
                         string.IsNullOrEmpty(Destination));
            }
        }

        public bool CanDelButton
        {
            get
            {
                return !((ID == 0) ||
                          ID == NewMaxID());
            }
        }

        public void SaveButton()
        {
            int resultsRow = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(CONNSTRING))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    MySqlParameter paramID = new MySqlParameter("@id", MySqlDbType.Int32);
                    MySqlParameter paramEmpName = new MySqlParameter("@EmpName", MySqlDbType.VarChar, 45);
                    MySqlParameter paramSalary = new MySqlParameter("@Salary", MySqlDbType.Decimal);
                    MySqlParameter paramDeptName = new MySqlParameter("@DeptName", MySqlDbType.VarChar, 45);
                    MySqlParameter paramDestination = new MySqlParameter("@Destination", MySqlDbType.VarChar, 45);

                    if (ID == NewMaxID())
                    {
                        cmd = new MySqlCommand(EmployeesTBL.INSERT_EMPLOYEES, conn);
                    }
                    else
                    {
                        cmd = new MySqlCommand(EmployeesTBL.UPDATE_EMPLOYEES, conn);
                    }

                    paramID.Value = ID;
                    paramEmpName.Value = EmpName;
                    paramSalary.Value = Salary;
                    paramDeptName.Value = DeptName;
                    paramDestination.Value = Destination;

                    cmd.Parameters.Add(paramID);
                    cmd.Parameters.Add(paramEmpName);
                    cmd.Parameters.Add(paramSalary);
                    cmd.Parameters.Add(paramDeptName);
                    cmd.Parameters.Add(paramDestination);

                    resultsRow = cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (System.Exception ex)
            {
                var dialogVM = new DialogViewModel();
                dialogVM.DisplayName = ex.ToString();
                var success = windowManager.ShowDialog(dialogVM);
            }

            if (resultsRow > 0)
            {
                GetEmployees();

                ID = 0;
                EmpName = string.Empty;
                Salary = 0;
                DeptName = string.Empty;
                Destination = string.Empty;

                //MessageBox.Show("저장했습니다!");
                var dialogVM = new DialogViewModel();
                dialogVM.DisplayName = "저장했습니다!";
                var success = windowManager.ShowDialog(dialogVM);
            }
        }

        public void DelButton()
        {
            DelEmployees();

            ID = 0;
            EmpName = string.Empty;
            Salary = 0;
            DeptName = string.Empty;
            Destination = string.Empty;

            NotifyOfPropertyChange(() => CanSaveButton);
        }

        public void NewButton()
        {
            ID = NewMaxID();
            EmpName = string.Empty;
            Salary = 0;
            DeptName = string.Empty;
            Destination = string.Empty;

            NotifyOfPropertyChange(() => CanSaveButton);
        }
    }
}
