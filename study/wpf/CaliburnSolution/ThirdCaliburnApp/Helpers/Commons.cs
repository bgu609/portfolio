namespace ThirdCaliburnApp
{
    public class Commons
    {
        internal static readonly string CONNSTRING = 
            "Data source=localhost;Port=3306;Database=testdb;Uid=root;Password=epfls+358471;";

        public class EmployeesTBL
        {
            public static string SELECT_EMPLOYEES = "SELECT id, " +
                                                    "       EmpName, " +
                                                    "       Salary, " +
                                                    "       DeptName, " +
                                                    "       Destination " +
                                                    "  FROM employeestbl ";

            public static string MAX_INDEX_GET = "SELECT MAX(id) FROM employeestbl";

            public static string INSERT_EMPLOYEES = "INSERT INTO employeestbl " +
                                                    "            ( " +
                                                    "               id, " +
                                                    "               EmpName, " +
                                                    "               Salary, " +
                                                    "               DeptName, " +
                                                    "               Destination) " +
                                                    "       VALUES " +
                                                    "            ( " +
                                                    "               @id, " +
                                                    "               @EmpName, " +
                                                    "               @Salary, " +
                                                    "               @DeptName, " +
                                                    "               @Destination " +
                                                    "            ) ";

            public static string UPDATE_EMPLOYEES = "UPDATE employeestbl " +
                                                    "   SET EmpName = @EmpName, " +
                                                    "       Salary = @Salary, " +
                                                    "       DeptName = @DeptName, " +
                                                    "       Destination = @Destination " +
                                                    " WHERE id = @id; ";

            public static string DELETE_EMPLOYEES = "DELETE FROM employeestbl WHERE id = @id ";
        }
    }
}